namespace CubesAppCore.Test
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

        public double CommonVolumeWith(Cube cube)
        {
            return Width.Overlap(cube.Width)
                 * Height.Overlap(cube.Height)
                 * Depth.Overlap(cube.Depth);
        }
    }
}