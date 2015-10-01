using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class Search
    {
        [TestMethod]
        public void SearchbyFileNoExist()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.mkdir("hui");
            dossier.chmod(7);
            Assert.AreEqual(dossier.search("cuicui").Count, 0);
        }

        [TestMethod]
        public void SearchbyFile()
        {
            Directory dossier = new Directory("dossier", null);
            File fileCurrent = dossier;
            fileCurrent.chmod(7);

            fileCurrent.mkdir("hui");
            fileCurrent = fileCurrent.cd("hui");
            fileCurrent.chmod(7);
            fileCurrent.mkdir("hui");
            fileCurrent = fileCurrent.cd("hui");
            fileCurrent.chmod(7);
            fileCurrent.mkdir("hui");
            fileCurrent = fileCurrent.cd("hui");
            fileCurrent.chmod(1);

            Assert.AreEqual(dossier.search("hui").Count, 3);
        }
    }
}
