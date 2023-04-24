using Members.Core.Repositories;
using Members.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace MembersApi.Controllers
{
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
        public IEnumerable<DTOs.Person>? Get()
        {
            return UnitOfWork.GetRepository<Person>()?.GetAll()
                .Select( x => new DTOs.Person { Id = x.Id, Name = x.Name } );
        }

        [HttpGet("{id}")]
        public DTOs.Person? Get( int id )
        {
            var person = UnitOfWork.GetRepository<Person>()?.Get(id);
            if (person == null) return null;

            return new DTOs.Person { Id = person.Id, Name = person.Name };
        }
    }
}