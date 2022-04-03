/*
Story
POTUS thinks he is all alone in the White House on Christmas Eve.

But is he?

The White House has a wall-penetrating radar security system that sees everything.

Kata Task
Process the radar image.

Return true if POTUS really is home alone.

Legend
# walls
X POTUS
o elves
Notes
The house corners are square only
The radar can also see into nearby buildings
Examples
ex1
   o                o        #######
 ###############             #     #
 #             #        o    #     #
 #  X          ###############     #
 #                                 #
 ###################################
All alone --> true

ex2
#################
#     o         #   o
#          ######        o
####       #                
   #       ###################
   #                         #
   #                  X      #
   ###########################
All alone --> false
*/


using System;
using System.Collections.Generic;

    public struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

    }
public class Dinglemouse
{
  public static bool AllAlone(char[][] house)
        {
            Point potus = default;
            for (int i = 0; i < house.GetLength(0); i++)
            {
                for (int j = 0; j < house[i].Length; j++)
                {
                    if (house[i][j] == 'X')
                        potus = new Point(i, j);
                }
            }

            List<Point> scannedPoints = new List<Point>();
            var isNotAlone = Scan(potus, house, scannedPoints);
          
            return !isNotAlone;
        }


        public static bool Scan(Point point, char[][] house, List<Point> scanedPoints)
        {
            if (scanedPoints.Contains(point))
                return false;

            scanedPoints.Add(point);

            if (house[point.X][point.Y] == 'o')
            {
                return true;
            }
            if (house[point.X][point.Y] == '#')
            {
                return false;
            }

            var pointUp = new Point(point.X, point.Y - 1);
            var pointDown = new Point(point.X, point.Y + 1);
            var pointLeft = new Point(point.X - 1, point.Y);
            var pointRight = new Point(point.X + 1, point.Y);


            //if (Scan(pointUp, house, scanedPoints))
            //{
            //    return true;
            //}
            //if (Scan(pointDown, house, scanedPoints))
            //{
            //    return true;
            //}
            //if (Scan(pointLeft, house, scanedPoints))
            //{
            //    return true;
            //}
            //if (Scan(pointRight, house, scanedPoints))
            //{
            //    return true;
            //}
            //return false;

            return Scan(pointUp, house, scanedPoints) || 
                   Scan(pointDown, house, scanedPoints) || 
                   Scan(pointLeft, house, scanedPoints) ||
                   Scan(pointRight, house, scanedPoints);
        }
}