using System.Drawing;

namespace CubesAppCore.Test
{
    public class CubesCollideCheckTest
    {
        [Fact]
        public void Cubes_do_not_collide()
        {
            //Arrange
            Cube cubeA = new CubeBuilder()
                            .WithCenter(new Point(2.0, 2.0, 2.0))
                            .WithLength(1.0)
                            .Build();
            Cube cubeB = new CubeBuilder()
                            .WithCenter(new Point(4.0, 4.0, 4.0))
                            .WithLength(1.0)
                            .Build();
            //Act
            bool collide = cubeA.CollidesWith(cubeB);
            //Assert
            Assert.False(collide);
        }
    }
}