﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestCreateFile
{
    [TestClass]
    public class Delete
    {
        [TestMethod]
        public void DeleteByFile()
        {

            File file = new File("file",null);
            Assert.IsFalse(file.delete("file"));
        }
    }
}
