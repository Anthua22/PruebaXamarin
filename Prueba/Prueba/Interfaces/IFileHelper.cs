using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Interfaces
{
    public interface IFileHelper
    {
        Stream getDataStoragePath();
        bool Exists();
        string CheckMode();
        void ChangeMode(bool check);
    }
}
