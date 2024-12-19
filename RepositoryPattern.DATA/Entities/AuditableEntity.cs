﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DAL.Entities
{
    public abstract class AuditableEntity:BaseEntity
    {
        public DateTime CreatedAt {  get; set; }
        public string? CreatedBy {  get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeletedAt {  get; set; } 
        public string? DeletedBy { get; set; }

    }
}
