using GraphQL.Model.Enumeration;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Api.GraphQL.Types
{
    public class JobTypeEnumType : EnumerationGraphType<JobType>
    {
        public JobTypeEnumType()
        {
            Name = "JobType";
            Description = "The type of job i.e. Permanent or Contractual";
                
        }
    }
}
