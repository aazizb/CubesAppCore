﻿namespace CubesAppCore.Test
{
    public class Cube
    {
        private Edge Width { get; }
        private Edge Height { get; }
        private Edge Depth { get; }

        public Cube(Point center, double length)
        {
            Width = new Edge(center.X, length);
            Height = new Edge(center.Y, length);
            Depth = new Edge(center.Z, length);
        }
        public bool CollidesWith(Cube cube)
        {
            return Width.Collides(cube.Width)
                || Height.Collides(cube.Height)
                || Depth.Collides(cube.Depth);
        }
    }
}