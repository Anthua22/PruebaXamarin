using Prueba.Interfaces;
using Prueba.UWP.Dependency;
using System;
using System.IO;
using System.Text;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace Prueba.UWP.Dependency
{
    class FileHelper : IFileHelper
    {
 
        public Stream getDataStoragePath()
        {
            FileStream file = null;
            BinaryWriter binaryWriter;
            if (!Exists())
            {
                file = new FileStream(GetFile(), FileMode.Create, FileAccess.ReadWrite);
                binaryWriter = new BinaryWriter(file, Encoding.UTF8);
                binaryWriter.Write("WindowsMode=OFF");
                binaryWriter.Close();
                file.Close();

            }
            else
            {
                file = new FileStream(GetFile(), FileMode.Create, FileAccess.ReadWrite);
                binaryWriter = new BinaryWriter(file, Encoding.UTF8);
                binaryWriter.Write("WindowsMode=ON");
                binaryWriter.Close();
                file.Close();
            }
            
            return file;
        }

        public string CheckMode()
        {
            string mode = "";
            
            using(StreamReader stream = new StreamReader(GetFile(), Encoding.UTF8))
            {
                string[] line = stream.ReadLine().Split('=');
                mode = line[1];
                
            }
            return mode;
        }


        public string GetFile()
        {
            return ApplicationData.Current.LocalFolder.Path + @"\setting.db3";
        }

      

        public bool Exists()
        {
            return File.Exists(GetFile());
        }

        public void ChangeMode(bool change)
        { 
            FileStream file = null;
            BinaryWriter binaryWriter = null;
            try
            {
                if (change)
                {
                    file = new FileStream(GetFile(), FileMode.Create, FileAccess.ReadWrite);
                    binaryWriter = new BinaryWriter(file, Encoding.UTF8);
                    binaryWriter.Write("WindowsMode=ON");
                }
                else
                {
                    file = new FileStream(GetFile(), FileMode.Create, FileAccess.ReadWrite);
                    binaryWriter = new BinaryWriter(file, Encoding.UTF8);
                    binaryWriter.Write("WindowsMode=OFF");
                }
               
           
            }catch(Exception e)
            {
                // DisplayAlert()
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                binaryWriter.Close();
                file.Close();
            }
           
           

            

        }
    }
}
