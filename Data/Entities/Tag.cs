using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Data.Entities
{
    public class Tag : BaseItemEntity
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }
}

