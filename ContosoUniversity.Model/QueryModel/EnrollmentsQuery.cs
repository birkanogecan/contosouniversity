using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoUniversity.Model.QueryModel
{
    public class EnrollmentsQuery : IRequest<List<EnrollmentsQueryResult>>
    {
    }
}
