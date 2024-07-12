using System;
using Xunit;

namespace DemoLibrary.Tests
{
    public class ExamplesTests
    {
        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("exampleFile.txt"); ;

            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldFail()
        {
            // Check if exception thrown is an ArgumentException
            Assert.Throws<ArgumentException>("file", () => Examples.ExampleLoadTextFile(""));
        }
    }
}
