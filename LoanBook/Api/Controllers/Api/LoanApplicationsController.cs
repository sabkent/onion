using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api.Models;

namespace Api.Controllers.Api
{
    public class LoanApplicationsController : ApiController
    {
        public HttpResponseMessage Post(LoanSubmission loanSubmission)
        {
            var loanApplication = new LoanApplication {Id = Guid.NewGuid()}; 
            var response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(String.Format("http://http://localhost:49063/api/loanapplications/{0}", loanApplication.Id));
            return response;
        }

        public void Get()
        {
            bool pass = true;
        }
    }
}
