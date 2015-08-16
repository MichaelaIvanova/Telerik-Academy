using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Defining_classes___part_2___HW
{
    public static class PathStorage
    {
        //eate a static class PathStorage with static methods to save and load paths from a text file.
        public static void Save(Path input, string filePath)//
        {
            StreamWriter writer = new StreamWriter(filePath);// @"text.txt"
            using (writer)
            {
                foreach (Point point in input.PointList)// za da m dadem svojstva na list.PonitList
                {
                    string line = string.Format("{0},{1},{2},", point.X, point.Y, point.Z);
                    writer.WriteLine(line);
                }

            }

        }
        public static void Load(string filePath, Path output)
        {
            StreamReader reader = new StreamReader(filePath);
            try
            {


                using (reader)
                {

                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] readPoints = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        decimal x = decimal.Parse(readPoints[0]);
                        decimal y = decimal.Parse(readPoints[1]);
                        decimal z = decimal.Parse(readPoints[2]);

                        Point currpoint = new Point(x, y, z);
                        output.Add(currpoint);

                        line = reader.ReadLine();
                    }

                }
            }
            catch (Exception)
            {
                throw new Exception("Problem with the file, look it again:)");
            }

        }

    }
}
