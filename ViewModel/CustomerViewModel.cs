﻿using LibraryManagementApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApp.ViewModel
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public int BookCount { get; set; }
    }
}
