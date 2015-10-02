using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class RenameTo
    {
        [TestMethod]
        public void RenameToByDirectory()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            dossier.createNewFile("hui");
            dossier.renameTo("hui", "toto");
            Assert.AreEqual("toto", dossier.ListFile[0].Name);
        }

        public void RenameToByDirectoryFileNotExist()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            dossier.createNewFile("hui");
            Assert.IsFalse(dossier.renameTo("toto", "toto"));
          
        }

        public void RenameToByDirectoryNameExist()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            dossier.createNewFile("hui");
            dossier.createNewFile("toto");
            Assert.IsFalse(dossier.renameTo("toto", "hui"));
        }

        public void RenameToByFile()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            dossier.createNewFile("hui");
            Assert.IsFalse(dossier.ListFile[0].renameTo("toto", "hui"));
        }



    }
}
