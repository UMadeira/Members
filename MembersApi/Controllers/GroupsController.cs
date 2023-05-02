using Members.Models.Domain;
using Members.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using MembersApi.Extensions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MembersApi.Controllers
{
    [Authorize]
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

        [HttpGet]
        public async Task<IEnumerable<Members.DTOs.Group>> GetAsync()
        {
            //if ( ! User.HasScope( "groups.get" ) )
            //{
            //    throw new UnauthorizedAccessException();
            //}

            var groups = await UnitOfWork.GetRepositoryAsync<Group>()?.GetAllAsync();

            return groups.Select(x => new Members.DTOs.Group {
                    Id = x.Id, 
                    Name = x.Name,
                    Members = x.Members?.Select( y => new Members.DTOs.Person { Id = y.Id, Name = y.Name } )
                });
        }

        [HttpGet("{id}")]
        public async Task<Members.DTOs.Group?> GetAsync(int id)
        {
            var group = await UnitOfWork.GetRepositoryAsync<Group>().GetAsync( id );
            if (group == null) return null;

            return new Members.DTOs.Group { Id = group.Id, Name = group.Name };
        }

        [HttpGet("{id}/Members")]
        public async Task<IEnumerable<Members.DTOs.Person>> GetMembersAsync(int id)
        {
            var group = await UnitOfWork?.GetRepositoryAsync<Group>()?.GetAsync(id);
            return group?.Members?.Select( y => new Members.DTOs.Person { Id = y.Id, Name = y.Name }) ?? Enumerable.Empty<Members.DTOs.Person>();
        }
    }
}
