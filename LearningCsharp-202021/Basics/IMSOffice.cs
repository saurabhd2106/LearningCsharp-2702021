using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public interface IMSOffice
    {

        public void CreateNewFile();

        public void OpenFile();
        public void CloseFile();
        public void RemoveFile();

    }
}
