using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MarsRover
{
    public class Rover
    {
        public Rover(int _positionX, int _positionY, Direction _direction)
        {
            Position = new Position(_positionY, _positionX);
            Direction = _direction;
        }

        public Position Position { get; set; }
        public Direction Direction { get; set; }


        public void Turn(string turnDirection)
        {
            switch (turnDirection)
            {
                case "L":
                    Direction = Turner.TurnLeft(Direction);
                    break;
                case "R":
                    Direction = Turner.TurnRight(Direction);
                    break;
            }
        }

        public void Move()
        {
            Position = Mover.Move(Position, Direction);
        }

        public void ProcessOrders(string orders)
        {
            foreach (char order in orders)
            {
                switch (order)
                {
                    case 'L':
                        Turn("L");
                        break;
                    case 'R':
                        Turn("R");
                        break;
                    case 'M':
                        Move();
                        break;
                }
            }
        }
    }

    public class Position
    {
        public Position(int _positionY, int _positionX)
        {
            positionX = _positionX;
            positionY = _positionY;
        }

    public int positionX { get; set; }
    public int positionY { get; set; }
    }
    
}
