using Godot;
using System;

public partial class PlayerShooting : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	public override void _Input(InputEvent @event)
	{
		if(@event.IsActionReleased("action_1")){
			GD.Print("pew pew you shoot wow hahahahahah ahahahahha wowza!!!! yippeeeE!!!! yippe yahooooo!!!! wahooooo!!!!!");

			GD.Print(GetParent().GetNode<Inventory>("Inventory").inventory_slots[GetParent().GetNode<Inventory>("Inventory").current_inventory_slot]);

			//snälla framtida louie, 
			//fixa dena fula (men roliga) kod. jag lämnar detta ärade uppdrag till dig för att jag (nutida louie) orkar inte just nu. 
			//tack :))
			if(GetParent().GetNode<Inventory>("Inventory").inventory_slots[GetParent().GetNode<Inventory>("Inventory").current_inventory_slot]!=null){
				GD.Print("working");
			}
			else{
				GD.Print("not work (good)");
			}
		}

		base._Input(@event);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}


}
