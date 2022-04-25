using UnitTesting.KT.API.Repository;

namespace UnitTesting.KT.API.Logic
{
    /// <summary>
    /// This class is hard to test because of its 'Tight coupling' of the dependency. 
    /// This will also lead to change this class in future if the dependency gets changed in future.
    /// </summary>
    public class Logic_HardToTest : ILogicWithDependency
    {
        public bool CreateEmployee(Employee employee)
        {
            if (!string.IsNullOrWhiteSpace(employee.Name))
            {
                // some logic here
                var employeeRepository = new EmployeeRepository();
                employeeRepository.AddEmployee(employee);

                // some more logic here

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
