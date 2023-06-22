using Godot;
using System;

public partial class main : Node2D
{
	
	// Called when the Play button is pressed
	private void On_Play_Pressed()
	{
		GetTree().ChangeSceneToFile("res://world.tscn");
	}
	
	
	// Example: Exiting the game when a button is clicked
	private void On_Quit_Pressed()
	{
		SceneTree sceneTree = GetTree(); // Get the current SceneTree
		sceneTree.Quit(); // Quit the game
	}

	
}
