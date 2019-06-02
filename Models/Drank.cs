using System.ComponentModel.DataAnnotations;

namespace DrankAPI.Models{
    public class Drank{
        public int Id {get; set;}
        public string NameBrand {get; set;}
        [Required]
        public string name {get; set;}
        [Required]
        public string type {get; set;}
        [Required]
        public int Quantity {get; set;}
        [Required]
        public int  AlcoholPersentage{get; set;}


 

    }
}