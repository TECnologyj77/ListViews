using System;
using System.Collections.Generic;
using System.Text;

namespace ListViews.Data
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
