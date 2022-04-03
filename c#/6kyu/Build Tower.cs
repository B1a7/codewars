// Build Tower
// Build a pyramid-shaped tower given a positive integer number of floors. A tower block is represented with "*" character.

// For example, a tower with 3 floors looks like this:

// [
//   "  *  ",
//   " *** ", 
//   "*****"
// ]
// And a tower with 6 floors looks like this:

// [
//   "     *     ", 
//   "    ***    ", 
//   "   *****   ", 
//   "  *******  ", 
//   " ********* ", 
//   "***********"
// ]


using System.Linq;
using System.Collections.Generic;
using System;
public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
            return Enumerable.Range(0, nFloors)
                .Select(x => new string('*', x * 2 + 1).PadLeft(nFloors + x).PadRight(nFloors * 2 - 1)).ToArray();
  }
}