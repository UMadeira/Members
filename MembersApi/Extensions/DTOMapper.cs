using DTOs = Members.DTOs;
using Domain = Members.Models.Domain;

namespace MembersApi.Extensions
{
    public static class DTOMapper
    {
        public static DTOs.Person Map( Domain.Person self )
        { 
            return new DTOs.Person { Id = self.Id, Name = self.Name };
        }

        public static DTOs.Group Map( Domain.Group self )
        {
            return new DTOs.Group { Id = self.Id, Name = self.Name };
        }

        public static DTOs.Person ToDTO( this Domain.Person self ) => Map( self );
        public static DTOs.Group  ToDTO( this Domain.Group self  ) => Map( self );
    }
}
