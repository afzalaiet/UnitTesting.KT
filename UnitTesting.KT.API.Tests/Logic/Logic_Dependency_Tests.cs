using Moq;
using UnitTesting.KT.API.Logic;
using UnitTesting.KT.API.Repository;
using Xunit;

namespace UnitTesting.KT.API.Tests.Logic
{
    public class Logic_Dependency_Tests
    {
        private readonly Mock<IEmployeeRepository> _employeeRepository_Mock;
        private readonly LogicWithDependency _logicWithDependency;
        public Logic_Dependency_Tests()
        {
            _employeeRepository_Mock = new Mock<IEmployeeRepository>();

            _logicWithDependency = new LogicWithDependency(_employeeRepository_Mock.Object);
        }
        [Fact]
        private void LogicWithDependency_CreateEmployee_ShouldNotAddEmployeeForEmptyEmployeeName()// start with negative scenerio.
        {
            // Arrange
            var input = new Employee() { Name = string.Empty };

            // Act
            var result = _logicWithDependency.CreateEmployee(input);

            // Assert

            Assert.False(result);
        }
        
        [Fact]
        private void LogicWithDependency_CreateEmployee_ShouldAddEmployeeForCorrectEmployeeName_1()
        {
            // Arrange
            var input = new Employee() { Name = "Rahul"};

            // Act
            var result = _logicWithDependency.CreateEmployee(input);

            // Assert

            Assert.True(result);
        }

        [Fact]
        private void LogicWithDependency_CreateEmployee_ShouldAddEmployeeForCorrectEmployeeName_2()
        {
            // Arrange
            var input = new Employee() { Name = "Rahul" };

            _employeeRepository_Mock.Setup(x => x.AddEmployee(input));
            // Act
            var result = _logicWithDependency.CreateEmployee(input);

            // Assert

            Assert.True(result);
            _employeeRepository_Mock.Verify(x => x.AddEmployee(input), Times.Once);
        }
    }
}
