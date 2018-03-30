using PaymentSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PaymentSystem.Class
{
    public static class FileSystem
    {        
        public static void WriteDataToFile(string filename,string data)
        {
            using (StreamWriter objWriter = new StreamWriter(filename, true))
            {
                objWriter.WriteLine(data);                
            }
            
        }
    }
}