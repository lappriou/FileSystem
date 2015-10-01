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
    }
}
