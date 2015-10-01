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
            Assert.IsFalse(file.mkdir("hui"));
        }

        [TestMethod]
        public void MkdirByDirectoryWithPermit()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            Assert.IsTrue(dossier.mkdir("hui"));
        }

        public void MkdirByDirectoryNoPermit()
        {
            Directory dossier = new Directory("dossier", null);
            Assert.IsFalse(dossier.mkdir("hui"));
        }

        [TestMethod]
        public void MkdirByDirectoryWithExistName()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.mkdir("hui");
            Assert.IsFalse(dossier.mkdir("hui"));
        }

        public void MkdirByDirectoryAddList()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.mkdir("hui");
            dossier.chmod(7);
            Assert.AreEqual(dossier.ListFile, 1);
        }
    }
}
