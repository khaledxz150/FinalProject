using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Cart
    {

        public int CartId { get; set; }
        public int TraineeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Trainee Trainee { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
