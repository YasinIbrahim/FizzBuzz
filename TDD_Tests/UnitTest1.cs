using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

[TestFixture]
public class NUnitTests
{
        
    FizzBuzz f = new FizzBuzz();
    
    [Test]
    public void NumberDivisibleBy3_ReturnFizz()
    {
        Assert.AreEqual("Fizz", f.checkFizzBuzz(3) );
    }

    [Test]
    public void NumberDivisibleBy5_ReturnBuzz()
    {
        Assert.AreEqual("Buzz", f.checkFizzBuzz(5));
    }

    [Test]
    public void NumberDivisibleBy3And5_ReturnFizzBuzz()
    {
        Assert.AreEqual("FizzBuzz", f.checkFizzBuzz(15));
    }

    [Test]
    public void NumberNotDivisibleBy3Or5_ReturnNumber()
    {
        Assert.AreEqual("22", f.checkFizzBuzz(22));
    }
    
}
