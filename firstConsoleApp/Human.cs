using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp
{
    public class Human
    {
        public string _Surname { get; set; }
        public string _Adress { get; set; }
        public string _Birth { get; set; }
        public Human(string Surname, string Adress, string Birth) 
        {
            _Surname = Surname;
            _Adress = Adress;   
            _Birth = Birth;
        }
        public void Print() 
        {
            Console.WriteLine($"Фамилия: {_Surname}");
            Console.WriteLine($"Адрес: {_Adress}");
            Console.WriteLine($"Дата рождения: {_Birth}");
        }
    }
    public class Student : Human
    {
        public int _ID { get; set; }
        public string _Group { get; set; }
        public int _Course { get; set; }
        public Student(string Surname, string Adress, string Brith, string Group, int Course, int ID) : base(Surname, Adress, Brith)
        {
            _ID = ID;
            _Group = Group;
            _Course = Course;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Группа: {_Group}");
            Console.WriteLine($"Курс: {_Course}");
            Console.WriteLine($"Номер зачётной книги: {_ID}");
        }
    }
}
