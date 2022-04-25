namespace UnitTesting.KT.API.Logic
{
    public class SimpleLogic : ISimpleLogic
    {        
        public int CalculateEmployeeBonas(Employee employee)
        {
            if (employee.Age >= 50)
            {
                return employee.Salary * 2;
            }
            else
            {
                return employee.Salary;
            }
        }
    }

    public interface ISimpleLogic
    {
        int CalculateEmployeeBonas(Employee employee);        
    }
}
