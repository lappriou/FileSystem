using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class Cd
    {
        [TestMethod]
        public void CdByDirectoryInFileNoExist()
        {
            
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            dossier.createNewFile("hui");
            Assert.AreEqual(dossier.cd("rfd"), null);
            
        }
    }
}
