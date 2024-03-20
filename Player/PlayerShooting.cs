using Godot;
using System;
using enums;

public partial class PlayerShooting : Node2D
{


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	public override void _Input(InputEvent @event)
	{
		
		if(@event.IsActionReleased("action_1")){
			
			//snälla framtida louie, ö
			//fixa dena fula (men roliga) kod. jag lämnar detta ärade uppdrag till dig för att jag (nutida louie) orkar inte just nu. 
			//tack :))
			if(GetParent().GetParent().GetNode<Inventory>("InventorySystem").get_current_cylinder() != null){
				GD.Print("pew pew you shoot wow hahahahahah ahahahahha wowza!!!! yippeeeE!!!! yippe yahooooo!!!! wahooooo!!!!!");

				var scene = GD.Load<PackedScene>("res://Bullets/bullet_real.tscn");
				//GD.Print(GetParent().GetNode<Inventory>("InventorySystem").get_current_cylinder());
				var instance = scene.Instantiate<Node2D>();
				GetTree().Root.GetChild(0).AddChild(instance);
				//i will live myself :), i  fix this 
				instance.Position = GlobalPosition;
				instance.Rotation = GlobalRotation;


				// gör så att den här kod-klumpen faktiskt skjuter rätt kula, inte bara en basic
				
				GetParent().GetParent().GetNode<Inventory>("InventorySystem").remove_bullet();
				GetParent().GetParent().GetNode<Inventory>("InventorySystem").change_cylinder();
			}
			else{
				GD.Print("not work (good)");
				GD.Print(GetParent().GetParent().GetNode<Inventory>("InventorySystem").get_current_cylinder());
			}
		}

		base._Input(@event);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}


}
