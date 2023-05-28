using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDiary
{

    public class Student
    {
       

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comments { get; set; }
        public string Math { get; set; }
        public string Technology { get; set; }
        public string Physcics { get; set; }
        public string PolishLang { get; set; }
        public string ForeignLang { get; set; }
        public bool AdditionalLesson { get; set; }
        public string IdGroup { get; set; }

    }

        
    /*
    public class Teacher : Person
    {
        public string Position { get; set; }

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} = nauczyciel";
        }
    }
     
    public abstract class Person
    {
        protected string ProtectedField;
        

        public abstract string GetInfo();
        
    } */
}
