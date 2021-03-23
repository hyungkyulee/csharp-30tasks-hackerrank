using System;
using System.Linq;

namespace Day12.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split();
            var firstName = inputs[0];
            var lastName = inputs[1];
            var id = int.Parse(inputs[2]);
            var numScores = int.Parse(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            var scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = int.Parse(inputs[i]);
            }

            var student = new Student(firstName,
                lastName,
                id,
                scores);

            student.PrintPerson();
            Console.WriteLine("Grade: " + student.Calculate());
        }
        
    }

    public class Student : Person
    {
        private int[] Scores;
        public Student(string firstName, 
            string lastName,
            int id,
            int[] scores) : base(firstName, lastName, id)
        {
            Scores = scores;
        }
        
        public char? Calculate()
        {
            var total = 0;
            // 1)
            // foreach (var score in Scores)
            // {
            //     total += score;
            // }
            
            // 2)
            // Scores.Select(s => total += s);
            
            // 3)
            total += Scores.Sum();

            var average = total / Scores.Length;
            if ( 90 <= average && average <= 100 ) return 'O';
            if ( 80 <= average && average < 90 ) return 'E';
            if ( 70 <= average && average < 80 ) return 'A';
            if ( 55 <= average && average < 70 ) return 'P';
            if ( 40 <= average && average < 55 ) return 'D';
            if ( average < 40 ) return 'T';
            return null;
        }
    }

    public class Person
    {
        protected string FirstName;
        protected string LastName;
        protected int Id;
	
        public Person(){}
        public Person(string firstName, string lastName, int identification)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = identification;
        }
        public void PrintPerson()
        {
            Console.WriteLine("Name: " + LastName + ", " + FirstName + "\nID: " + Id); 
        }
    }
}