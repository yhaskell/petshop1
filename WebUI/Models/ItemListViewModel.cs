﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class ItemListViewModel
    {
        public IEnumerable<item> items { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentType { get; set; }
        
    }
}