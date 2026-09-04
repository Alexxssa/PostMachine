using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TuringMachine;

namespace PostMachine.Tests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            Cell c = new Cell();
            c.set(Cell.A_0);
            Assert.AreEqual(c.get(),Cell.A_0);
        }
    }
}
