using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public static class Mover
    {
        public static Position Move(Position currentPosition, Direction currentDirection)
        {
            switch (currentDirection)
            {
                    case Direction.N:
                    currentPosition.positionY++;
                    break;
                    case Direction.E:
                    currentPosition.positionX++;
                    break;
                    case Direction.S:
                    currentPosition.positionY--;
                    break;
                    case Direction.W:
                    currentPosition.positionX--;
                    break;
            }
            return currentPosition; 
        }
    }
}
