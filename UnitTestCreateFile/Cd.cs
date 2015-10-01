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
            
            Directory dossier6 = new Directory("dossier", null);
            dossier6.chmod(7);
            dossier6.createNewFile("hui");
            Assert.AreEqual(dossier6.cd("rfd"), null);  
        }

        [TestMethod]
        public void CdByDirectoryInFile()
        {

            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            dossier.createNewFile("hui");
            Assert.AreEqual(dossier.cd("hui"), dossier.ListFile[0]);
        }

        [TestMethod]
        public void CdByFilee()
        {

            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            dossier.createNewFile("hui");
            Assert.AreEqual(dossier.ListFile[0].cd("hui"), null);
        }


    }
}
