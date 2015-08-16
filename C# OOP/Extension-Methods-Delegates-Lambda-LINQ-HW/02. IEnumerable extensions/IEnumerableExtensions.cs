using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerable_extensions
{
    //Implement a set of extension methods for IEnumerable<T> that 
    //implement the following group functions: sum, product, min, max, average.
     public static class IEnumerableExtensions
    {
         public static T SumT<T>(this IEnumerable<T> collection)
             where T: IComparable, IConvertible
         {
             if (collection.Count() == 0)
             {
                 throw new ArgumentException("The collection is empty!");
             }

             dynamic result = collection.FirstOrDefault();
             foreach( T item in collection.Skip(1))
             {
                 result+= item;
             }

                return result;
         }
         public static T ProductT<T>(this IEnumerable<T> collection)
            where T : IComparable, IConvertible
         {
             if (collection.Count() == 0)
             {
                 throw new ArgumentException("The collection is empty!");
             }

             dynamic result = collection.FirstOrDefault();

             if (result is string)// opqm go da ba4ka sus stringove
             {
                 foreach (T item in collection.Skip(1))
                     result += item;
             }
             else
             {
                 foreach (T item in collection.Skip(1))
                 {

                     result *= (dynamic)item;

                 }
             }

             return result;
         }
         public static T MaxT<T> (this IEnumerable<T> collection)
            where T : IComparable, IConvertible
         {
             T max = collection.FirstOrDefault();

             if (max is string)
             {
                 foreach (T item in collection.Skip(1))
                 {
                     if (item.ToString().Length.CompareTo(max.ToString().Length) == 1)
                     {
                         max = item;
                     }
                 }

             }
             else
             {
                 foreach (T item in collection.Skip(1))
                 {
                     if (item.CompareTo(max) == 1)
                     {
                         max = item;
                     }
                 }
             }
             return max;
         }
         public static T MinT<T>(this IEnumerable<T> collection)
           where T : IComparable, IConvertible
         {
             T min = collection.FirstOrDefault();

             if (min is string)
             {
                 foreach (T item in collection.Skip(1))
                 {
                     if (item.ToString().Length.CompareTo(min.ToString().Length) == -1)
                     {
                         min = item;
                     }
                 }

             }
             else
             {
                 foreach (T item in collection.Skip(1))
                 {
                     if (item.CompareTo(min) == -1)
                     {
                         min = item;
                     }
                 }
             }
             return min;
         }
         public static double AverageT<T>(this IEnumerable<T> collection)
           where T : IComparable, IConvertible
         {
            
             T firstElement = collection.FirstOrDefault();
             double result = 0.00;
             double count = collection.Count();///!!!! zaduljitelno double ina4e zakruglq
             

             if (firstElement is string)
             {
                 Console.WriteLine("The avarage lenght of the string in the collections is:");
                 int totalNumberofChars = 0;
                  foreach (T item in collection)
                  {
                      totalNumberofChars += item.ToString().Length;
                  }

                  result +=  totalNumberofChars/count;
                  
             }
             else if (firstElement is int)
             {
                 result+= (dynamic)collection.SumT<T>()/count;
                 
             }
             return result;
             
         }
    }
}
