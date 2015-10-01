using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCreateFileParDossierAvecNomExistant
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateFileParDossierAvecNomExistant()
        {
            Directory dossier = new Directory("dossier", null);
            dossier.chmod(7);
            Assert.IsTrue(dossier.createNewFile("hui"));
        }
    }
}
