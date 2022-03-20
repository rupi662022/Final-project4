using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
using FINAL_PROJECT3.Models.DAL;
=======
>>>>>>> 99bdca16236b7e94e40ee57a8062f8495901b1da
>>>>>>> Stashed changes
using FINAL_PROJECT3.Models;

namespace FINAL_PROJECT3.Controllers
{
    public class GatePassController : ApiController
    {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
        public HttpResponseMessage Post([FromBody] GatePass g)
        {
            int numm = g.Insert();
            return Request.CreateResponse(HttpStatusCode.Created);
        }
=======
>>>>>>> Stashed changes
        //public int Post([FromBody] GatePass gatePass)
        //{
        //    return gatePass.InsertGate();
        //}

>>>>>>> 99bdca16236b7e94e40ee57a8062f8495901b1da

    }
}
