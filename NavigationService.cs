using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverChallangePlat45
{
    public class NavigationService
    {
        public Rover Navigate(Rover rover)
        {
            var commands = rover.Commands.ToCharArray();
            //Rover roverNewPosition = null;

            foreach (var item in commands)
            {
                if (item == 'L')
                {
                    rover.Direction = TurnLeft(rover.Direction);
                }
                else if (item == 'R')
                {
                    rover.Direction = TurnRight(rover.Direction);
                }
                else if (item == 'M')
                {
                    rover = Move(rover);
                }
                else
                {
                    continue;
                }
            }

            return rover;
        }
        public char TurnLeft(char direction)
        {
            if (direction == 'N')
                return 'W';
            else if (direction == 'E')
                return 'N';
            else if (direction == 'S')
                return 'E';
            else
                return 'S';
        }

        public char TurnRight(char direction)
        {
            if (direction == 'N')
                return 'E';
            else if (direction == 'E')
                return 'S';
            else if (direction == 'S')
                return 'W';
            else
                return 'N';
        }

        public Rover Move(Rover rover)
        {
            if (rover.Direction == 'N')
                rover.Y = rover.Y + 1;

            else if (rover.Direction == 'E')
                rover.X = rover.X + 1;

            else if (rover.Direction == 'S')
                rover.Y = rover.Y - 1;

            else
                rover.X = rover.X - 1;

            return rover;
        }
    }
}
