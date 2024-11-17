using Library;
using Xunit;

namespace CarTests
{
    public class CarTests
    {
        [Fact]
        public void Constructor_ShouldInitializeCorrectly()
        {

            var car = new Car(4);

            Assert.Equal(4, car.MaxNumberOfPassengers);
            Assert.Equal(0, car.GetNumberOfPassengers());
        }

        [Fact]
        public void AddPassengers_ShouldReturnTrue_WhenAddingValidPassengers()
        {

            var car = new Car(5);

            bool result = car.AddPassengers(3);

            Assert.True(result);
            Assert.Equal(3, car.GetNumberOfPassengers());
        }

        [Fact]
        public void AddPassengers_ShouldReturnFalse_WhenAddingNegativePassengers()
        {

            var car = new Car(5);

            bool result = car.AddPassengers(-1);

            Assert.False(result);
            Assert.Equal(0, car.GetNumberOfPassengers());
        }

        [Fact]
        public void AddPassengers_ShouldReturnFalse_WhenExceedingMaxCapacity()
        {

            var car = new Car(4);

            car.AddPassengers(3);
            bool result = car.AddPassengers(2);

            Assert.False(result);
            Assert.Equal(3, car.GetNumberOfPassengers());
        }

        [Fact]
        public void AddPassengers_ShouldHandleBoundaryCondition_WhenAddingToMaxCapacity()
        {

            var car = new Car(5);

            bool result = car.AddPassengers(5);

            Assert.True(result);
            Assert.Equal(5, car.GetNumberOfPassengers());
        }
    }
}
