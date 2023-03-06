using CubesAppCore.Test;

namespace CubesAppCore
{
    internal interface ICubeBuilder
    {
        ICubeBuilder WithCenter(Point point);
        ICubeBuilder WithLength(double length);
        Cube Build();
    }
}
