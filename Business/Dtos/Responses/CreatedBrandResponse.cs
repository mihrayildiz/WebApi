using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses;

public class CreatedBrandResponse
{
    public int Id { get; set; }  //oluşan markanın detayına gitmesi içinde verilebilir.
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
}

