using Godot;
using System;

public partial class pea : Area2D
{
	// Called when the node enters the scene tree for the first time.
	private double speed = 100;
	private Vector2 dir = Vector2.Left;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
