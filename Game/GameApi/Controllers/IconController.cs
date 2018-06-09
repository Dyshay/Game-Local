using Game.Models.Client.Entity;
using Game.Models.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GameApi.Controllers
{
    public class IconController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Fetch(int level)
        {
            IEnumerable<Icon> IconList = ServiceClientLocator.Instance.Icon.Get().Where(c => c.Level == level);
            if (IconList.Count() == 0)
            {
                return NotFound();
            }
            return Json(IconList);

        }
        [HttpGet]
        public IHttpActionResult FetchAll()
        {
            IEnumerable<Icon> IconList = ServiceClientLocator.Instance.Icon.Get();
            if (IconList.Count() == 0)
            {
                return NotFound();
            }
            return Json(IconList);

        }
    }
}
