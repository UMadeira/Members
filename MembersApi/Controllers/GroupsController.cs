using Members.Models.Domain;
using Members.Data;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MembersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private ILogger<PeopleController> Logger { get; }
        private IUnitOfWorkAsync UnitOfWork { get; }


        public GroupsController(ILogger<PeopleController> logger, IUnitOfWorkAsync unitOfWork)
        {
            Logger = logger;
            UnitOfWork = unitOfWork;
        }

        // GET: api/<GroupsController>
        [HttpGet]
        public async Task<IEnumerable<DTOs.Group>> GetAsync()
        {
            var groups = await UnitOfWork.GetRepositoryAsync<Group>()?.GetAllAsync();

            return groups.Select(x => new DTOs.Group {
                    Id = x.Id, 
                    Name = x.Name,
                    Members = x.Members?.Select( y => new DTOs.Person { Id = y.Id, Name = y.Name } )
                });
        }

        [HttpGet("{id}")]
        public async Task<DTOs.Group?> GetAsync(int id)
        {
            var group = await UnitOfWork.GetRepositoryAsync<Group>().GetAsync( id );
            if (group == null) return null;

            return new DTOs.Group { Id = group.Id, Name = group.Name };
        }

        [HttpGet("{id}/Members")]
        public async Task<IEnumerable<DTOs.Person>> GetMembersAsync(int id)
        {
            var group = await UnitOfWork?.GetRepositoryAsync<Group>()?.GetAsync(id);
            return group?.Members?.Select( y => new DTOs.Person { Id = y.Id, Name = y.Name }) ?? Enumerable.Empty<DTOs.Person>();
        }
    }
}
