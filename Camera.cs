using Godot;
using System;
using System.Diagnostics;

public partial class Camera : Camera3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
    Debug.WriteLine("balls");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}
}
