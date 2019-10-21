using System.ComponentModel.DataAnnotations;

namespace lab4.Model
{
    public class City
    {   [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Population { get; set; }
        #nullable enable
        public string? ProvinceCode { get; set; }
    }


}
