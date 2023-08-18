using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesBC
{
    internal class Student
    {
        public static int NextId { get; set; } = 10001;
        public int Code = 0123; // field
        public int Id { get; set; }
        public string Name { get; set; } //properies
        public string State { get; set; }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
        public void ChangeName(string newName = "New Student")
        {
            Name = newName;
        }
        public void ChangeState(string newState ="Ohio")
        {
            State = newState;
        }
        public void ChnageName(string firstName,  string lastName)
        {
            Name = $"{firstName} {lastName}";
        }
        public Student(string Name = "New Student", string State ="OH")
        {
            this.Id = NextId++;
            this.Name = Name;
            this.State = State;
        }
        public Student()
        {

        }
        public Student(string Name) : this(Name, "OH")
        {

        }
    }
}
