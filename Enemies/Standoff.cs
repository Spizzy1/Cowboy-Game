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
        _distance = 1000 / (GetParent().GetParent().GetParent().GetNode<Stråtrövare>("Stråtrövare").distanceToTarget);

        GD.Print("_distance: "+_distance);
        var random = new RandomNumberGenerator();
        random.Randomize();

        _aggro=random.RandfRange(0,1);
        GD.Print("aggro: "+_aggro);


        if(_aggro>_distance){
            GD.Print("ARGGHHH NU ÄR JAG ARGGGG!!!! !!1!");
        }
        else{
            GD.Print("inte arg :))");
        }

        base.Update(delta);
    }



    
}
