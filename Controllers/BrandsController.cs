using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService; //business katmanına erişti

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        //public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        //{
        //    CreatedBrandResponse createdBrandResponse =  _brandService.Add(createBrandRequest);

        //    return createdBrandResponse;
        //}

        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
            CreatedBrandResponse createdBrandResponse = _brandService.Add(createBrandRequest);

            //return Created("",createdBrandResponse); şeklindede olabilirdi.
            return Ok(createdBrandResponse); //200 yani başarılı
        }

        [HttpGet]

        public IActionResult Get()
        {
            
            return Ok(_brandService.GetAll());
        }
    }
}
