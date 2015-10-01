using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class GetParent
    {
        [TestMethod]
        public void GetParentByFile()
        {

            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            dossier.createNewFile("hui");
            Assert.AreEqual(dossier.ListFile[0].getParent(), dossier);
        }

    }
}
