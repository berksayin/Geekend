using System;
using System.Collections.Generic;

#nullable disable

namespace Geekend.DB.Entities
{
    public partial class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int InsertUser { get; set; }
        public int UpdateUser { get; set; }
    }
}
