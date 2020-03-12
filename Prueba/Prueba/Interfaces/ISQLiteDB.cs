using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Prueba.Interfaces
{
    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
}
