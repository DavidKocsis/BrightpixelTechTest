using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public static class Turner
    {
      
        public static Direction TurnLeft(Direction currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.N:
                    return Direction.W;
                case Direction.W:
                    return Direction.S;
                case Direction.S:
                    return Direction.E;
                case Direction.E:
                    return Direction.N;
            }
            return Direction.N;
        }

        public static Direction TurnRight(Direction currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.N:
                    return Direction.E;
                case Direction.E:
                    return Direction.S;
                case Direction.S:
                    return Direction.W;
                case Direction.W:
                    return Direction.N;
            }
            return Direction.N;
        }


    }
}
