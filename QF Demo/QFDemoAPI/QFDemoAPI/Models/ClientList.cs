using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QFDemoAPI.Models
{
    public class ClientList
    {
        [Key]
        public int ClientUserId { get; set; }
        public string ClientUsername { get; set; }
        public string ClientAlias { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public int Level { get; set; }
        public string ClientEmail { get; set; }
    }
}
