using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        // interface new'lenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
        

            //IPersonManager employeeManager = new EmployeeManager(); 
            

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

            Console.ReadLine();
        }
    }

    interface IPersonManager
    {
        // unimplemented operation
         void Add();
         void Update();


    }

    // inherits -> class
    // implements -> interface
    class CustomerManager : IPersonManager
    {
        // müşteri ekleme kodları
        public void Add()
        {

            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        // personel ekleme kodları
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }

    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
