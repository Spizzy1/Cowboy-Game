using Godot;
using System;

public partial class Inventory : Node
{
	int current_cylinder_slot = 0; 
	Node[] cylinder_slots = new Node[6];
	
	public void change_cylinder(){
		current_cylinder_slot += 1;
		current_cylinder_slot %= 6;

	}
	public Node get_current_cylinder(){
		return cylinder_slots[current_cylinder_slot];
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
