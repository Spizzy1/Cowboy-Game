using enums;
using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class LevelLoader : Node2D {
    public int HP; 
    public BulletBase[] bullets = new BulletBase[6];
    
    public override void _Ready(){
        base._Ready();
        
        var scene = GD.Load<PackedScene>("res://Bullets/bullet_real.tscn");
        for(int i = 0; i < bullets.Length; i++){
            
            bullets[i] = scene.Instantiate() as NormalBullet;

        }
    }

}
