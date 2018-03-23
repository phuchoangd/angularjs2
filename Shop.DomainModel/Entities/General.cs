﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class General
    {
        public int CreatedById { get; set; }
        public int LastModified { get; set; }
        public int CreatedOn { get; set; }
        public int ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
