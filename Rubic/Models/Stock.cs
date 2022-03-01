﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public int Amonnt { get; set; }
        public string ShartName { get; set; }

        public int BagPackID { get; set; }
        public BagPack BagPack { get; set; }
    }
}
