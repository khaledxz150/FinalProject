using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class WishListItem
    {
        public int WishListItemId { get; set; }
        public int WishListId { get; set; }
        public int CourseId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual Course Course { get; set; }
        public virtual WishList WishList { get; set; }
    }
}
