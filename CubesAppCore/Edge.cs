namespace CubesAppCore
{
    public class Edge
    {
        private double Start { get; }
        private double End { get; }
        public Edge(double center, double length)
        {
            Start = center - length / 2.0;
            End = center + length / 2.0;

        }
        public bool Collides(Edge edge)
        {
            return SignedDistance(edge) >= 0;
        }

        public double Overlap(Edge edge)
        {
            return Math.Max(0, SignedDistance(edge));
        }
        private double SignedDistance(Edge edge)
        {
            return Math.Min(End, edge.End) - Math.Max(Start, edge.Start);
        }
    }
}
