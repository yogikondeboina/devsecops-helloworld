using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using helloworld;

namespace helloword.test
{
    public class MathTests
    {
        [Fact]
        public void Add_2_Plus_2_Equals_4()
        {
            // Arrange
            // Nothing to arrange, our class has static member.

            // Act
            int result = Arithmetic.Add(2, 2);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
