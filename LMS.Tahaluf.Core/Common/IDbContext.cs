using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace LMS.Tahaluf.Core.Common
{
    public interface IDbContext
    {
        DbConnection Connection { get; }
    }
}
