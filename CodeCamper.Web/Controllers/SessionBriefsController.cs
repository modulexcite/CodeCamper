﻿using System.Linq;
using System.Web.Http;
using CodeCamper.Model;

namespace CodeCamper.Web.Controllers
{
    public class SessionBriefsController : ApiControllerBase
    {
        public SessionBriefsController(ICodeCamperUow uow)
        {
            Uow = uow;
        }

        // GET /api/sessionbriefs
        [Queryable]
        public IQueryable<SessionBrief> Get()
        {
            return Uow.Sessions.GetSessionBriefs().OrderBy(sb => sb.TimeSlotId);
        }
    }
}