using CubesAppCore.Test;

namespace CubesAppCore
{
    public class CubesCommonVolumeTest
    {
        [Fact]
        public void Cubes_do_not_collide()
        {
            //Arrange
            Cube cubeA = new CubeBuilder()
                            .WithCenter(new Point(2, 2, 2))
                            .WithLength(1)
                            .Build();
            Cube cubeB = new CubeBuilder()
                            .WithCenter(new Point(4, 4, 4))
                            .WithLength(1)
                            .Build();
            //Act
            double volume = cubeA.CommonVolumeWith(cubeB);
            //Assert
            Assert.Equal(0, volume);
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
                            .WithCenter(new Point(2, 2, 2))
                            .WithLength(3)
                            .Build();
            //Act
            double volume = cubeA.CommonVolumeWith(cubeB);
            //Assert
            Assert.Equal(8, volume);
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
            double volume = cubeA.CommonVolumeWith(cubeB);
            //Assert
            Assert.Equal(0, volume);
        }
        [Fact]
        public void Cubes_overlapped()
        {
            //Arrange
            Cube cubeA = new CubeBuilder()
                            .WithCenter(new Point(3, 3, 3))
                            .WithLength(2)
                            .Build();
            Cube cubeB = new CubeBuilder()
                            .WithCenter(new Point(3, 3, 3))
                            .WithLength(2)
                            .Build();
            //Act
            double volume = cubeA.CommonVolumeWith(cubeB);
            //Assert
            Assert.Equal(8, volume);
        }
        [Fact]
        public void Cubes_one_contains_the_other()
        {
            //Arrange
            Cube cubeA = new CubeBuilder()
                            .WithCenter(new Point(3, 3, 3))
                            .WithLength(3)
                            .Build();
            Cube cubeB = new CubeBuilder()
                            .WithCenter(new Point(3, 3, 3))
                            .WithLength(2)
                            .Build();
            //Act
            double volume = cubeA.CommonVolumeWith(cubeB);
            //Assert
            Assert.Equal(8, volume);
        }
        [Fact]
        public void cubes_with_same_height_and_depth()
        {
            //Arrange
            Cube cubeA = new CubeBuilder()
                            .WithCenter(new Point(2, 2, 2))
                            .WithLength(2)
                            .Build();
            Cube cubeB = new CubeBuilder()
                            .WithCenter(new Point(3, 2, 2))
                            .WithLength(2)
                            .Build();
            //Act
            double volume = cubeA.CommonVolumeWith(cubeB);
            //Assert
            Assert.Equal(4, volume);
        }
        [Fact]
        public void cubes_with_same_height_and_width()
        {
            //Arrange
            Cube cubeA = new CubeBuilder()
                            .WithCenter(new Point(2, 2, 2))
                            .WithLength(2)
                            .Build();
            Cube cubeB = new CubeBuilder()
                            .WithCenter(new Point(2, 2, 3))
                            .WithLength(2)
                            .Build();
            //Act
            double volume = cubeA.CommonVolumeWith(cubeB);
            //Assert
            Assert.Equal(4, volume);
        }
        [Fact]
        public void cubes_with_same_depth_width()
        {
            //Arrange
            Cube cubeA = new CubeBuilder()
                            .WithCenter(new Point(2, 2, 2))
                            .WithLength(2)
                            .Build();
            Cube cubeB = new CubeBuilder()
                            .WithCenter(new Point(2, 3, 2))
                            .WithLength(2)
                            .Build();
            //Act
            double volume = cubeA.CommonVolumeWith(cubeB);
            //Assert
            Assert.Equal(4, volume);
        }

    }
}
