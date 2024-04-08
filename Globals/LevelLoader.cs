using enums;
using Godot;
using System;
using System.Collections.Generic;

public partial class LevelLoader : Node2D
{
    List<PackedScene> levels = new List<PackedScene>();
    int current_index = -1;
    public void LoadLevel(){ 

        if(current_index != -1){
            var random = new RandomNumberGenerator();
            bool level_exists = GetTree().Root.HasNode("Level");

            if(level_exists){
                
            }

             

        }

    }

    void _UnloadLevel(int index){

    }
}
