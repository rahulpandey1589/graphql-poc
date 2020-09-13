using GraphQL.Types;

namespace GraphQL.Api.GraphQL.Types.InputTypes
{
    public class PersonInputType : InputObjectGraphType
    {
        public PersonInputType()
        {
            Name = "personInput";
            Field<NonNullGraphType<StringGraphType>>("firstName");
            Field<StringGraphType>("lastName");
            Field<StringGraphType>("gender");
        }
    }
}
