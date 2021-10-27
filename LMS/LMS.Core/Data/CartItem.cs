using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class CartItem
    {
        public int CartItemId { get; set; }
        public int CourseId { get; set; }
        public int CartId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Course Course { get; set; }
    }
}
