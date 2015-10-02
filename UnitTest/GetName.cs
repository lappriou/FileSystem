using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class GetName
    {
        [TestMethod]
        public void GetNamebyFile()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            Assert.AreEqual(dossier.getName(), "dossier");
        }

    }
}

