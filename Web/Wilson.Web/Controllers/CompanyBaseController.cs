using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wilson.Companies.Data.DataAccess;

namespace Wilson.Web.Controllers
{
    [Authorize]
    public class CompanyBaseController : Controller
    {        
        public CompanyBaseController(ICompanyWorkData companyWorkData, IMapper mapper)
        {
            this.CompanyWorkData = companyWorkData;
            this.Mapper = mapper;
        }

        public ICompanyWorkData CompanyWorkData { get; set; }

        public IMapper Mapper { get; set; }
    }
}