using Godot;
using System;

public partial class BulletBase : RigidBody2D
{
	public float bulletSpd;
	public float bulletDmg;

	//public string[] bulletTypes=new string[1];

	public bool dormant; //temp title, alternatively "shooted", "isFired", "firedStatus", etc.

	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
