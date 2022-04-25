using System;

namespace UnitTesting.KT.API.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// This will add a new employee in the DB.
        /// </summary>
        /// <param name="employee"></param>
        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();// deliberately not implemented 
        }

        public Employee GetEmployeeById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
