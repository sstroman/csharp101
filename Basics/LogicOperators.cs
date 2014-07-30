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
  }
}