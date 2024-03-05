using Godot;
using System;

public partial class PlayerRotation : Node2D
{
	Vector2 direction;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	/*public override void _Input(InputEvent @event)
	{
		if(Input.GetVector("move_left", "move_right", "move_up", "move_down")!=Vector2.Zero){

				direction = Input.GetVector("move_left", "move_right", "move_up", "move_down");
				GD.Print(direction.Angle());

				float _test= (float)GetProcessDeltaTime();

				Rotation = Mathf.Lerp(Rotation, direction.Angle(), (float)GetProcessDeltaTime()*59);
		}

		base._Input(@event);
	}*/


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		if (Input.GetVector("move_left", "move_right", "move_up", "move_down")!=Vector2.Zero)
		{
			direction = Input.GetVector("move_left", "move_right", "move_up", "move_down");
			//Rotation = Mathf.Lerp(Rotation, direction.Angle(), (float)delta*30);
			Rotation = direction.Angle();
		}
		else
		{

		}
		
	}
}
