using Prueba.Interfaces;
using Prueba.Servicio;
using System;
using SQLite;
using Xamarin.Forms;
using System.Collections.Generic;

[assembly: Dependency(typeof(DataBase))]
namespace Prueba.Servicio
{
    public class DataBase : ISQLiteDB
    {
        public SQLiteAsyncConnection GetConnection()
        {
            string path = DependencyService.Get<IFileHelper>().GetFile();
            return new SQLiteAsyncConnection(path);
        }

        public static IEnumerable<Setting> Update (SQLiteConnection db, bool dark, int id)
        {
            return db.Query<Setting>("UPDATE Setting SET DarkMode = ? where ID = ?", dark, id);
        }
    }
}
