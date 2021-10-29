﻿using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface ICourseRefundsService
    {
        public bool InsertCourseRefunds(CourseRefund courseRefund);
        public bool UpdateCourseRefunds(CourseRefund courseRefund);
        public bool DeleteCourseRefunds(int courseRefundId);
    }
}