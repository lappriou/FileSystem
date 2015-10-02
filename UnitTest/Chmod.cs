using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class Chmod
    {
        [TestMethod]
        public void ChmodByFile()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            Assert.AreEqual(dossier.Permission, 7);
        }
    }
}
