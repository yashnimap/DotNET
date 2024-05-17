﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class AddressModel
    {
        public int id { get; set; }
        public string Details { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public AddressModel Address { get; set; }   
    }
}
