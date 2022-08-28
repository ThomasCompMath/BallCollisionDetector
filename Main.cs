// Practice making object oriented projects
// Imagine this existing on a 1D space. Anything more should require a vector, instead of a number to represet the position and velocity
// This chunk of code just allows you to create a ball and move it in one-dimension

using System;

namespace ObjectOriented
{
	public class Ball
	{
		public double Position { get; set; }
		public string Color { get; private set; }
		public double Radius { get; private set; }
		public double Velocity { get; set; }
		
		public Ball(string color, double radius)
		{
			Color = color;
			Radius = radius;
			Position = 0;
		}
		
		public void Move(double velocity, double time)						// Receives a positive or negative number, since we are dealing with 1D space
		{
			for ( int i = 0; i < time; i++)
			{
				this.Position += velocity;
			}
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			var greenBall = new Ball("green", 4);
			Console.WriteLine("The current position of the ball is: " + greenBall.Position);
			greenBall.Move(2, 4);
			Console.WriteLine("The current position of the ball is: " + greenBall.Position);
			
			Console.WriteLine("What velocity would you like the ball to go now?");
			double velocity = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("For how long would you like the ball to go this velocity?");
			double time = Convert.ToDouble(Console.ReadLine());
			greenBall.Move(velocity, time);
			Console.WriteLine("The new position of the ball is: " + greenBall.Position);
		}
	}
}































