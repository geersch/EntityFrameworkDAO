using System;
using System.Collections.Generic;
using Contracts;
using Domain;
using EfDaoImplementation;
using Managers;

namespace ConsoleApplication
{
    class Program
    {
        private static readonly IDaoFactory daoFactory = new DaoFactory();
        private static readonly PersonManager manager = new PersonManager(daoFactory);

        private static void ListProjects(Person person)
        {
            IEnumerable<Project> projects = manager.GetProjectsOfPerson(person);
            foreach (var project in projects)
            {
                Console.WriteLine("\t{0}; Deadline: {1}", project.Name, project.Deadline);
            }
        }

        static void Main()
        {
            IEnumerable<Developer> developers = manager.GetDevelopers();
            foreach(var developer in developers)
            {
                Console.WriteLine(String.Format("{0} {1}, {2}", developer.FirstName, developer.Name, developer.PreferedLanguage));
                ListProjects(developer);
            }

            IEnumerable<Analyst> analysts = manager.GetAnalysts();
            foreach (var analyst in analysts)
            {
                Console.WriteLine(String.Format("{0} {1}, {2}", analyst.FirstName, analyst.Name, analyst.Methodology));
                ListProjects(analyst);
            }

            Console.ReadLine();
        }
    }
}
