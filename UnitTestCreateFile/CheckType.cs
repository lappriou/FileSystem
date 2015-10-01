using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;
namespace UnitTestCreateFile
{
    [TestClass]
    public class CheckType
    {
        [TestMethod]
        public void FileIsDirectory()
        {
            File file = new File("moi", null);

            Assert.IsFalse(file.isDirectory());
        }

        [TestMethod]
        public void FileIsFile()
        {
            File file = new File("moi", null);

            Assert.IsTrue(file.isFile());
        }
    }
}
