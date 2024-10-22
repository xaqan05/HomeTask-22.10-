using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student
    {
        private static int _idCounter = 0;
        public int Id { get; }

        public string FullName { get; set; }

        public int Point {  get; set; }

        public Student(string fullName,int point)
        {
            Id = ++_idCounter;
            FullName = fullName;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}, Full Name: {FullName}, Point: {Point}");
        }
    }
}
