using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public class Videogame
    {
        [Key]
        public long VideogameId { get; set; }
        public string Name { get; set; }

        public string Overview { get; set; }

        public DateTime Release_date { get; set; }

        public long Software_houseId { get; set; }
        public Software_house Software_house { get; set; }

        public override string ToString()
        {
            return $"ID: {VideogameId} ---- videogame: {Name} ---- rilasciato il: {Release_date}";
        }
    }
}
