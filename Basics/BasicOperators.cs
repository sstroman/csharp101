using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Basics {
  [TestFixture]
  public class BasicOperators {

    [Test]
    public void IntegerDivision() {
      Assert.AreEqual(1, 5 / 5);
      Assert.AreEqual(2, 10 / 5);
      Assert.AreEqual(1, 8 / 5);
      Assert.AreEqual(2, 13 / 5);
    }

    [Test]
    public void ModulusExample() {
      //Replace -1 with the correct values
      Assert.AreEqual(1, 1 % 5);
      Assert.AreEqual(3, 10 % 7);
      Assert.AreEqual(3, 8 % 5);

      Assert.AreEqual(2, 2 % 5);
      Assert.AreEqual(0, 5 % 5);
      Assert.AreEqual(0, 100 % 5);
    }


    [Test]
    public void Divisibility2() {
      Assert.False(IsDivisibleBy3And5(10));
      Assert.False(IsDivisibleBy3And5(5));
      Assert.False(IsDivisibleBy3And5(6));
      Assert.False(IsDivisibleBy3And5(3));
      Assert.True(IsDivisibleBy3And5(15));
      Assert.True(IsDivisibleBy3And5(45));
      Assert.True(IsDivisibleBy3And5(90));

    }

    private bool IsDivisibleBy3And5(int number) {
      bool divisibleBy3 = (number % 3) == 0;
      bool divisibleBy5 = (number % 5) == 0;
      return divisibleBy3 && divisibleBy5;
    }

    [Test]
    public void Modulus_Custom() {
      Assert.AreEqual(1, Modulus(1, 5));
      Assert.AreEqual(1, Modulus(5, 2));
      Assert.AreEqual(3, Modulus(10, 7));
      Assert.AreEqual(0, Modulus(5, 5));
      Assert.AreEqual(0, Modulus(200, 10));
    }

    private int Modulus(int left, int right) {
     
      if (left < right) {
        return left;
      }
      else if (left == right) {
        return 0;
      }
      else {
        int p = (left / right);
        return left - (p * right);
      }

    }

  }
}
