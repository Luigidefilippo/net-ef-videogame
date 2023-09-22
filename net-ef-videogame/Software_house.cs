using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public class Software_house
    {
        [Key]
        public long SoftwarehouseId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public List<Videogame> Videogiochi { get; set; }
    }
}
