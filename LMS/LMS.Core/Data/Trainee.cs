﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Trainee
    {
        public Trainee()
        {
            Carts = new HashSet<Cart>();
            Comments = new HashSet<Comment>();
            ContactUs = new HashSet<ContactUs>();
            CourseRatings = new HashSet<CourseRating>();
            EvaluationFormsAnswers = new HashSet<EvaluationFormsAnswer>();
            Logins = new HashSet<Login>();
            TraineeBuyCourses = new HashSet<TraineeBuyCourse>();
            TraineeSections = new HashSet<TraineeSection>();
            WishLists = new HashSet<WishList>();
        }

        public int TraineeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string ImageName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<ContactUs> ContactUs { get; set; }
        public virtual ICollection<CourseRating> CourseRatings { get; set; }
        public virtual ICollection<EvaluationFormsAnswer> EvaluationFormsAnswers { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<TraineeBuyCourse> TraineeBuyCourses { get; set; }
        public virtual ICollection<TraineeSection> TraineeSections { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }
    }
}
