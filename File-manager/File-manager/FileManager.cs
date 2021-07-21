using System;
using System.IO;

namespace File_manager
{
    class FileManager
    {
        ConsoleFileManagerForm consoleFileManagerForm;
        const string defaultpath = @".\settings.cfg";

        public FileManager(string[] args) 
        {
            if (args.Length > 0)
            {
                throw new NotImplementedException();
            }
            else if(args.Length==0||args[0].Length==0)
            {
                LoadSettings(defaultpath);
            }
            else
            {
                LoadSettings(args[0]);
            }
        }

        void LoadSettings(string path)
        {
            consoleFileManagerForm = new ConsoleFileManagerForm();
            string[] settings=new string[100];
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    int i=0;
                    while (!streamReader.EndOfStream)
                    {
                        settings[i] = streamReader.ReadLine();
                    }
                }
                consoleFileManagerForm.currentPath = settings[0].Substring(0, settings[0].LastIndexOf('/'));
                consoleFileManagerForm.countOfElementsByPage = int.Parse(settings[1].Substring(0, settings[1].LastIndexOf('/')));
                consoleFileManagerForm.activeWindow = ActiveWindow.Console;
            }
            catch
            {
                string[] drives = Environment.GetLogicalDrives();
                foreach(string dr in drives)
                {
                    DriveInfo di = new DriveInfo(dr);
                    if (di.IsReady) 
                    {
                        consoleFileManagerForm.currentPath = di.RootDirectory.FullName;
                        break;
                    }
                }
                consoleFileManagerForm.countOfElementsByPage = 50;
                consoleFileManagerForm.activeWindow = ActiveWindow.Console;
            }

        }

        public void Run()
        {
            consoleFileManagerForm.PrintForm();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ParseUserAction();
                    consoleFileManagerForm.PrintForm();
                }
            }
        }

        void ParseUserAction()
        {
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.Tab:
                    {
                        if (consoleFileManagerForm.activeWindow == ActiveWindow.DirectoryTree)
                        {
                            consoleFileManagerForm.activeWindow = ActiveWindow.Console;
                        }
                        else
                        {
                            consoleFileManagerForm.activeWindow = ActiveWindow.DirectoryTree;
                        }
                        break;
                    }
                case ConsoleKey.Backspace:
                    {

                        break;
                    }
                case ConsoleKey.Enter:
                    {

                        break;
                    }
                case ConsoleKey.UpArrow:
                    {

                        break;
                    }
                case ConsoleKey.DownArrow:
                    {

                        break;
                    }
            }
        }
    }
}
