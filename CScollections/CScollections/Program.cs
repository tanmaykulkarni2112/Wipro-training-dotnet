using CScollections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CScollections
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }

        public int Salary { get; set; }
        public Employee(string Name, int Id, int salary)
        {
            EmployeeName = Name;
            EmployeeId = Id;
            Salary = salary;
        }
    }

    class EmployeeDAL
    {
        private ArrayList employeelist = new ArrayList();
        //public EmployeeDAL() { }
            
        //}
        public bool addEmployee(Employee e)
        {
            employeelist.Add(e);
            return true;
        }

        public bool deleteEmployee(int id) {
            foreach (Employee e in employeelist) {
                if (e.EmployeeId == id) { 
                    employeelist.Remove(e);
                    return true;
                }
            }
            return false;
        }

        public string SearchEmployee(int id)
        {
            foreach (Employee e in employeelist)
            {
                if (e.EmployeeId == id)
                {
                    return e.EmployeeName;
                }
            }
            return null;
        }

        public Employee[] GetAllEmployeesList()
        {
            Employee[] empArray = new Employee[employeelist.Count];
            employeelist.CopyTo(empArray);
            return empArray;
        }
    } 
}

    internal class Program
    {
        static void Main(string[] args)
        {
            // IMPLICIT and EXPLICIT data type conversions can occur when dealing with collections,
            // especially in non-generic collections where object types are used.

            // NON-GENERIC COLLECTIONS -> BOXING and UNBOXING occur frequently.
            // Found in: System.Collections namespace
            // Examples: ArrayList, SortedList, Hashtable, Stack, Queue
            // These store items as 'object', so value types are boxed and unboxed.

            // GENERIC COLLECTIONS -> TYPE-SAFE, no need for casting or boxing/unboxing.
            // Found in: System.Collections.Generic namespace
            // Examples: List<T>, Stack<T>, Queue<T>, Dictionary<TKey, TValue>, HashSet<T>

            ArrayList arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add("2");
            int[] nums = new int[4];
            nums[0] = 15;
            nums[1] = 153;
            nums[2] = 23;
            nums[3] = 123;
            arraylist.AddRange(nums);
            //for (int i = 0; i < arraylist.Count; i++)
            //{
            //    Console.WriteLine(arraylist[i]);
            //}

            foreach (object i in arraylist)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            SortedList sortedlist = new SortedList();
            sortedlist.Add(1, 12);
            sortedlist.Add(2, 20);
            sortedlist.Add(13, 2);
            sortedlist.Add(3, sortedlist.Count);

            foreach (DictionaryEntry entry in sortedlist)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
            Console.ReadLine();

            SortedList<string, string> sorted2 = new SortedList<string, string>()
            {
                { "A", "abc"},
                { "D", "def"},
                { "a", "ABCD"},
            };
            
            foreach(var kp in sorted2)
            {
                Console.WriteLine($"The key is { kp.Key} and the value is  {kp.Value }");
            }

        EmployeeDAL dal = new EmployeeDAL();

        // Adding Employees
        dal.addEmployee(new Employee("Alice", 101, 50000));
        dal.addEmployee(new Employee("Bob", 102, 60000));
        dal.addEmployee(new Employee("Charlie", 103, 70000));

        // Display all employees
        Console.WriteLine("All Employees:");
        foreach (Employee e in dal.GetAllEmployeesList())
        {
            Console.WriteLine(e);
        }

        // Search Employee
        Console.WriteLine("\nSearching for Employee with ID 102:");
        string name = dal.SearchEmployee(102);
        Console.WriteLine(name != null ? "Found: " + name : "Not Found");

        // Delete Employee
        Console.WriteLine("\nDeleting Employee with ID 101");
        bool deleted = dal.DeleteEmployee(101);
        Console.WriteLine(deleted ? "Deleted Successfully" : "Delete Failed");

        // Display after deletion
        Console.WriteLine("\nEmployees after Deletion:");
        foreach (Employee e in dal.GetAllEmployeesList())
        {
            Console.WriteLine(e);
        }
    }
}
