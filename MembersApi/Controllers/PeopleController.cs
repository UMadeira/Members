using Members.Core.Repositories;
using Members.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MembersApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private ILogger<PeopleController> Logger     { get; }
        private IUnitOfWork               UnitOfWork { get; }


        public PeopleController( ILogger<PeopleController> logger, IUnitOfWork unitOfWork )
        {
            Logger     = logger;
            UnitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Members.DTOs.Person>? Get()
        {
            return UnitOfWork.GetRepository<Person>()?.GetAll()
                .Select( x => new Members.DTOs.Person { Id = x.Id, Name = x.Name } );
        }

        [HttpGet("{id}")]
        public Members.DTOs.Person? Get( int id )
        {
            var person = UnitOfWork.GetRepository<Person>()?.Get(id);
            if (person == null) return null;

            return new Members.DTOs.Person { Id = person.Id, Name = person.Name };
        }
    }
}