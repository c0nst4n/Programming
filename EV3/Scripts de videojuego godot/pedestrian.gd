extends KinematicBody2D

var isalive = true
var rng = RandomNumberGenerator.new()
var dir = Vector2(0,0)
var speed = 8
var friction = 0.9
var facingx = true
var facingy = true
onready var anim = $AnimationPlayer

func _ready():
	anim.play("live")
	$dir_timer.start()

func _physics_process(delta):
	if isalive:
		move()

func move():
	if facingx == true:
		dir.x += speed
	if facingx == false:
		dir.x -= speed
	if facingy == true:
		dir.y += speed
	if facingy == false:
		dir.y -= speed

	dir.x *= friction
	dir.y *= friction
	dir = move_and_slide(dir)

func change_direction():
	var resx = rng.randf_range(-1, 1)
	var resy = rng.randf_range(-1, 1)
	
	if resx < 1:
		facingx = false
	if resx > 0:
		facingx = true
	
	if resy < 1:
		facingy = false
	if resy > 0:
		facingy = true


func _on_dir_timer_timeout():
	change_direction()

func take_damage():
	isalive = false
	anim.play("die")


func _on_VisibilityNotifier2D_screen_exited():
	if isalive == false:
		queue_free()
