using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PostMachine.Tests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            PostMachine.Cell c = new PostMachine.Cell();
            c.setMark(true);
            Assert.AreEqual(c.getMark(),true);
        }

        [TestMethod]
        public void TestMethod2() {
            TuringMachine.Cell c = new TuringMachine.Cell();
            c.set(TuringMachine.Cell.A_0);
            Assert.AreEqual(c.get(),TuringMachine.Cell.A_0);
        }

        [TestMethod]
        public void TestMethod3() {
            TuringMachine.Cell c = new TuringMachine.Cell();
            c.set(TuringMachine.Cell.A_1);
            Assert.AreEqual(c.get(),TuringMachine.Cell.A_1);
        }
    }
}
