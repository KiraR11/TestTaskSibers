using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSibers_Model
{
    public static class SorterEmployee
    {
        public static void SortByName(List<Employee> notSortedEmployees)
        {
            notSortedEmployees.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));
        }
        
        public static void SortBySurname(List<Employee> notSortedEmployees)
        {
            notSortedEmployees.Sort((x, y) => String.Compare(x.Surname, y.Surname, StringComparison.Ordinal));
        }
        
        public static void SortByPatronymic(List<Employee> notSortedEmployees)
        {
            notSortedEmployees.Sort((x, y) => String.Compare(x.Patronymic, y.Patronymic, StringComparison.Ordinal));
        }
        
    }
}
