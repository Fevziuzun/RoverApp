using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp
{
    class CoordinateSystem
    {
        public int width;
        public int height;
        public char[,] coordinateSystem;
        public int currentX;
        public int currentY;

        public CoordinateSystem(int width, int height)
        {
            this.width = width;
            this.height = height;
            coordinateSystem = new char[height, width];
            Initialize();
        }

        public void Initialize()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    coordinateSystem[y, x] = '.';
                }
            }

            currentX = 0;
            currentY = 0;
            coordinateSystem[currentY, currentX] = 'X';
        }

        public void UpdatePosition(int x, int y)
        {
            coordinateSystem[currentY, currentX] = '.';
            currentX = x;
            currentY = y;
            coordinateSystem[currentY, currentX] = 'X';
        }

        public void Draw()
        {
            if (height < 100 || width < 100)
            {
                Console.WriteLine("\nGüncel Konum: X({0}, {1})", currentX, currentY);
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Console.Write(coordinateSystem[y, x]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\nGüncel Konum: X({0}, {1})", currentX, currentY);
            }


        }
        public int CurrentX
        {
            get { return currentX; }
        }

        public int CurrentY
        {
            get { return currentY; }
        }

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }
    }
}
