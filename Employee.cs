using System;
using System.Collections.Generic;
using System.Text;

namespace Olio_ohjelmointi
{
    class Employee
    {
        public string name;
        public double salary;
        public string id;
        public string position;

        public Employee()
        {
            this.name = "";
            this.salary = 0;
            this.id = "";
            this.position = "";


        }

        public Employee(string name, string id, string position, double salary)
        {
            this.name = name;
            this.salary = salary;
            this.salary = salary;
            this.id = id;
        }

        public void CompareValues(Employee employee)
        {
            Console.WriteLine("Ensimmäinen työnkijän palkka on:" + this.salary + ", toisen palkka on:" + employee.salary);

            if (this.salary > employee.salary)
            {
                Console.WriteLine(this.salary + "on suurempi kuin" + employee.salary);

            }
            else if (this.salary < employee.salary)
            {
                Console.WriteLine(employee.salary + " on suurempi kuin" + this.salary);
            }
            else
            {
                Console.WriteLine("Palkat ovat yhtä suuret");
            }


        }
        public void PrintEmployeeInfo()
        {
            Console.WriteLine("Työntekijän nimi: " + this.name + ", id: " + this.id + "position " + this.position + "salary " + this.salary);
        }

        public override string ToString()
        {
            return "Työntekijän nimi " + this.name + ", id: " + this.id + "position: " + this.position + " salary: " + this.salary;
        }







    }   }