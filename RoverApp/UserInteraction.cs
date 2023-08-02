using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp
{
    class UserInteraction
    {
        private CoordinateSystem coordinateSystem;

        public UserInteraction(CoordinateSystem coordinateSystem)
        {
            this.coordinateSystem = coordinateSystem;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Yön belirlemek için bir tuşa basınız...");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                char direction = char.ToUpper(keyInfo.KeyChar);

                int newX = coordinateSystem.CurrentX;
                int newY = coordinateSystem.CurrentY;

                switch (direction)
                {
                    case 'N':
                        if (newY > 0)
                            newY--;
                        break;
                    case 'S':
                        if (newY < coordinateSystem.Height - 1)
                            newY++;
                        break;
                    case 'E':
                        if (newX < coordinateSystem.Width - 1)
                            newX++;
                        break;
                    case 'W':
                        if (newX > 0)
                            newX--;
                        break;
                    default:
                        Console.WriteLine("Geçersiz yön tuşu!");
                        break;
                }

                coordinateSystem.UpdatePosition(newX, newY);
                coordinateSystem.Draw();
            }
        }
    }
}
