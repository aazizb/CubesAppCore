
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
        [Fact]
        public void Cubes_do_collide()
        {
            //Arrange
            Cube cubeA = new CubeBuilder()
                            .WithCenter(new Point(2, 2, 2))
                            .WithLength(2)
                            .Build();
            Cube cubeB = new CubeBuilder()
                            .WithCenter(new Point(4, 4, 4))
                            .WithLength(2)
                            .Build();
            //Act
            bool collide = cubeA.CollidesWith(cubeB);
            //Assert
            Assert.True(collide);
        }
        [Fact]
        public void Cubes_do_touch()
        {
            //Arrange
            Cube cubeA = new CubeBuilder()
                            .WithCenter(new Point(2, 2, 2))
                            .WithLength(2)
                            .Build();
            Cube cubeB = new CubeBuilder()
                            .WithCenter(new Point(4, 2, 2))
                            .WithLength(2)
                            .Build();
            //Act
            bool collide = cubeA.CollidesWith(cubeB);
            //Assert
            Assert.True(collide);
        }
        [Fact]
        public void Cubes_One_Inside_the_Other()
        {
            //Arrange
            Cube cubeA = new CubeBuilder()
                            .WithCenter(new Point(2, 2, 2))
                            .WithLength(2)
                            .Build();
            Cube cubeB = new CubeBuilder()
                            .WithCenter(new Point(2, 2, 2))
                            .WithLength(4)
                            .Build();
            //Act
            bool collide = cubeA.CollidesWith(cubeB);
            //Assert
            Assert.True(collide);
        }
    }
}