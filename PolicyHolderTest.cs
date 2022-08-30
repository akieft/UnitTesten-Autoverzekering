using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindesheimAD2021AutoVerzekeringsPremie.Implementation;
using Xunit;

namespace WindesheimAD2021AutoVerzekeringsPremieTest
{
    public class PolicyHolderTest
    {
        [Theory]
        [InlineData(1777, 1777)]
        public void IsPostalCodeFourNumbers(int postalCode, int ExpectedPostalCode)
        {
            //Arrange
            PolicyHolder policyHolder = new PolicyHolder(60, "11-09-2019", postalCode, 0);

            //Act
            int ActualPostalCode = policyHolder.PostalCode;

            //Assert
            Assert.Equal(ExpectedPostalCode, ActualPostalCode);
        }


        [Theory]
        [InlineData("01-01-2020", 1)]
        [InlineData("01-01-2021", 0)]
        [InlineData("01-01-2022", -1)]
        public void PolicyHolderLicenseAgeCanBeCalculatedCorrectly(string driverLicensesStartDate, int expectedLicenseAge)
        {
            //Arrange
            PolicyHolder policyHolder = new PolicyHolder(60, driverLicensesStartDate, 1777, 0);

            //Act
            int actualLicenseAge = policyHolder.LicenseAge;

            //Assert
            Assert.Equal(expectedLicenseAge, actualLicenseAge);
        }
    }
}
