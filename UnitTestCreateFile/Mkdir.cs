using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class Mkdir
    {
        [TestMethod]
        public void MkdirByFile()
        {
            File file = new File("file", null);
            file.chmod(7);
            Assert.IsFalse(file.createNewFile("hui"));
        }

        [TestMethod]
        public void MkdirByDirectoryWithPermit()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            Assert.IsTrue(dossier.createNewFile("hui"));
        }

        public void MkdirByDirectoryNoPermit()
        {
            Directory dossier = new Directory("dossier", null);
            Assert.IsFalse(dossier.createNewFile("hui"));
        }

        [TestMethod]
        public void MkdirByDirectoryWithExistName()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.createNewFile("hui");
            Assert.IsFalse(dossier.createNewFile("hui"));
        }

        public void MkdirByDirectoryAddList()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.createNewFile("hui");
            dossier.chmod(7);
            Assert.AreEqual(dossier.ListFile, 1);
        }
    }
}
