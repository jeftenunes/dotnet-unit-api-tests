using MSTests.Sample.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTests.Sample.Domain
{
    public class Player : IEntity
    {
        public string Name { get; private set; }

        protected Player()
        {

        }

        public Player(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            Name = name;
        }
    }
}
