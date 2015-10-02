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
            dossier.createNewFile("hui");
            dossier.renameTo("hui", "toto");
            Assert.AreEqual(dossier.ListFile[0].Name , "toto");
        }
    }
}
