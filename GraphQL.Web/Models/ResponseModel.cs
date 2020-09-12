using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Web.Models
{
    public class ResponseModel<T>
    {
        public T Data { get; set; }

        public IEnumerable<ErrorModel> Errors { get; set; }
    }
}
