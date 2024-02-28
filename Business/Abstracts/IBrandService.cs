using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandService
{
    CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);
    List<GetAllBrandResponse> GetAll();
}

//hiçir zaman sın kullanıcıdan db nesneleri istenmez ve son kullanıcıya da 
//gösterilmez bu yüzden dtos klasörü vardı.
//birde örneğin createddate istenmez ancak gösterilmek istenebilir bu durumda iki kavram ortaya çıkar.
//responses and requestskavraları
//her metot içi aynı dtolar kullanılmmalıdır kullajılması gerekilen durumlar olabilir ancak ihtiyaca göre karar verilir.