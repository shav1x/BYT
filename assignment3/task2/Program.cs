using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace task2;

public class Program
{
    [Test]
    public void TestAdditionPositive()
    {
        Assert.That(Calculator.Calculate(7, 82, '+'), Is.EqualTo(89));
    }
    
    [Test]
    public void TestAdditionNegative()
    {
        Assert.That(Calculator.Calculate(-28, -11, '+'), Is.EqualTo(-39));
    }
    
    [Test]
    public void TestSubtractionPositive()
    {
        Assert.That(Calculator.Calculate(31, 16, '-'), Is.EqualTo(15));
    }
    
    [Test]
    public void TestSubtractionNegative()
    {
        Assert.That(Calculator.Calculate(5, 13, '-'), Is.EqualTo(-8));
    }
    
    [Test]
    public void TestMultiplication()
    {
        Assert.That(Calculator.Calculate(6, 25, '*'), Is.EqualTo(150));
    }
    
    [Test]
    public void TestDivision()
    {
        Assert.That(Calculator.Calculate(20, 8, '/'), Is.EqualTo(2.5));
    }
    
    [Test]
    public void TestDivisionByZero()
    {
        Assert.That(() => Calculator.Calculate(12, 0, '/'), Throws.TypeOf<DivideByZeroException>());
    }
    
    [Test]
    public void TestIncorrectOperation()
    {
        Assert.That(() => Calculator.Calculate(23, 8, '?'), Throws.ArgumentException);
    }
}
