using System;
using System.IO;
using WorkFile;

namespace WorksInFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibFile file = new MyLibFile();

            bool action = true;
            while (action)
            {
                Console.WriteLine("=====MENU=====");
                Console.WriteLine("1.Copy File.");
                Console.WriteLine("2.Copy Directory.");
                Console.WriteLine("3.Delete File.");
                Console.WriteLine("4.Move File.");
                Console.WriteLine("0.Exit.");
                Console.Write("Select a menu item: ");
                int enter = Convert.ToInt32(Console.ReadLine());
                switch (enter)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Enter a file name to copy: ");
                            string nameFile = Console.ReadLine();
                            Console.WriteLine("Enter the path of this file: ");
                            string pathFile = Console.ReadLine();
                            string nameFilePath = pathFile + "\\" + nameFile; //шлях з назвою файлу, який копіюємо
                            Console.WriteLine("Enter the name of the file you copied: ");
                            string nameFileCopy = Console.ReadLine();
                            Console.WriteLine("Enter the path of this file: ");
                            string pathFileCopy = Console.ReadLine();
                            string nameFilePathCopy = pathFileCopy + "\\" + nameFileCopy; //шлях з назвою файлу, в який копіюємо
                            file.CopyFile(nameFilePath, nameFilePathCopy); //копіюємо файл
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Enter a directory name to copy: ");
                            string nameDirectory = Console.ReadLine();
                            Console.WriteLine("Enter the path of this directory: ");
                            string pathDirectory = Console.ReadLine();
                            string nameDirectoryPath = pathDirectory + "\\" + nameDirectory; //шлях з назвою директорії, яку копіюємо
                            Console.WriteLine("Enter the name of the directory you copied: ");
                            string nameDirectoryCopy = Console.ReadLine();
                            Console.WriteLine("Enter the path of this directory: ");
                            string pathDirectoryCopy = Console.ReadLine();
                            string nameDirectoryPathCopy = pathDirectoryCopy + "\\" + nameDirectoryCopy; //шлях з назвою директорії, в яку копіюємо

                            DirectoryInfo sourceDir = new DirectoryInfo(nameDirectoryPath);
                            DirectoryInfo destinationDir = new DirectoryInfo(nameDirectoryPathCopy);
                            file.CopyDirectory(sourceDir, destinationDir); //копіюємо директорію
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Enter a file name to delete: ");
                            string nameFile = Console.ReadLine();
                            Console.WriteLine("Enter the path of this file: ");
                            string pathFile = Console.ReadLine();
                            string nameFilePath = pathFile + "\\" + nameFile; //шлях з назвою файлу, який видаляємо

                            file.DeleteFile(nameFilePath); //видаляємо файл
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Enter a file name to move: ");
                            string nameFile = Console.ReadLine();
                            Console.WriteLine("Enter the path to the folder: ");
                            string pathFile = Console.ReadLine();
                            string nameFilePath = pathFile + "\\" + nameFile; //шлях з назвою файлу та з якої папки переміщаємо
                            Console.WriteLine("Enter the name of the file you moved: ");
                            string nameFileMove = Console.ReadLine();
                            Console.WriteLine("Enter the path of this file: ");
                            string pathFileMove = Console.ReadLine();
                            string nameFilePathMove = pathFileMove + "\\" + nameFileMove; //шлях з назвою файлу та в яку папку переміщаємо
                            file.MoveFile(nameFilePath, nameFilePathMove); //переміщаємо файл
                            Console.WriteLine();
                            break;
                        }
                    case 0:
                        {
                            action = false;
                            break;
                        }
                    default:
                        Console.WriteLine("The menu item entered is incorrect !!!");
                        Console.WriteLine();
                        break;
                }
            }
                
        }
    }
}
