using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSibers_Model
{
    public static class SorterProject
    {
        public static void SortByName(List<Project> notSortedProjects)
        {
            notSortedProjects.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));
        }
        
        public static void SortByNameСustomer(List<Project> notSortedProjects)
        {
            notSortedProjects.Sort((x, y) => String.Compare(x.NameСustomerCompany, y.NameСustomerCompany, StringComparison.Ordinal));
        }
        
        public static void SortByNameСontractor(List<Project> notSortedProjects)
        {
            notSortedProjects.Sort((x, y) => String.Compare(x.NameСontractorCompany, y.NameСontractorCompany, StringComparison.Ordinal));
        }
        
        public static void SortByPriority(List<Project> notSortedProjects)
        {
            notSortedProjects.Sort((x, y) => x.Priority.CompareTo(y.Priority));
        }
        public static void SortByDataStart(List<Project> notSortedProjects)
        {
            notSortedProjects.Sort((x, y) => x.DataStart.CompareTo(y.DataStart));
        }
        public static void SortByDataEnd(List<Project> notSortedProjects)
        {
            notSortedProjects.Sort((x, y) => x.DataEnd.CompareTo(y.DataEnd));
        }
        public static List<Project> FilteringByStartDateRange(List<Project> notFilteredProjects,DateOnly dateStart, DateOnly dateEnd)
        {
            List<Project> filteredProjects = new List<Project>();
            foreach (Project project in notFilteredProjects)
            {
                if(dateStart <= project.DataStart && dateEnd >= project.DataStart)
                    filteredProjects.Add(project);
            }
            return filteredProjects;
        }
        public static List<Project> FilteringByEndDateRange(List<Project> notFilteredProjects, DateOnly dateStart, DateOnly dateEnd)
        {
            List<Project> filteredProjects = new List<Project>();
            foreach (Project project in notFilteredProjects)
            {
                if (dateStart <= project.DataEnd && dateEnd >= project.DataEnd)
                    filteredProjects.Add(project);
            }
            return filteredProjects;
        }
        public static List<Project> FilteringByPriorityRange(List<Project> notFilteredProjects, byte priorityStart, byte priorityEnd)
        {
            List<Project> filteredProjects = new List<Project>();
            foreach (Project project in notFilteredProjects)
            {
                if (priorityStart <= project.Priority && priorityEnd >= project.Priority)
                    filteredProjects.Add(project);
            }
            return filteredProjects;
        }
        public static List<Project> FilteringByContainsCharsInName(List<Project> notFilteredProjects, string consistChars)
        {
            List<Project> filteredProjects = new List<Project>();
            foreach (Project project in notFilteredProjects)
            {
                if (project.Name.Contains(consistChars))
                    filteredProjects.Add(project);
            }
            return filteredProjects;
        }
        public static List<Project> FilteringByContainsCharsInNameСontractor(List<Project> notFilteredProjects, string consistChars)
        {
            List<Project> filteredProjects = new List<Project>();
            foreach (Project project in notFilteredProjects)
            {
                if (project.NameСontractorCompany.Contains(consistChars))
                    filteredProjects.Add(project);
            }
            return filteredProjects;
        }
        public static List<Project> FilteringByContainsCharsInNameСustomer(List<Project> notFilteredProjects, string consistChars)
        {
            List<Project> filteredProjects = new List<Project>();
            foreach (Project project in notFilteredProjects)
            {
                if (project.NameСustomerCompany.Contains(consistChars))
                    filteredProjects.Add(project);
            }
            return filteredProjects;
        }
    }
}
