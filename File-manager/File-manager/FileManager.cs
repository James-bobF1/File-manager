using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            else if(args[0].Length==0)
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
                consoleFileManagerForm.activeWindow = ActiveWindow.DirectoryTree;
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
            }

        }

        internal void ParseUserAction()
        {
            ConsoleKey key = Console.ReadKey().Key;
            switch (consoleFileManagerForm.activeWindow)
            {
                case ActiveWindow.Console:
                    break;
                case ActiveWindow.DirectoryTree:
                case ActiveWindow.FilesInfo:
                    switch (key)
                    {
                        case ConsoleKey.Tab:
                            if (consoleFileManagerForm.activeWindow++ == ActiveWindow.MessageBox)
                            {
                                consoleFileManagerForm.activeWindow = ActiveWindow.Console;
                            }
                            break;
                        case ConsoleKey.Enter:
                            break;
                        case ConsoleKey.Spacebar:
                            break;
                        case ConsoleKey.PageUp:
                            break;
                        case ConsoleKey.PageDown:
                            break;
                        case ConsoleKey.End:
                            break;
                        case ConsoleKey.Home:
                            break;
                        case ConsoleKey.LeftArrow:
                            break;
                        case ConsoleKey.UpArrow:
                            break;
                        case ConsoleKey.RightArrow:
                            break;
                        case ConsoleKey.DownArrow:
                            break;
                        case ConsoleKey.F3:
                            break;
                        default:
                            break;
                    }
                    break;
                case ActiveWindow.MessageBox:
                    //Form
                    break;
                default:
                    break;
            }
        }
    }
}
