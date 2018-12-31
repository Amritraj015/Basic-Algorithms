using System;
using System.IO;

namespace Maze_Solver
{
    internal class FileReader
    {
        public int[,] Map { get; set; }
        public string FileName { get; set; }
        public int NumRows { get; set; }
        public int NumColumns { get; set; }
        public int StartRowIndex { get; set; }
        public int StartColumnIndex { get; set; }

        public FileReader(string fileName, int nunRows, int numColumns)
        {
            FileName = fileName;
            NumRows = nunRows;
            NumColumns = numColumns;
            Map = new int[NumRows,NumColumns];
        }

        public void ParseFile()
        {
            try
            {
                var readStream = File.ReadAllLines(FileName);
                var k = 0;

                while (k < 5)
                {
                    var str = readStream[k].Split(' ');
                    for (var i = 0; i < 5; i++)
                    {
                        Map[k, i] = int.Parse(str[i]);
                        if (Map[k, i] == 2)
                        {
                            StartRowIndex = k;
                            StartColumnIndex = i;
                        }
                    }
                    k++;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
