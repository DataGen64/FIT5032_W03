using System.Collections.Generic;

namespace FIT5032_Week03.Excersice
{


    public class Student
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Student(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

    }

    public class ExampleDictionary
    {
        public void ExampleDict()
        {
            Dictionary<int, Student> studentdictionary = new Dictionary<int, Student>();

            Student s1 = new Student("Bharath", "0401175105");
            Student s2 = new Student("Nirosha", "0445889226");

            studentdictionary.Add(1, s1);
            studentdictionary.Add(2, s2);

            Student result = new Student("", "");

            studentdictionary.TryGetValue(1, out result);

        }





    }
}