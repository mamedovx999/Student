using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student : IComparable<Student>
    {
        static int _id;
        public int Id { get; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public double Point { get; set; }

        public static bool operator >(Student student1, Student student2)
        {
            return student1.Point > student2.Point;
        }

        public static bool operator <(Student student1, Student student2)
        {
            return student1.Point < student2.Point;
        }

        public void  ShowInfo()
        {
              Console.WriteLine($"Id: {Id}, Name: {Name}, Surname: {Surname}, Age: {Age}, Point: {Point}");
            
        }
        public Student(string name, string surname ,int age ,double point)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
        }
        public override string ToString() => $"{Id} Student : {Name} {Surname} // Point: {Point}";

        public int CompareTo(Student? other)
        {
            return Point.CompareTo(other.Point);
        }
    }
}
