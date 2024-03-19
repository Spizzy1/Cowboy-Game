using Godot;
using System;

public partial class NormalBullet : BulletBase
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		base._Ready();
	
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}



	public override void _PhysicsProcess(double delta){

		if(dormant==false){
			LinearVelocity = Transform.X * 1 * bulletSpd;
		}
		else{
			LinearVelocity=Vector2.Zero;
		}
		//GD.Print(LinearVelocity);
		
	}
}
