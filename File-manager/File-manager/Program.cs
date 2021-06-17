using System;

namespace File_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileManager fileManager = new FileManager(args);
                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        fileManager.ParseUserAction();
                    }
                }
            }
            //
            // Сводка:
            //     Открывает текстовый файл, считывает все строки файла и затем закрывает файл.
            //
            // Параметры:
            //   path:
            //     Файл, открываемый для чтения.
            //
            // Возврат:
            //     Строка, содержащая все строки файла.
            //
            // Исключения:
            //   T:System.ArgumentException:
            //     path представляет собой строку нулевой длины, содержащую только пробелы или один
            //     или несколько недопустимых символов, заданных методом System.IO.Path.InvalidPathChars.
            //
            //   T:System.ArgumentNullException:
            //     Свойство path имеет значение null.
            //
            //   T:System.IO.PathTooLongException:
            //     Указанный путь, имя файла или оба значения превышают максимальную длину, заданную
            //     в системе. Например, для платформ на основе Windows длина пути должна составлять
            //     менее 248 знаков, а длина имен файлов — менее 260 знаков.
            //
            //   T:System.IO.DirectoryNotFoundException:
            //     Указан недопустимый путь (например, он ведет на несопоставленный диск).
            //
            //   T:System.IO.IOException:
            //     При открытии файла произошла ошибка ввода-вывода.
            //
            //   T:System.UnauthorizedAccessException:
            //     Параметр path указывает файл, доступный только для чтения. -или- Эта операция
            //     не поддерживается на текущей платформе. -или- path определяет каталог. -или-
            //     У вызывающего объекта отсутствует необходимое разрешение.
            //
            //   T:System.IO.FileNotFoundException:
            //     Файл, заданный параметром path, не найден.
            //
            //   T:System.NotSupportedException:
            //     Параметр path задан в недопустимом формате.
            //
            //   T:System.Security.SecurityException:
            //     У вызывающего объекта отсутствует необходимое разрешение.
            catch
            {

            }
            
        }
    }
}
