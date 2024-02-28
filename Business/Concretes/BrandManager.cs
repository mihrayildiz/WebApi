using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
    {
        //veritabanına eklemek için nesneme çevirdim.
        Brand brand = new();
        brand.Name = createBrandRequest.Name;
        brand.CreatedDate = DateTime.Now;

        //veritabanın ekledim.
        _brandDal.Add(brand);

        //kaydı döndürüyorum.(mapping -->>automapper)
        CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();

        createdBrandResponse.Id = 4; //ileriden dbden gelecek
        createdBrandResponse.Name = brand.Name;
        createdBrandResponse.CreatedDate = brand.CreatedDate;

        return createdBrandResponse;

    }

    public List<GetAllBrandResponse> GetAll()
    {
        List<Brand> brands = _brandDal.GetAll(); //dataaccesten brand listesi dönüyor.

        List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>(); //geriye dönecek olan liste

        foreach (var brand in brands) //dataaccessten gele liste içeriside gezdim.
        {
            GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
            getAllBrandResponse.Id = brand.Id;
            getAllBrandResponse.Name = brand.Name;
            getAllBrandResponse.CreatedDate = brand.CreatedDate;

            getAllBrandResponses.Add(getAllBrandResponse);

        }

        return getAllBrandResponses;
    }
}


//response request pattern