using System;

namespace Maze_Solver
{
    internal class MazeSolver
    {
        public int[,] MazeMap { get; set; }
        public bool[,] Visited { get; set; }
        public int StartPosRow { get; set; }
        public int StartPosColumn { get; set; }

        public MazeSolver(int[,] map, int startRowIndex, int startColumnIndex)
        {
            MazeMap = map;
            StartPosRow = startRowIndex;
            StartPosColumn = startColumnIndex;
            Visited = new bool[MazeMap.Length, MazeMap.Length];
        }

        public void FindWayOut()
        {
            try
            {
                DepthFirstSearch(StartPosRow,StartPosColumn );
                Console.WriteLine("No Way Out!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void DepthFirstSearch(int i, int j)
        {
            Console.WriteLine("Visiting i = " + i + " and j = " + j);

            if(MazeMap[i,j] == 3)
                throw new Exception("Found a way out");

            var endOfMap = MazeMap.Length - 1;

            if (Visited[i, j])
                return;
            if (i < 0 || i >= endOfMap)
                return;
            if (j < 0 || j >= endOfMap)
                return;
            if (MazeMap[i, j] == 1)
                return;
            Visited[i, j] = true;
            DepthFirstSearch(i + 1, j);
            DepthFirstSearch(i, j + 1);
            DepthFirstSearch(i, j - 1);
            DepthFirstSearch(i - 1, j);
        }
    }
}
