using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class Delete
    {
        [TestMethod]
        public void DeleteByFile()
        {

            File file = new File("file",null);
            Assert.IsFalse(file.delete("file"));
        }

        [TestMethod]
        public void DeleteByDirectoryNameNoExist()
        {

            Directory dossier = new Directory("dossier", null);
            dossier.mkdir("hui");
            dossier.chmod(7);
            Assert.IsFalse(dossier.delete("huit"));
        }
        [TestMethod]
        public void DeleteByDirectory()
        {

            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            dossier.mkdir("hui");
            
            Assert.IsTrue(dossier.delete("hui"));
        }
        [TestMethod]
        public void DeleteByDirectoryDeleteList()
        {

            Directory dossier = new Directory("dossier", null);
            dossier.mkdir("hui");
            dossier.chmod(7);
            dossier.delete("hui");
            Assert.AreEqual(dossier.ListFile.Count, 0);
        }
        [TestMethod]
        public void DeleteByDirectoryNotPermit()
        {

            Directory dossier = new Directory("dossier", null);
            dossier.mkdir("hui");
            Assert.IsFalse(dossier.delete("hui"));
        }
    }
}
