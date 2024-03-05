using enums;
using Godot;
using System;
using System.Collections.Generic;

public partial class BulletManager : Node2D
{
	Dictionary<bullets, Node2D> bullet_requests = new Dictionary<bullets, Node2D>();
    public override void _Ready()
    {
        base._Ready();

		bullet_requests.Add(bullets.EMPTY,null);
    }
}
