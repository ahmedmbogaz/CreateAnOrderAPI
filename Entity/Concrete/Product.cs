﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int StockQty { get; set; }
        public float Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
