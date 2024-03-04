using Godot;
using System;

public partial class Inventory : Node
{
	int current_slot = 0; 
	int[] inventory_slots = new int[6];
	int[] cylinder_slots = new int[6];
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
    }


    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}
}
