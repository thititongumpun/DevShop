﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Infrastructure.Redis
{
    public class RedisCacheSettings
    {
        public bool Enable { get; set; }
        public string ConnectionString { get; set; }
    }
}