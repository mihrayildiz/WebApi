namespace Business.Dtos.Responses;

public class GetAllBrandResponse
{
    public int Id { get; set; }  //oluşan markanın detayına gitmesi içinde verilebilir.
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
}

