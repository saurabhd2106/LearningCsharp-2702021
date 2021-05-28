using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class MSExcel : IMSOffice
    {
        public void CloseFile()
        {
            Console.WriteLine("Close file from MSExcel");
        }

        public void CreateNewFile()
        {
            Console.WriteLine("Create file from MSExcel");
        }

        public void OpenFile()
        {
            Console.WriteLine("Open file from MSExcel");
        }

        public void RemoveFile()
        {
            Console.WriteLine("Remove file from MSExcel");
        }

        public void SaveFile()
        {
            Console.WriteLine("Save File");
        }
    }
}
