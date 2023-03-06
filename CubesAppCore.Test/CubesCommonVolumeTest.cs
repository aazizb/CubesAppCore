﻿using CubesAppCore.Test;

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
    }
}