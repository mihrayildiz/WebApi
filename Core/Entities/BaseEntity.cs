using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public  class BaseEntity<TId>
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }  //veri ne zaman eklendi.
    public DateTime? UpdatedDate { get; set; } //ne zaman güncellendi
    public DateTime? DeletedDate { get; set; } //ne zanan silindi
}


//core katmanı proje içide var olanların başka bir projede de kullanılacaksa eğer koyulduğu katmandır.
//entities klasörü entitiler için ayrılan başka projelerde de kullanılacak alanlardır.
//baseentity ise ster brand ister araba olsun fark etmez tü entityler için dbde olması gereken fieldları tutar.
//id guid, long, int olabilir bu yüzden TId verildi. yani tType
//? nullable demek ila olşturma zorunda değilsin demek