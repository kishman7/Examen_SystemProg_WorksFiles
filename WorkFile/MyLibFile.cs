using System;
using System.IO;

namespace WorkFile
{
    public class MyLibFile
    {
        public void CopyFile(string nameFile, string pathFile) //копіюємо файл
        {
            try
            {
                File.Copy(nameFile, pathFile);
                Console.WriteLine("File copied successfully!!!");
            }
            catch (Exception)
            {
                Console.WriteLine("The file name or path is incorrect!!!");
            }
            //Console.WriteLine("CopyFile");
        }

        public void CopyDirectory(DirectoryInfo source, DirectoryInfo destination) //копіюємо директорію
        {
            try
            {
                if (!destination.Exists)
                {
                    destination.Create();
                }
                // Копіюємо всі файли.
                FileInfo[] files = source.GetFiles();
                foreach (FileInfo file in files)
                {
                    file.CopyTo(Path.Combine(destination.FullName,
                        file.Name));
                }
                // Підкаталоги процесів.
                DirectoryInfo[] dirs = source.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                    // Отримати каталог призначення.
                    string destinationDir = Path.Combine(destination.FullName, dir.Name);

                    // Викликати CopyDirectory() рекурсивно.
                    CopyDirectory(dir, new DirectoryInfo(destinationDir));
                }

                if (dirs != null)
                {
                    for (int i = 0; i < (dirs.Length - (dirs.Length - 1)); i++)
                    {
                        Console.WriteLine("Directory copied successfully!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Directory copied successfully!!!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The directory name or path is incorrect!!!");
            }
        }
        
        public void DeleteFile(string nameFile) //видаляємо файл
        {
            try
            {
                File.Delete(nameFile);
                Console.WriteLine("File deleted successfully!!!");
            }
            catch (Exception)
            {
                Console.WriteLine("The file name or path is incorrect!!!");
            }
        }

        public void MoveFile(string path, string path2)
        {
            try
            {
                File.Move(path, path2);
                Console.WriteLine("{0} was moved to {1}.", path, path2);
            }
            catch (Exception)
            {
                Console.WriteLine("The file name or path is incorrect!!!");
            }

        }
    }
}
