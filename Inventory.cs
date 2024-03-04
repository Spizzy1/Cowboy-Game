using Godot;
using System;

public partial class Inventory : Node
{
	int current_inventory_slot = 0;
	int current_cylinder_slot = 0; 
	int[] inventory_slots = new int[6];
	int[] cylinder_slots = new int[6];
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
	public override void _Input(InputEvent @event)
	{
		if(@event.IsActionReleased("action_1")){
			current_inventory_slot += 1;
			current_inventory_slot %= 6;
			GD.Print(current_inventory_slot);
		}
		if(@event.IsActionReleased("action_2")){
			current_cylinder_slot += 1;
			current_cylinder_slot %= 6;
			GD.Print(current_cylinder_slot);
		}
		base._Input(@event);
	}


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
