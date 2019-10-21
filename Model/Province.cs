using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lab4.Model
{

    public class Province 
    {
        [Key]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public List<City> Cities { get; set; }
    }


}
