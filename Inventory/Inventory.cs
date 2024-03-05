using Godot;
using System;

public partial class Inventory : Node
{
	int current_inventory_slot = 0;
	int current_cylinder_slot = 0; 
	Node[] inventory_slots = new Node[6];
	Node[] cylinder_slots = new Node[6];
	
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
