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

        [TestMethod]
        public void BCopy_Execute_Copy_WithBackup()
        {
            var backup = "BackUp";
            var destinationFolder = "BackUpFiles";
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

            var backupDir = string.Format(@"{0}\{1}", Path.GetDirectoryName(destinationFile), backup);
            if (Directory.Exists(backupDir))
            {
                var files = Directory.GetFiles(backupDir);
                foreach (var file in files)
                {
                    File.Delete(file);
                }
            }

            BCopy.Copy(originalFile, destinationFile, "Backup");
            BCopy.Copy(originalFile, destinationFile, "Backup");
            BCopy.Copy(originalFile, destinationFile, "Backup");

            int counter = 1;
            Assert.IsTrue(File.Exists(destinationFile));
            Assert.IsTrue(File.Exists(string.Format(@"{0}\{1}\{2}{3}", Path.GetDirectoryName(destinationFile), backup, Path.GetFileNameWithoutExtension(destinationFile), Path.GetExtension(destinationFile))));
            Assert.IsTrue(File.Exists(GetBackupDestination(destinationFile, backup, counter++)));
            //Assert.IsTrue(File.Exists(GetBackupDestination(destinationFile, backup, counter++))); //string.Format(@"{0}\{1}({2}){3}", Path.GetDirectoryName(destinationFile), Path.GetFileNameWithoutExtension(destinationFile), counter++, Path.GetExtension(destinationFile))));

        }

        private string GetCleanDestination(string destinationFile, int counter)
        {
            return string.Format(@"{0}\{1}({2}){3}", Path.GetDirectoryName(destinationFile), Path.GetFileNameWithoutExtension(destinationFile), counter, Path.GetExtension(destinationFile));
        }

        private string GetBackupDestination(string destinationFile, string backup, int counter)
        {
            return string.Format(@"{0}\{4}\{1}({2}){3}", Path.GetDirectoryName(destinationFile), Path.GetFileNameWithoutExtension(destinationFile), counter, Path.GetExtension(destinationFile), backup);
        }
    }
}
