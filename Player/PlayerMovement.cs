using Godot;
using System;

public partial class PlayerMovement : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{

		Vector2 velocity = Velocity;



		if(Input.IsActionPressed("action_1")!=true){

			//har samma rad i "PlayerRotation", borde nog kunna göra de till samma.
			Vector2 direction = Input.GetVector("move_left", "move_right", "move_up", "move_down");

			velocity = direction * Speed;


			Velocity = velocity;
			MoveAndSlide();
		}
		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.

	}


}
