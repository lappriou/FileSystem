using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class Ls
    {
        [TestMethod]
        public void LsByFile()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            dossier.createNewFile("hui");
            Assert.AreEqual(dossier.ListFile[0].ls(), null);
        }

        [TestMethod]
        public void LsByDirectoryNoPermit()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(1);
            dossier.createNewFile("hui");
            dossier.createNewFile("hui");
            dossier.createNewFile("hui");
            dossier.createNewFile("hui");
            Assert.AreEqual(dossier.ls(), null);
        }

        [TestMethod]
        public void LsByDirectory()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(4);
            dossier.createNewFile("hui");
            dossier.createNewFile("hui");
            dossier.createNewFile("hui");
            dossier.createNewFile("hui");
            Assert.AreEqual(dossier.ls(), dossier.ListFile);
        }




    }
}
