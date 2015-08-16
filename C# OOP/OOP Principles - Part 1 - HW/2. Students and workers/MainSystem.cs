using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Students_and_workers
{
    class MainSystem
    {
        static void Main(string[] args)
        {
           // Initialize a list of 10 students and sort them by grade in
            //ascending order (use LINQ or OrderBy() extension method).

            var students = new List<Student>()
            {
                new Student("Miro", "Penev", 11),
                new Student("Giro", "Velev", 2),
                new Student("Dimo", "Dimov", 12),
                new Student("Misho", "Peshev", 10),
                new Student("Tisho", "Tihov", 2),
                new Student("Grisho", "Dimitrov", 7),
                new Student("Dwayne", "Atanasov", 4),
                new Student("Dwight", "Wight", 5),
                new Student("Klechko", "Klechkov", 9),
                new Student("Kubrat", "Pulev", 6)
            };

            var sortedByGrate = students.OrderBy(x => x.Grade).ToList();
            foreach (Student st in sortedByGrate)
                Console.WriteLine("{0} ->grade; {1} -> fist name", st.Grade, st.FirstName);



            var workers = new List<Worker>()
            {
                new Worker("Dimitar", "Berbatov", 40.1, 8),
                new Worker("Dimitar", "Barbukov", 150, 4),
                new Worker("Jeremy", "Clarcksen", 100, 2),
                new Worker("James", "May", 30, 4),
                new Worker("Cristiano", "Ronaldo", 300, 10),
                new Worker("Hasan", "Azis", 80, 3),
                new Worker("Gosho", "Peshov", 50, 9),
                new Worker("Pesho", "Goshov", 60, 5),
                new Worker("Gero", "Gerov", 20, 2),
                new Worker("Yasen", "Neqsnikov", 40, 4)
            };
            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            var sortedByMoneyPerHour = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();
            foreach (Worker w in sortedByMoneyPerHour)
                Console.WriteLine("{0} ->money; {1} -> fist name", w.MoneyPerHour(), w.FirstName);

            //Merge the lists and sort them by first name and last name.

            var all = students.Concat<Human>(workers).ToList().OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (Human h in all)
                Console.WriteLine("{0} {1}", h.FirstName, h.LastName);
                                    

        }
    }
}
