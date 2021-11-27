using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppSql
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();
    }
}
