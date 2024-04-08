using Godot;
using System;

public partial class Aggressive : State
{

	float _distance;

    bool aggressive=true;


	public override void Enter(){
        GD.Print("i am agressive now (crazy how that works)");
		aggressive=true;
    }


	public override void Update(float delta)
    {
        _distance = 1000 / (GetParent().GetParent().GetParent().GetNode<Stråtrövare>("Stråtrövare").distanceToTarget);

        GD.Print("_distance: "+_distance);


        base.Update(delta);
    } 


}
