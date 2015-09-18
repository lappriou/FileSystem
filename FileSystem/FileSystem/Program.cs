using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class Program
    {
        public static bool TryParse { get; private set; }

        static void Main(string[] args)
        {
            string command;
            Directory racine = new Directory("C:", null);
            bool exit = false;
            File fileCurrent = racine;
            int result;

            string[] listCommand;

            while (exit == false)
            {

                command = Console.ReadLine();


                listCommand = command.Split(' ');

                if (listCommand[0] == "parent" && fileCurrent.getParent() == null)
                {
                    exit = true;
                }

                else if (listCommand[0] == "parent")
                {
                    fileCurrent = fileCurrent.getParent();
                }

                else if (listCommand[0] == "create" && listCommand.Count() == 2)
                {

                    Console.WriteLine(fileCurrent.createNewFile(listCommand[1]));

                }

                else if (listCommand[0] == "rename" && listCommand.Count() == 3)
                {

                    Console.WriteLine(fileCurrent.renameTo(listCommand[1], listCommand[2]));

                }


                else if (listCommand[0] == "mkdir" && listCommand.Count() == 2)
                {
                    Console.WriteLine(fileCurrent.mkdir(listCommand[1]));
                }

                else if (listCommand[0] == "directory")
                {
                    Console.WriteLine(fileCurrent.isDirectory());
                }

                else if (listCommand[0] == "file")
                {
                    Console.WriteLine(fileCurrent.isFile());
                }

                else if (listCommand[0] == "delete" && listCommand.Count() == 2)
                {
                    Console.WriteLine(fileCurrent.delete(listCommand[1]));
                }

                else if (listCommand[0] == "root")
                {
                    Console.WriteLine(fileCurrent.getRoot());
                }


                else if (listCommand[0] == "path")
                {
                    Console.WriteLine(fileCurrent.getPath());
                }

                else if (listCommand[0] == "chmod" && listCommand.Count() == 2)
                {
                    int test;
                    bool canConvert = int.TryParse(listCommand[1], out test);
                    if (canConvert == true)
                    {

                        fileCurrent.chmod(test);
                    }
                }

                else if (listCommand[0] == "ls")
                {
                    if (fileCurrent.ls() != null)
                    {
                        foreach (File item in fileCurrent.ls())
                        {
                            Console.WriteLine(item.Name + " (" + item.GetType() + ") " + item.Permission);
                        }
                    }
                }

                else if (listCommand[0] == "search" && listCommand.Count() == 2)
                {
                    foreach (File item in fileCurrent.search(listCommand[1]))
                    {
                        Console.WriteLine(item.Name + "  " + item.getPath());
                    }
                }


                else if (listCommand[0] == "cd" && listCommand.Count() == 2)
                {
                    fileCurrent = fileCurrent.cd(listCommand[1]);
                }


            }
        }
    }
}
