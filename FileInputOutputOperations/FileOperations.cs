﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutputOperations
{
    public class FileOperations
    {
        string filepath = @"E:\VisualPractise\FileInputOutputOperations\Example.txt";
        string copyFilePath = @"E:\VisualPractise\FileInputOutputOperations\Example.txt";
        public void FileExist()
        {
            if(File.Exists(filepath))
            {
                Console.WriteLine("File Exists");
                return;
            }
            File.Create(filepath);
        }
        public void ReadAllLines()
        {
            string[] arr = File.ReadAllLines(filepath);
            foreach(var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        public void ReadAllText()
        {
            string lines=File.ReadAllText(filepath);
            Console.WriteLine(lines);
        }
        public void CopyFile()
        {
            File.Copy(filepath, copyFilePath);
        }
        public void DeleteFilePath()
        {
            File.Delete(copyFilePath);
        }
        public void UsingStreamReader()
        {
            if(File.Exists(filepath))
            {
                StreamReader reader=new StreamReader(filepath);
                try
                {
                    string s = " ";
                    while((s = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
        }
    }
}
