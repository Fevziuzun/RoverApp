using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            int height = 0;


            while (true)
            {
                try
                {
                    Console.Write("Enter width: ");
                    width = int.Parse(Console.ReadLine());

                    Console.Write("Enter height: ");
                    height = int.Parse(Console.ReadLine());


                    if (width < 1 || height < 1)
                    {
                        throw new Exception("Width and height cannot be 0.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer value.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }



            CoordinateSystem coordinateSystem = new CoordinateSystem(width, height);
            UserInteraction userInteraction = new UserInteraction(coordinateSystem);


            Console.WriteLine("Choose\n1:Move Rover\n2:Create Rover\n3:Exit");
            int secim = Int32.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    userInteraction.Run();
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Goodbye");
                    break;

            }
        }
    }
}
