using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companyEmployeeID = new();

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(" -> ");

                string companyName = data[0];
                string employeeID = data[1];

                if (!companyEmployeeID.ContainsKey(companyName))
                {
                    companyEmployeeID.Add(companyName, new Company(companyName));
                }

                Company company = companyEmployeeID[companyName];
                if(!company.EmployeeIDs.Contains(employeeID))
                {
                    company.EmployeeIDs.Add(employeeID);
                }
            }

            foreach(Company company in companyEmployeeID.Values)
            {
                Console.WriteLine(company.Name);
                foreach(string employeeID in company.EmployeeIDs)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }

    class Company
    {
        public string Name { get; set; }
        public List<string> EmployeeIDs { get; set; }

        public Company(string name)
        {
            Name = name;
            EmployeeIDs = new List<string>();
        }
    }
}
