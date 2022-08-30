using System;
using Xunit;
using WindesheimAD2021AutoVerzekeringsPremie.Implementation;

namespace WindesheimAD2021AutoVerzekeringsPremieTest
{
    public class VehicleTest
    {
        [Theory]
        [InlineData(2019, 2)]
        [InlineData(2022, 0)]
        [InlineData(2021, 0)]
        public void VehicleAgeCanBeCalculatedCorrectly(int constructionYear, int expectedVehicleAge)
        {
            //Arrange
            Vehicle vehicle = new Vehicle(73, 10000, constructionYear);

            //Act 
            int actualVehicleAge = vehicle.Age;

            //Assert
            Assert.Equal(expectedVehicleAge, actualVehicleAge);
        }
    }
}
