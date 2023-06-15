using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace ResponsiveUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void NormalEntryTest()
        {
            // Arrange
            string Name = "Megan";
            int birthYear= 2000;
            

            string expected = "Megan will be 23 this Year!";
            string actual;

            // Act
            actual = FirstResponsiveWebAppGarrels.Models.responsive.AgeThisYear(Name, birthYear);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreaterThanCurrentYearTest()
        {
            // Arrange
            string Name = "Megan";
            int birthYear = 2024;


            string expected = "Invalid Birth Year";
            string actual;

            // Act
            actual = FirstResponsiveWebAppGarrels.Models.responsive.AgeThisYear(Name, birthYear);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NameCasingTest()
        {
            // Arrange
            string Name = "MeGaN";
            int birthYear = 2000;


            string expected = "MeGaN will be 23 this Year!";
            string actual;

            // Act
            actual = FirstResponsiveWebAppGarrels.Models.responsive.AgeThisYear(Name, birthYear);

            // Assert
            Assert.Equal(expected, actual);
        }
     
    }
}