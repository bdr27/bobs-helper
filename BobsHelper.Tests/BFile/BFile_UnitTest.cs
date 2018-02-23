using BobsHelper.BFile;
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BobsHelper.Tests.BFile
{
    [TestClass]
    public class BFile_UnitTest
    {
        string filename = "FileToCopy.txt";
        [TestMethod]
        public void BCopy_Execute_NoDuplicate()
        {
            var destinationFolder = "NoCopyFiles";
            var originalFile = string.Format(@"TestFiles\{0}", filename);
            var destinationFile = string.Format(@"TestFiles\{0}\{1}", destinationFolder, filename);

            //var copyCheck = string.Format(@"{0}\{1}", destinationFile, filename);
            if (File.Exists(destinationFile))
            {
                File.Delete(destinationFile);
            }

            BCopy.Copy(originalFile, destinationFile);
            Assert.IsTrue(File.Exists(destinationFile));
        }

        [TestMethod]
        public void BCopy_Execute_CopyFiles()
        {
            var destinationFolder = "CopyFiles";
            var originalFile = string.Format(@"TestFiles\{0}", filename);
            var destinationFile = string.Format(@"TestFiles\{0}\{1}", destinationFolder, filename);

            var directory = Path.GetDirectoryName(destinationFile);
            if (Directory.Exists(directory))
            {
                var files = Directory.GetFiles(directory);
                foreach (var file in files)
                {
                    File.Delete(file);
                }
            }

            BCopy.Copy(originalFile, destinationFile);
            BCopy.Copy(originalFile, destinationFile);
            BCopy.Copy(originalFile, destinationFile);

            int counter = 1;
            Assert.IsTrue(File.Exists(destinationFile));
            Assert.IsTrue(File.Exists(GetCleanDestination(destinationFile, counter++)));
            Assert.IsTrue(File.Exists(GetCleanDestination(destinationFile, counter++))); //string.Format(@"{0}\{1}({2}){3}", Path.GetDirectoryName(destinationFile), Path.GetFileNameWithoutExtension(destinationFile), counter++, Path.GetExtension(destinationFile))));
        }

        private string GetCleanDestination(string destinationFile, int counter)
        {
            return string.Format(@"{0}\{1}({2}){3}", Path.GetDirectoryName(destinationFile), Path.GetFileNameWithoutExtension(destinationFile), counter, Path.GetExtension(destinationFile));
        }
    }
}
