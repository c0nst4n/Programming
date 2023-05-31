extends KinematicBody2D

var wheel_base = 70 
var steering_angle = 0.40  
var engine_power = 2000  
#var hp = 100
var acceleration = Vector2.ZERO
var velocity = Vector2.ZERO
var steer_angle
var friction = 0.1
var drag = -0.0015
onready var anim = $AnimationPlayer
var braking = -1600
var max_speed_reverse = 400

var slip_speed = 400 
var traction_fast = 0  
var traction_slow = 0.7  

var bullet_speed = 2000
var Bullet = preload("res://bullet.tscn")
var can_shoot = true
var cooldown = 0.4


func _ready():
	$GunTimer.wait_time = cooldown

func _physics_process(delta):
	acceleration = Vector2.ZERO
	get_input()
	apply_friction()
	calculate_steering(delta)
	velocity += acceleration * delta
	velocity = move_and_slide(velocity)
	

func get_input():
	var turn = 0
	if Input.is_action_pressed("ui_right"):
		turn -= 1
	if Input.is_action_pressed("ui_left"):
		turn += 1
	steer_angle = turn * steering_angle
	if Input.is_action_pressed("ui_up"):
		acceleration = transform.x * engine_power
	if Input.is_action_pressed("ui_down"):
		acceleration = transform.x * braking
	
	$gun.look_at(get_global_mouse_position())
	
	if Input.is_action_just_pressed("Left_click"):
		fire()


func calculate_steering(delta):
	var rear_wheel = position - transform.x * wheel_base / 2.0
	var front_wheel = position + transform.x * wheel_base / 2.0
	rear_wheel += velocity * delta
	front_wheel += velocity.rotated(steer_angle) * delta
	var new_heading = (front_wheel - rear_wheel).normalized()
	var traction = traction_fast
	if velocity.length() > slip_speed:
		traction = traction_slow
	var direction = new_heading.dot(velocity.normalized())
	if direction > 0:
		velocity = velocity.linear_interpolate(new_heading * velocity.length(), traction)
	if direction < 0:
		velocity = -new_heading * min(velocity.length(), max_speed_reverse)
	rotation = new_heading.angle()

func apply_friction():
	if velocity.length() < 5:
		velocity = Vector2.ZERO
	var friction_force = velocity * friction
	var drag_force = velocity * velocity.length() * drag
	if velocity.length() < 100:
		friction_force *= 3
	acceleration += drag_force + friction_force

func fire():
	if can_shoot:
		can_shoot = false
		$Camera2D/Screenshake.start()
		$GunTimer.start()
		var _bullet = Bullet.instance()
		get_tree().current_scene.add_child(_bullet)
		_bullet.global_position = $gun/tip.global_position
		_bullet.global_rotation = $gun/tip.global_rotation



func _on_GunTimer_timeout():
	can_shoot= true


func _on_atropeller_body_entered(body):
	if body.has_method('take_damage'):
		body.take_damage()
		$Camera2D/Screenshake.start()
