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
            Directory dossier1 = new Directory("dossier", null);
            dossier1.chmod(7);
            Assert.IsTrue(dossier1.createNewFile("hui"));
        }

        [TestMethod]
        public void CreateNewFileByDirectoryWithExistName()
        {
            Directory dossier2 = new Directory("dossier", null);
            dossier2.chmod(7);
            dossier2.createNewFile("hui");
            Assert.IsFalse(dossier2.createNewFile("hui"));
        }

        [TestMethod]
        public void CreateNewFileByDirectoryNoPermit()
        {
            Directory dossier3 = new Directory("dossier", null);
            Assert.IsFalse(dossier3.createNewFile("hui"));
        }

        [TestMethod]
        public void CreateNewFileByDirectoryAddList()
        {
            Directory dossier4 = new Directory("dossier", null);
            dossier4.chmod(7);
            dossier4.createNewFile("hui");
            Assert.AreEqual(dossier4.ListFile.Count, 1);
        }



    }
}
