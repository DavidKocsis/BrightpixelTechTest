using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover;
using NUnit;
using NUnit.Framework;

namespace MarsRoverTests
{
    public class Tests
    {
        [Test]
        public void RoverCanTurnLeft()
        {
            var Rover = new Rover(3,3,Direction.N);
            Rover.Turn("L");
            Assert.AreEqual(Rover.Direction,Direction.W);
            Rover.Turn("L");
            Assert.AreEqual(Rover.Direction, Direction.S);
            Rover.Turn("L");
            Assert.AreEqual(Rover.Direction, Direction.E);
            Rover.Turn("L");
            Assert.AreEqual(Rover.Direction, Direction.N);
        }

        [Test]
        public void RoverCanTurnRight()
        {
            var Rover = new Rover(3, 3, Direction.N);
            Rover.Turn("R");
            Assert.AreEqual(Rover.Direction, Direction.E);
            Rover.Turn("R");
            Assert.AreEqual(Rover.Direction, Direction.S);
            Rover.Turn("R");
            Assert.AreEqual(Rover.Direction, Direction.W);
            Rover.Turn("R");
            Assert.AreEqual(Rover.Direction, Direction.N);
        }

        [Test]
        public void RoverMovesToCorrectPosition()
        {
            var Rover = new Rover(3, 3, Direction.N);
            Rover.Move();
            Assert.AreEqual(4,Rover.Position.positionY);
            Assert.AreEqual(3, Rover.Position.positionX);

        }

        [Test]
        public void RoverProcessesOrdersCorrectly()
        {
            var Rover = new Rover(1, 2, Direction.N);
            Rover.ProcessOrders("LMLMLMLMM");
            Assert.AreEqual(1, Rover.Position.positionX);
            Assert.AreEqual(3, Rover.Position.positionY);
            Assert.AreEqual(Direction.N,Rover.Direction);
        }

        [Test]
        public void MultipleRoversMoveCorrectly()
        {
            var roverOne = new Rover(1, 2, Direction.N);
            roverOne.ProcessOrders("LMLMLMLMM");
            Assert.AreEqual(1, roverOne.Position.positionX);
            Assert.AreEqual(3, roverOne.Position.positionY);
            Assert.AreEqual(Direction.N, roverOne.Direction);
            var roverTwo = new Rover(3, 3, Direction.E);
            roverTwo.ProcessOrders("MMRMMRMRRM");
            Assert.AreEqual(5, roverTwo.Position.positionX);
            Assert.AreEqual(1, roverTwo.Position.positionY);
            Assert.AreEqual(Direction.E, roverTwo.Direction);
        }

    }
}
