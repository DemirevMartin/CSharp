using System;
using System.Collections.Generic;
namespace Folder_and_files
{
    class File
    {
        string name; 
        DateTime crTime; 
        public File(string nm)
        { 
            if(string.IsNullOrEmpty(nm)) throw new ArgumentException("Invalid or missing file name!");
            name = nm;
            crTime = DateTime.Now;
        }
        public void Rename(string newName)
        {
			if (string.IsNullOrEmpty(newName)) {throw new ArgumentException("Invalid or missing file name!");}
            name = newName;
        }
        public void PrintInfo()
        { 
            Console.WriteLine("File: {0}, created: {1:HH:mm:ss, dd.MM.yyyy}", name, crTime);
        }
    }
    class Folder
    {
        string name; 
        DateTime crTime; 
        List<File> fList; 
        public Folder(string nm)
        {
           if(string.IsNullOrEmpty(nm)) throw new ArgumentException("Invalid or missing file name!");
           name = nm;
           crTime = DateTime.Now;
           fList = new List<File>();
        }
        public void ManageFiles()
        {
            do
            {
               Console.Clear();
               Console.WriteLine("Папка {0} - избор на действие", name);
               Console.WriteLine("1. Създаване на файл");
               Console.WriteLine("2. Преименуване на файл");
               Console.WriteLine("3. Изтриване на файл");
               Console.WriteLine("4. Преглед на съдържанието на папката");
               Console.WriteLine("5. Изход");
               Console.Write("Вашият избор е: ");
               int ch = int.Parse(Console.ReadLine());
               switch (ch)
               {
                   case 1:
                   CreateFile();
                   break;
                   case 2:
                   RenameFile();
                   break;
                   case 3:
                   DeleteFile();
                   break;
                   case 4:
                   PrintFolderInfo();
                   break;
                   default:
                   return;
                }
                Console.WriteLine("Натиснете клавиш, за да продължите!");
                Console.ReadKey(true);
            }
            while(true);
        }
        void CreateFile()
        {
            Console.Write("Въведете име за файла: ");
            string nm = Console.ReadLine();
            fList.Add(new File(nm));
        }
        int ChooseFile()
        {
            if(fList.Count < 1) return -1;
            do
            {
                Console.WriteLine("Изберете номер на файл - число от 1 до {0} включително!", fList.Count);
                Console.Write("Вашият избор е: ");
                int ch = int.Parse(Console.ReadLine());
                if(ch>=1 && ch<=fList.Count) return ch;
                Console.WriteLine("Невалиден избор!");
             }
             while(true);
        }
        void RenameFile()
        {
            int fIndex = ChooseFile() - 1;
            if(fIndex < 0)
            {
                Console.WriteLine("Папката е празна!");
                return;
            }
            Console.Write("Избраният файл за преименуване е: ");
            fList[fIndex].PrintInfo();
            Console.Write("Въведете ново име за файла: ");
            string newName = Console.ReadLine();
            fList[fIndex].Rename(newName);
        }
        void DeleteFile()
        {
            int fIndex = ChooseFile() - 1;
            if(fIndex < 0 )
            {
                Console.WriteLine("Папката е празна!");
                return;
            }
            Console.Write("Избраният файл за изтриване е: ");
            fList[fIndex].PrintInfo();
            fList.RemoveAt(fIndex);
         }
         void PrintFolderInfo()
         {
            Console.WriteLine();
            Console.WriteLine("Папка {0}, създаване: {1:HH:mm:ss, dd.MM.yyyy}", name, crTime);
            Console.WriteLine(new String('-', 50));
            if (fList.Count > 0)
            {
                foreach (File f in fList) 
                {
                    f.PrintInfo();
                }
                Console.WriteLine("Общо: {0} файл/а", fList.Count);
            }
            else
            {
                Console.WriteLine("В момента папката е празна!");
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Folder fld = new Folder("Test folder");
            fld.ManageFiles();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}