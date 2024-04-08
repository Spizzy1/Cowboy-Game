using Godot;
using System;

public partial class Stråtrövare : CharacterBody2D
{
    private NavigationAgent2D _navigationAgent;

    private float _movementSpeed = 200.0f;
    private Vector2 _movementTargetPosition = new Vector2(70.0f, 226.0f);

    public Vector2 MovementTarget
    {
        get { return _navigationAgent.TargetPosition; }
        set { _navigationAgent.TargetPosition = value; }
    }

    public float distanceToTarget;

    public override void _Ready()
    {
        base._Ready();
        GD.Print("ready");
        

        _navigationAgent = GetNode<NavigationAgent2D>("NavigationAgent2D");

        // These values need to be adjusted for the actor's speed
        // and the navigation layout.
        _navigationAgent.PathDesiredDistance = 4.0f;
        _navigationAgent.TargetDesiredDistance = 4.0f;

        // Make sure to not await during _Ready.
        Callable.From(ActorSetup).CallDeferred();
    }

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);

        MovementTarget = GetParent().GetNode<CharacterBody2D>("Player1").Position; 

        if (_navigationAgent.IsNavigationFinished())
        {
            return;
        }

        Vector2 currentAgentPosition = GlobalTransform.Origin;
        Vector2 nextPathPosition = _navigationAgent.GetNextPathPosition();
        if()
        Velocity = currentAgentPosition.DirectionTo(nextPathPosition) * _movementSpeed;


        
        distanceToTarget = currentAgentPosition.DistanceTo(MovementTarget);
        
        GD.Print(":) "+distanceToTarget);
        
        MoveAndSlide();
    }

    private async void ActorSetup()
    {
        GD.Print("actorsetup");
        // Wait for the first physics frame so the NavigationServer can sync.
        await ToSignal(GetTree(), SceneTree.SignalName.PhysicsFrame);

        // Now that the navigation map is no longer empty, set the movement target.
        MovementTarget = GetParent().GetNode<CharacterBody2D>("Player1").Position;
    }
}
