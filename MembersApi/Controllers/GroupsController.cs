using Members.Core.Repositories;
using Members.Models.Domain;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MembersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private ILogger<PeopleController> Logger { get; }
        private IUnitOfWork UnitOfWork { get; }


        public GroupsController(ILogger<PeopleController> logger, IUnitOfWork unitOfWork)
        {
            Logger = logger;
            UnitOfWork = unitOfWork;
        }

        // GET: api/<GroupsController>
        [HttpGet]
        public IEnumerable<DTOs.Group> Get()
        {
            return UnitOfWork.GetRepository<Group>().GetAll()
                .Select(x => new DTOs.Group {
                    Id = x.Id, 
                    Name = x.Name,
                    Members = x.Members?.Select( y => new DTOs.Person { Id = y.Id, Name = y.Name } )
                });
        }

        // GET api/<GroupsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GroupsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GroupsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GroupsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("{id}/Members")]
        public IEnumerable<DTOs.Person> GetMembers(int id)
        {
            return UnitOfWork.GetRepository<Group>().Get(id)?.Members
                .Select(y => new DTOs.Person { Id = y.Id, Name = y.Name }) ?? Enumerable.Empty<DTOs.Person>();
        }
    }
}
