using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateParDirectory
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            Assert.IsTrue(dossier.createNewFile("hui"));
        }
    }
}
