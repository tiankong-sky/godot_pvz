using Godot;
using System;

public partial class Pea : Area2D
{
	// Called when the node enters the scene tree for the first time.
	private double _speed = 100;
	private Vector2 dir = Vector2.Right;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position += (float)(_speed * delta) * dir;
	}

}
