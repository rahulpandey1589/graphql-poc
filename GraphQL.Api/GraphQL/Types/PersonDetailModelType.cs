using GraphQL.Model;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL.Types
{
    public class PersonDetailModelType : ObjectGraphType<PersonDetails>
    {
        public PersonDetailModelType()
        {
            Field(t => t.Address);
            Field(t => t.PersonId);
            Field(t => t.MobileNumber);
        }
    }
}
