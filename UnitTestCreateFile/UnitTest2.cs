using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void createNewFileByDirectory()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            Assert.IsTrue(dossier.createNewFile("hui"));
        }
    }
}
