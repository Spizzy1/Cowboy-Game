using Godot;
using System;

public partial class Standoff : State
{

    float _distance;

    float _aggro;

    public override void Enter(){
        GD.Print("i am standoff now (crazy how that works)");
    }


    public override void Update(float delta)
    {
        _distance = 100 / (GetParent().GetParent().GetParent().GetNode<Stråtrövare>("Stråtrövare").distanceToTarget);

        

        GD.Print("_distance: "+_distance);
        GD.Print("distanceToTarget: "+GetParent().GetParent().GetParent().GetNode<Stråtrövare>("Stråtrövare").distanceToTarget);
        var random = new RandomNumberGenerator();
        random.Randomize();

        _aggro=random.RandfRange(0.5f,5f);
        GD.Print("aggro: "+_aggro);


        if(_aggro<_distance){
            GD.Print("ARGGHHH NU ÄR JAG ARGGGG!!!! !!1!");
            fsm.TransitionTo("Attacking");
        }
        else{
            GD.Print("inte arg :))");
        }

        base.Update(delta);
    }



    
}
