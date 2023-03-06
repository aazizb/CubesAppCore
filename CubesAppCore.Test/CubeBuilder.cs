namespace CubesAppCore.Test
{
    internal class CubeBuilder : ICubeBuilder
    {
        Point point;
        double length;
        public Cube Build()
        {
            return new Cube(point, length);
        }

        public ICubeBuilder WithCenter(Point point)
        {
            this.point = point;
            return this;
        }

        public ICubeBuilder WithLength(double length)
        {
            this.length = length;
            return this;
        }
    }
}