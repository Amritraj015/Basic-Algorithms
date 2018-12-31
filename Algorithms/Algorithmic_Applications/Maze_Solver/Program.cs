using System;

namespace Maze_Solver
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //  input.txt contains the Maze-Map
            //  1 - represents a Wall
            //  2 - represents the starting point
            //  3 - represents the way out
            //  There can be no other values in the Maze-Map

            var fileReader = new FileReader(@"./input.txt", 5, 5);
            fileReader.ParseFile();
            var mazeSolver = new MazeSolver(fileReader.Map, fileReader.StartRowIndex,fileReader.StartColumnIndex);
            mazeSolver.FindWayOut();

            Console.Read();
        }
    }
}
