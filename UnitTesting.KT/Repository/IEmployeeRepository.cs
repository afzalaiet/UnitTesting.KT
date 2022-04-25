using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTesting.KT.API.Repository
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int Id);
        void AddEmployee(Employee employee);
    }
}
