using IMCSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCSLibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ps = new Person();
            ps.addPerson(1, "sid", "male", "12345", "houston", "abc@gmail.com", 6789, DateTime.Now, "man");
            Console.ReadKey();

            Student ss = new Student();
            ss.addStudent(1, 1, "sid", "male", "123456", "Dallas", "abc@gmail.com", 12345, DateTime.Now, "someone", "UHCL", 55);
            Console.ReadKey();

            Employee ee = new Employee();
            ee.addEmployee(1, 1, "ani", "male", "7114567", "California", "123@mail.com", 8876, DateTime.Now, "no-one", "Manager", 90);
            Console.ReadKey();
        }
    }
}
