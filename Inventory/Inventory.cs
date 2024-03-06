using Godot;
using System;
using System.Linq;
using enums;

public partial class Inventory : Node
{
	//Current index of the revolver
	int current_cylinder_slot = 0;
	//Shows bullet type, might wrap it in a global class later


	//Internal list of above mentioned enum
	bullets[] cylinder_slots = Enumerable.Repeat(bullets.EMPTY, 6).ToArray();

	//The amount of time spent holding the action button
	float delta_release = 0;

	//Publicly accessible function to rotate the chamber
	public void change_cylinder()
	{
		current_cylinder_slot += 1;
		current_cylinder_slot %= 6;

	}
	//Checks if you can pick up a bullet (and does so if you can)
	void pickup_bullet()
	{
		foreach (Area2D area in GetNode<Area2D>("Pickup_Area").GetOverlappingAreas())
		{
			if (area.Name == "BulletCollectArea" && cylinder_slots[current_cylinder_slot] == bullets.EMPTY)
			{

			}
			else
			{
				//Do funny ERROR sound
				//*WRONG BUZZER*
			}
		}
	}

	public bullets get_current_cylinder()
	{
		return cylinder_slots[current_cylinder_slot];
	}
	public override void _Input(InputEvent @event)
	{
		if (@event.IsActionReleased("action_2"))
		{
			if (delta_release > 0.5f)
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
