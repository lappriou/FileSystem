using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class GetPath
    {
        [TestMethod]
        public void GetPathByFile()
        {
            Directory dossier = new Directory("C:", null);
            
            dossier.chmod(7);
            dossier.mkdir("hui");
            File FileCurrent = dossier;
            FileCurrent = dossier.cd("hui");
            FileCurrent.chmod(7);
            FileCurrent.mkdir("toto");
            FileCurrent = FileCurrent.cd("toto");
            FileCurrent.chmod(7);
            Assert.AreEqual(FileCurrent.getPath(), "C:/hui/toto");
        }
    }
}
