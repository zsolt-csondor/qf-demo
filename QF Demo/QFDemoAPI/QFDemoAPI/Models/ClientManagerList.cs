using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QFDemoAPI.Models
{
    public class ClientManagerList
    {
        [Key]
        public int ClientUserId { get; set; }
        public string ClientUsername { get; set; }
        public string ClientAlias { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public int Level { get; set; }
        public string ClientEmail { get; set; }
        public int ManagerUserId { get; set; }
        public string ManagerUsername { get; set; }
        public string ManagerAlias { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerEmail { get; set; }
        public string Position { get; set; }

    }
}
