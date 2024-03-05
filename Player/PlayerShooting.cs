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
			
			var scene = GD.Load<PackedScene>("res://Bullets/bullet_real.tscn");
			GD.Print(GetParent().GetNode<Inventory>("InventorySystem").get_current_cylinder());
			var instance = scene.Instantiate<Node2D>();
			
			GetParent().GetParent().AddChild(instance);
			instance.Position = GetOwner<Node2D>().GlobalPosition;
			
			//snälla framtida louie, ö
			//fixa dena fula (men roliga) kod. jag lämnar detta ärade uppdrag till dig för att jag (nutida louie) orkar inte just nu. 
			//tack :))
			if(GetParent().GetNode<Inventory>("InventorySystem").get_current_cylinder() != null){
				GD.Print("pew pew you shoot wow hahahahahah ahahahahha wowza!!!! yippeeeE!!!! yippe yahooooo!!!! wahooooo!!!!!");

				
				GetParent().GetNode<Inventory>("InventorySystem").change_cylinder();
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
