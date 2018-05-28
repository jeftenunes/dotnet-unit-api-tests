using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTests.Sample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTests.Sample.DomainTests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldFailCreateUserWithWrongParams()
        {
            var player = new Player(null);
        }

        [TestMethod()]
        public void ShouldCreateUserWithCorrectParams()
        {
            var name = "Jefte27";
            var player = new Player(name);

            Assert.IsNotNull(player);
            Assert.AreEqual(player.Name, name);
        }
    }
}
