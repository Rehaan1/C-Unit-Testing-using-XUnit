using DemoLibrary.Models;
using System.Collections.Generic;
using Xunit;

namespace DemoLibrary.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_WhenCalled_ShouldAddToPersonList()
        {
            // Arrange
            List<PersonModel> people = new List<PersonModel>();
            PersonModel newPerson = new PersonModel { FirstName = "Rehaan", LastName = "Mazid" };

            // Act
            DataAccess.AddPersonToPeopleList(people, newPerson);

            // Assert - Only passes if both the assertions are true
            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newPerson, people);
        }

        [Theory]
        [InlineData("Rehaan", "", "LastName")]
        [InlineData("", "Mazid", "FirstName")]
        public void AddPersonToPeopleList_InvalidPerson_ShouldThrowException(string firstName, string lastName, string paramName)
        {
            List<PersonModel> people = new List<PersonModel>();
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };

            Assert.Throws<System.ArgumentException>(paramName, () => DataAccess.AddPersonToPeopleList(people, newPerson));
        }
    }
}
