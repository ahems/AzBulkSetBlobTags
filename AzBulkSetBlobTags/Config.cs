﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzBulkSetBlobTags
{
    public class Config
    {
        public string Run { get; set; }
        public string Prefix { get; set; }
        public string StorageConnectionString { get; set; }
        public string ComputerVisionKey { get; set; }
        public string ComputerVisionEndpoint { get; set; }
        public string Container { get; set; }
        public string Delimiter { get; set; }
        public int ThreadCount { get; set; }
        public bool WhatIf { get; set; }
    }
}
