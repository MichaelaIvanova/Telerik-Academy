using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_classes___part_2___HW
{
    //Task 4: Create a class Path to hold a sequence of points in the 3D space. 
     public  class Path
    {
        private List<Point> pointList;

         public Path()// prazen konstructor, default, suzdavame nov Path
        {
           this.pointList = new List<Point>();
        }

         public List<Point> PointList// taka my davame vsi4ki opcii, koito  ima lista bez da gi zadavame nie ru4no tuk
         {
             get  { return pointList;}
         }

         public int Count
         {
             get { return pointList.Count; }
             private set { ;}
         }

         public void Add(Point point)
         {
             pointList.Add(point);
         }

         
    }
}
