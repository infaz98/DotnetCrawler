﻿using DotnetCrawler.Data.Repository;
using System;
using System.Collections.Generic;

namespace DotnetCrawler.Data.Models
{
    public partial class CatalogType : IEntity
    {
        public CatalogType()
        {
            Catalog = new HashSet<Catalog>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Catalog> Catalog { get; set; }
    }
}
