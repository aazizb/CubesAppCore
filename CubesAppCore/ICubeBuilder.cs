using CubesAppCore.Test;

namespace CubesAppCore
{
    public interface ICubeBuilder
    {
        ICubeBuilder WithCenter(Point point);
        ICubeBuilder WithLength(double length);
        Cube Build();
    }
}
