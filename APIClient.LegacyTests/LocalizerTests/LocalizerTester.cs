﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VersionOne.SDK.APIClient.LegacyTests.LocalizerTests
{
    [TestClass]
    public class LocalizerTester : LocalizerTesterBase
    {
        protected override string LocTestKeys { get { return "LocalizerTester"; } }

        [TestMethod]
        public void SimpleString()
        {
            Assert.AreEqual("Resolve To Simple", Loc.Resolve("Simple"));
        }

        [TestMethod]
        public void ReturnInput()
        {
            Assert.AreEqual("Blah", Loc.Resolve("Blah"));
        }
    }
}