using Godot;
using System;

public partial class Attacking : State
{
	
	public bool _attacking=false;
	public override void Enter(){
        GD.Print("i am agressive now (crazy how that works)");
		_attacking=true;
    }
}
