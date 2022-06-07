using System;

namespace MarsRoverChallangePlat45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No. of Rovers For Squad(e.g, 2): ");
            var roversSquad = Convert.ToInt32(Console.ReadLine());

            // Enter values of co-ordinates with 1 space.
            Console.WriteLine("Enter Top Right Cordinates(e.g, 5 5): ");
            var sizeOfplateau = Console.ReadLine().Split(" ");

            for (int i = 1; i <= roversSquad; i++)
            {
                // Enter values of initial position with 1 space b/w characters.
                Console.WriteLine("Enter Rover " + i + "'s initial Position(e.g, 1 2 N): ");
                var roverPosition = Console.ReadLine().Split(" ");

                if (Convert.ToInt32(roverPosition[0]) < Convert.ToInt32(sizeOfplateau[0]) && Convert.ToInt32(roverPosition[1]) < Convert.ToInt32(sizeOfplateau[1]))
                {
                    // Enter values of commands with no space b/w characters.
                    Console.WriteLine("Enter Rover Commands(e.g, LMLMLMLMM): ");
                    var roverCommands = Console.ReadLine();

                    var rover = new Rover
                    {
                        X = Convert.ToInt32(roverPosition[0]),
                        Y = Convert.ToInt32(roverPosition[1]),
                        Direction = Convert.ToChar(roverPosition[2]),
                        Commands = roverCommands
                    };

                    NavigationService navService = new NavigationService();

                    rover = navService.Navigate(rover);
                    Console.WriteLine(rover.X + " " + rover.Y + " " + rover.Direction);
                }
                else
                {
                    Console.WriteLine("Rover has Fallen off the Plateau during deployment.");
                }
            }
            
        }
    }
}
