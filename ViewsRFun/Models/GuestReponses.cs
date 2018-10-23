using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewsRFun.Models
{
    public class GuestReponses
    {
        // These are variables within the model - Name, Email, Phone, WillAttend
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}