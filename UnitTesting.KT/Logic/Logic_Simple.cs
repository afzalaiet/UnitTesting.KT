namespace UnitTesting.KT.API.Logic
{
    public class SimpleLogic : ISimpleLogic
    { 
        /// <summary>
        /// AC: As a user, I want get the bonus of any employee calculated basis on 1) equal to the salarey if age is less than 50 2) double to the salary if age is equal or greater than 50.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
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
