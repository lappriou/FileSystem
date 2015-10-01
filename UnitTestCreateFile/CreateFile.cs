using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class CreateFile
    {
        [TestMethod]
        public void CreateNewFileByFile()
        {
            File file = new File("file", null);
            Assert.IsFalse(file.createNewFile("hui"));

        }

        [TestMethod]
        public void CreateNewFileByDirectory()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            Assert.IsTrue(dossier.createNewFile("hui"));
        }

        [TestMethod]
        public void CreateNewFileByDirectoryWithExistName()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            dossier.createNewFile("hui");
            Assert.IsFalse(dossier.createNewFile("hui"));
        }

        [TestMethod]
        public void CreateNewFileByDirectoryNoPermit()
        {
            Directory dossier = new Directory("dossier", null);
            Assert.IsFalse(dossier.createNewFile("hui"));
        }
    }
}
