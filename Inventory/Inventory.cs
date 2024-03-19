using Godot;
using System;
using System.Linq;
using enums;

public partial class Inventory : Node2D
{
	//Current index of the revolver
	int current_cylinder_slot = 0;
	//Shows bullet type, might wrap it in a global class later


	//Internal list of above mentioned enum
	BulletBase[] cylinder_slots = new BulletBase[6];

	//The amount of time spent holding the action button
	float delta_release = 0;

	//Publicly accessible function to rotate the chamber
	public void change_cylinder()
	{
		GD.Print("change cylinder");
		current_cylinder_slot += 1;
		current_cylinder_slot %= 6;

	}

	//Checks if you can pick up a bullet (and does so if you can)
	void pickup_bullet()
	{
		
		GD.Print(GetNode<Area2D>("Pickup_Area").GetOverlappingAreas());
		//den här triggar ALLTID!!!! (BRA) /Louie
		foreach (Area2D area in GetNode<Area2D>("Pickup_Area").GetOverlappingAreas())
		{
			if (area.Name == "BulletCollectArea" && cylinder_slots[current_cylinder_slot] == null)
			{
				BulletBase instance =  area.GetParent<BulletBase>();
				BulletBase clone = instance.Duplicate() as BulletBase;
				instance.QueueFree();
				cylinder_slots[current_cylinder_slot] = clone;
				GD.Print("pickedupbullet");

			}
			else
			{
				//Do funny ERROR sound
				//*WRONG BUZZER*
				GD.Print("No.");
			}
		}
		
	}
	public void remove_bullet(){
		cylinder_slots[current_cylinder_slot] = null;
	}
	public BulletBase get_current_cylinder()
	{
		return cylinder_slots[current_cylinder_slot];
	}
	public override void _Input(InputEvent @event)
	{
		if (@event.IsActionReleased("action_2"))
		{
			if (delta_release > 0.2f)
			{
				change_cylinder();
			}
			else
			{
				pickup_bullet();
			}
		}
		base._Input(@event);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("action_2"))
		{
			delta_release += (float)delta;
		}
		else
		{
			delta_release = 0;
		}
	}
}
