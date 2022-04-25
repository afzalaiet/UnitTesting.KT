using UnitTesting.KT.API.Logic;
using Xunit;

namespace UnitTesting.KT.API.Tests.Logic
{
    public class Logic_HardToTest_Tests
    {
        private readonly Logic_HardToTest _logic_HardToTest;
        public Logic_HardToTest_Tests()
        {
            _logic_HardToTest = new Logic_HardToTest();
        }

        [Fact]
        private void Logic_HardToTest_CreateEmployee_ShouldAddEmployeeForCorrectEmployeeName()
        {
            // Arrange
            var input = new Employee() { Name = "Rahul" };

            // Act

            // becuase of non testable code, this go through the AddEmployee() and will give NotImplementedException.
            var result = _logic_HardToTest.CreateEmployee(input);

            // Assert

            Assert.True(result);
        }
    }
}
