using MSTests.Sample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MSTests.Sample.API.Controllers
{
    public class PlayersController : ApiController
    {
        private readonly List<Player> Players;
        public PlayersController()
        {
            Players = new List<Player>
            {
                new Player("Bruno"),
                new Player("Djalma"),
                new Player("Jefte27")
            };
        }

        // GET: api/Players
        public IHttpActionResult Get()
        {
            return Ok(Players);
        }

        // GET: api/Players/5
        public IHttpActionResult GetByName(string name)
        {
            return Ok(Players.FirstOrDefault(p => p.Name.Equals(name)));
        }
    }
}
