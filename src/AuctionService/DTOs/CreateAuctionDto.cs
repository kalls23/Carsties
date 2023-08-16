namespace AuctionService.DTOs;
using System.ComponentModel.DataAnnotations;

public class CreateAuctionDto
{


    [Required]  
    public String  Make { get; set; }

    [Required]  
    public string Model { get; set; }
    [Required]  
    public int Year { get; set;}
    [Required]  
    public string Color { get; set; }
    [Required]  
    public int Mileage { get; set; }

    [Required]  
    public string ImageUrl { get; set; }
    [Required]  
    public int ReservePrice {get; set;}

    [Required]  
    public DateTime AuctionEnd {get; set;}

}
