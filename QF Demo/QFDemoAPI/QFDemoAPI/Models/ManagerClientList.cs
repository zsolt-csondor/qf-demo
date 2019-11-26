using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QFDemoAPI.Models
{
    public class ManagerClientList
    {
        [Key]
        public int ManagerUserId { get; set; }
        public string ManagerUserName { get; set; }
        public string ManagerEmail { get; set; }
        public string ManagerAlias { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerPosition { get; set; }
        public int ClientUserId { get; set; }
        public string ClientUserName { get; set; }
        public string ClientEmail { get; set; }
        public string ClientAlias { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public int Level { get; set; }
    }
}
