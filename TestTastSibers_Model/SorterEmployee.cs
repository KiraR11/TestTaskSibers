using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSibers_Model
{
    public static class SorterEmployee
    {
        public static List<Employee> SortByNameAlphabeticallyFromBeginning(List<Employee> notSortedEmployees)
        {
            notSortedEmployees.Sort((p, q) => p.Name.CompareTo(q.Name));
            return notSortedEmployees;
        }
        public static List<Employee> SortByNameAlphabeticallyFromEnd(List<Employee> notSortedEmployees)
        {
            SortByNameAlphabeticallyFromBeginning(notSortedEmployees);
            notSortedEmployees.Reverse();
            return notSortedEmployees;
        }
        //добавить сортировку по фамалии
        //добавить сортировку по отчеству
        //по количеству проектов?
    }
}
