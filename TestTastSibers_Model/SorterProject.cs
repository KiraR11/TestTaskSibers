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
    }
}
