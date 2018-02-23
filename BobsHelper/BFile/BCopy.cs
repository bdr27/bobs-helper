using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BobsHelper.BFile
{
    public static class BCopy
    {
        public static void Copy(string sourceFileName, string destFileName)
        {
            string destFolder = Path.GetDirectoryName(destFileName);
            if (Directory.Exists(destFolder))
            {
                var temp = destFileName;
                int counter = 1;
                while (File.Exists(temp))
                {
                    temp = string.Format(@"{0}\{1}({2}){3}", destFolder, Path.GetFileNameWithoutExtension(destFileName), counter++, Path.GetExtension(destFileName));
                }
                destFileName = temp;
            }
            else
            {
                Directory.CreateDirectory(destFolder);
            }
            File.Copy(sourceFileName, destFileName);
        }
    }
}
