using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DirLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "C:/Windows/System32";

            FilterListOfFilesInDir(dirPath);
            Console.WriteLine();

            FilterListOfFoldersInDir(dirPath);
        }


        private static void FilterListOfFoldersInDir(string dirPath)
        {
            string[] folders = Directory.GetDirectories(dirPath);
            var foldersList = new List<Folder>();
            foreach (string folder in folders)
            {
                var tempFolderInfo = new DirectoryInfo(folder);
                long fileSize = CalcDirSize(tempFolderInfo);
                foldersList.Add(new Folder(tempFolderInfo.Name, fileSize));
            }

            Console.WriteLine("------Filtering Files By Name------");
            var top10FilesByName = (from folder in foldersList
                              orderby folder.Name 
                              select folder.Name).Take(10);

            foreach (string s in top10FilesByName)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------Filtering Files By Size------");
            var top10FilesBySize = (from folder in foldersList
                              orderby folder.Size descending
                              select folder.Name + " " + folder.Size).Take(10);

            foreach (string s in top10FilesBySize)
            {
                Console.WriteLine(s);
            }

        }

        private static long CalcDirSize(DirectoryInfo tempFolderInfo)
        {
            try
            {
                return  tempFolderInfo.EnumerateFiles().Sum(f => f.Length);
            }
            catch(UnauthorizedAccessException e)
            {
                return 0;
            }
        }

        private static void FilterListOfFilesInDir(string dirPath)
        {
            string[] files = Directory.GetFiles(dirPath);
            var filesInfo = new List<FileInfo>();
            foreach(string file in files)
            {
                var tempFileInfo = new FileInfo(file);
                filesInfo.Add(tempFileInfo);
            }

            Console.WriteLine("------Filtering Files By Size------");
            var top10FilesBySize = (from file in filesInfo
                              orderby file.Length descending
                              select file.Name + " " + file.Length).Take(10);

            foreach (string s in top10FilesBySize)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------Filtering Files By Name------");
            var top10FilesByNames = (from file in filesInfo
                              orderby file.Name
                              select file.Name).Take(10);

            foreach (string s in top10FilesByNames)
            {
                Console.WriteLine(s);
            }

        }
    }
}
