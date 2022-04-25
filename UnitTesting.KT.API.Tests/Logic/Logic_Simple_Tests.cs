using UnitTesting.KT.API.Logic;
using Xunit;

namespace UnitTesting.KT.API.Tests.Logic
{
    // naming convention <class name>_Tests
    public class Logic_Simple_Tests
    {
        [Fact]
        // naming convention <class name>_<method name>_<scenerio>
        private void Logic_Simple_CalculateEmployeeBonas_ShouldReturnBonusDoubleToTheSalaryOnAgeMoreThanFifty()
        {
            // Arrange
            var input = new Employee() { Age = 53 , Salary = 1000};
            // Act
            var simpleLogic = new SimpleLogic();
            var bonus = simpleLogic.CalculateEmployeeBonas(input);

            // Assert
            Assert.Equal(input.Salary * 2, bonus);
        }

        [Fact]
        private void Logic_Simple_CalculateEmployeeBonas_ShouldReturnBonusToTheSalaryOnAgeLessThanFifty()
        {
            // Arrange
            var input = new Employee() { Age = 48, Salary = 1000 };
            // Act
            var simpleLogic = new SimpleLogic();
            var bonus = simpleLogic.CalculateEmployeeBonas(input);

            // Assert
            Assert.Equal(input.Salary , bonus);
        }

        [Fact]
        private void Logic_Simple_CalculateEmployeeBonas_ShouldReturnBonusDoubleToTheSalaryOnAgeEqualToFifty()
        {
            // Arrange
            var input = new Employee() { Age = 50, Salary = 1000 };
            // Act
            var simpleLogic = new SimpleLogic();
            var bonus = simpleLogic.CalculateEmployeeBonas(input);

            // Assert
            Assert.Equal(input.Salary * 2, bonus);
        }
    }
}
