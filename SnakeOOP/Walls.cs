using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            Horizontal top = new Horizontal(0, 80, 0, '#');
            VerticalLine left = new VerticalLine(0, 25, 0, '#');
            Horizontal bottom = new Horizontal(0, 80, 25, '$');
            VerticalLine right = new VerticalLine(0, 25, 80, '$');

            VerticalLine obstacle = new VerticalLine(10, 20, 50, '|');
            VerticalLine obstacle2 = new VerticalLine(15, 20, 25, '|');
            VerticalLine obstacle3 = new VerticalLine(20, 24, 35, '|');


            Console.ForegroundColor = ConsoleColor.Blue;
            wallList.Add(top);
            wallList.Add(left);
            wallList.Add(bottom);
            wallList.Add(right);
            wallList.Add(obstacle);
            wallList.Add(obstacle2);
            wallList.Add(obstacle3);
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
