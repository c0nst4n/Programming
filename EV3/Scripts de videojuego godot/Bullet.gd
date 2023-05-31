extends Area2D
#Visual Studio Code tiene una extensión para este lenguaje (godot-tools gdscript)
const RIGHT = Vector2.RIGHT
var speed  = 5000

var velocity = Vector2()


func _physics_process(delta):
	var movement = RIGHT.rotated(rotation) * speed * delta
	global_position += movement

func _ready():
	pass


func _on_bullet_body_entered(body):
	if body.has_method('take_damage'):
		body.take_damage()
	queue_free()


func _on_Timer_timeout():
	queue_free()


func _on_VisibilityNotifier2D_screen_exited():
	queue_free()


func _on_VisibilityNotifier2D_screen_entered():
	pass # Replace with function body.
