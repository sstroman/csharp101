using NUnit.Framework;

namespace Basics {
  [TestFixture]
  public class LogicOperators {
    [Test]
    public void And() {
      Assert.AreEqual(false, true && false);
      Assert.AreEqual(false, false && false);
      Assert.AreEqual(false, false && true);
      Assert.AreEqual(true, true && true);
    }

    [Test]
    public void FizzBuzzer() {
      Assert.AreEqual("Fizz", FizzBuzz(3));
      Assert.AreEqual("Buzz", FizzBuzz(5));
      Assert.AreEqual("FizzBuzz", FizzBuzz(30));
    }

    private string FizzBuzz(int number) {
      bool divisibleBy3 = DivisibleBy3(number);
      bool divisibleBy5 = (number % 5) == 0;
      string result = "";

      if (divisibleBy3) {
        result+= "Fizz";
      }
      if (divisibleBy5) {
        result+= "Buzz";
      }

      return result;
    }

    private static bool DivisibleBy3(int number) {
      return (number % 3) == 0;
    }
  }
}