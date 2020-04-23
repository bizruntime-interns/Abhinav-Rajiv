using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileio
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("enter option");
                Console.WriteLine("1: create dir \n2: file io \n3: file desc\n4: Delete dir " +
                    "\n5: drive info \n6:file Write Read stream reader \n7:Delete files \n8:show All Files \n9:Enter text in file" +
                    "\n 10: Read All text in file");
                int key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        {
                            Console.WriteLine("enter dir name ");
                            string dirname = Console.ReadLine();
                            createdir(dirname);
                            break;
                        }
                    case 2:
                        {
                            fileio();
                            break;
                        }
                    case 3:
                        {
                            filedesc();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("enter dir name ");
                            string dirname = Console.ReadLine();
                            deldir(dirname);
                            break;
                        }
                    case 5:
                        {
                            driveinfo();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("enter path");
                            string path = Console.ReadLine();
                            filewriteRead(path);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("enter file name");
                            string filename = Console.ReadLine();
                            deleteFile(filename);
                            break;
                        }
                    case 8:
                        {
                            getallfile();
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("enter path");
                            string path = Console.ReadLine();
                            Console.WriteLine("enter text");
                            string text = Console.ReadLine();
                            Appendstring(path, text);
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("enter path");
                            string path = Console.ReadLine();
                            readalltext( path);
                            break;
                        } 

                    default:
                        {
                            Console.WriteLine("not valid");
                            Environment.Exit(0);
                            break;
                        }

                }
            }


            // Console.ReadKey();
        }

        public static void createdir(string dirname)
        {
            DirectoryInfo di = new DirectoryInfo(dirname);
            if (di.Exists)
            {
                Console.WriteLine("alredy exist");
                return;
            }
            else
            {
                di.Create();
                Console.WriteLine("dir created " + di.Name);
            }


        }

        public static void fileio()
        {
            string file = "text.txt";
            if (File.Exists(file))
            {
                Console.WriteLine("file " + file + " alredy exist");

            }

            DateTime dt = File.GetLastWriteTime(file);
            Console.WriteLine("date created" + dt);

            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {


                    for (int i = 0; i < 10; i++)
                    {
                        bw.Write("hoooooo" + i);
                    }

                }
            }

            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {

                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(br.ReadString());
                    }
                }
            }
        }


        public static void filedesc()
        {
            string file = "text.txt";

            using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(@"c:\Temp");
                writer.Write(10);
                writer.Write(true);
            }
            float aspectRatio;
            string tempDirectory;
            int autoSaveTime;
            bool showStatusBar;

            using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                aspectRatio = reader.ReadSingle();
                tempDirectory = reader.ReadString();
                autoSaveTime = reader.ReadInt32();
                showStatusBar = reader.ReadBoolean();
            }

            Console.WriteLine("Aspect ratio set to: " + aspectRatio);
            Console.WriteLine("Temp directory is: " + tempDirectory);
            Console.WriteLine("Auto save time set to: " + autoSaveTime);
            Console.WriteLine("Show status bar: " + showStatusBar);
        }

        public static void deldir(string dirname)
        {
            DirectoryInfo di = new DirectoryInfo(dirname);

            if (di.Exists)
            {
                di.Delete();
                Console.WriteLine("directory deleted");
            }
            else
            {
                Console.WriteLine("cannot find dir named" + dirname);
                return;
            }

        }

        public static void copydir()
        {
            string sourceDirectory = @"c:\sourceDirectory";
            string targetDirectory = @"c:\targetDirectory";

            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);


        }

        public static void driveinfo()
        {
            DriveInfo[] drinf = DriveInfo.GetDrives();

            foreach (DriveInfo drives in drinf)
            {
                Console.WriteLine("drive name " + drives.Name);

                Console.WriteLine("drive type " + drives.DriveType);
                if (drives.IsReady == true)
                {
                    Console.WriteLine("drive format " + drives.DriveFormat);
                    Console.WriteLine("total size " + drives.TotalSize / (1024 * 1024 * 1024));
                    Console.WriteLine("free size " + drives.TotalFreeSpace / (1024 * 1024 * 1024));
                    Console.WriteLine("Volume label " + drives.VolumeLabel);
                    Console.WriteLine("\n");
                }
            }
        }

        public static void getallfile()
        {
            string dir = Directory.GetCurrentDirectory();
            string[] dirs = Directory.GetFiles(dir);
            foreach (string files in dirs)
            {
                Console.WriteLine(files);
            }

        }

        public static void deleteFile(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
                Console.WriteLine("File deleted");
            }
            else
            {
                Console.WriteLine("File not exist");
            }

        }

        public static void filewriteRead(string path)
        {

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                    Console.WriteLine("Wrote");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void readalltext(string path)
        {
            if(File.Exists(path))
            {
                string[] text = File.ReadAllLines(path);
                foreach(string te in text)
                {
                    Console.WriteLine(te);
                }
            }
            else
            {
                Console.WriteLine("file not exist");
            }
        }

        public static void Appendstring(string path,string text="nothing")
        {
            if(File.Exists(path))
            {
                string texts = text + Environment.NewLine;
                File.AppendAllText(path, texts);
                Console.WriteLine("Wrote");
            }
            else
            {
              var myfile=  File.Create(path);
                myfile.Close();
                string texts = text + Environment.NewLine;
                File.AppendAllText(path, texts);
                Console.WriteLine("Wrote");

            }
        }

    }
}

