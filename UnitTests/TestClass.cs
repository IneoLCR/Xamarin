using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Droid;

namespace UnitTests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void fakeTest()
        {
            FakeClass fc = new FakeClass();
            Assert.IsTrue(fc.giveOne() == 2);
        }
    }
}
