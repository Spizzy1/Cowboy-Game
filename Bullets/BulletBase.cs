using Godot;
using System;
using enums;

public partial class BulletBase : RigidBody2D
{
	[Export]
	public float bulletSpd;
	[Export]
	public float bulletDmg;
	[Export]
	public bullets bullet_type;
	

	//public string[] bulletTypes=new string[1];

	public bool dormant; //temp title, alternatively "shooted", "isFired", "firedStatus", etc.

	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		bullet_type = bullets.BASIC_BULLET;
		dormant=false;

		//GD.Print(this.GetNode<RigidBody2D>("BulletReal"));
		BodyEntered += (body) => CollideEnter(body);
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public override void _PhysicsProcess(double delta)
    {
		
        base._PhysicsProcess(delta);
    }

	public void CollideEnter(Node node)
	{
		//GD.Print("test");
		dormant=true;
	}



	//public override 
}
