using UnitTesting.KT.API.Repository;

namespace UnitTesting.KT.API.Logic
{
    public class LogicWithDependency : ILogicWithDependency
    {
        private readonly IEmployeeRepository _employeeRepository;

        public LogicWithDependency(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        /// <summary>
        /// AC: As a user, I want to add one new employee into the system, provided it has non empty name.
        /// </summary>
        /// <param name="employee">Employee object.</param>
        /// <returns></returns>
        public bool CreateEmployee(Employee employee)
        {
            if (!string.IsNullOrWhiteSpace(employee.Name))
            {
                // some logic here

                _employeeRepository.AddEmployee(employee);

                // some more logic here

                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public interface ILogicWithDependency
    {
        bool CreateEmployee(Employee employee);        
    }
}
