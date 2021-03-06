﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class File
    {
        public string Name; 
        public int Permission;
        public Directory Parent;
       

        public File(string name, Directory parent) {
            this.Name = name;
            this.Permission =4;
            this.Parent = parent;
        }

        public bool canWrite()
        {
            return (Permission & 2) > 0;
        }

        public bool canExecute()
        {
            return (Permission & 1) > 0;
        }

        public bool canRead()
        {
            return (Permission & 4) > 0;
        }


        public File getParent()
        {
            return Parent;
        }

        public virtual bool createNewFile(string name)
        {
            return false;
        }

        public virtual bool mkdir(string name)
        {
            return false;
        }

        public virtual bool delete(string name)
        {

            return false;
        }

        public void chmod(int permission)
        {
            this.Permission = permission;
        }
        public virtual List<File> ls()
        {
            Console.WriteLine("Vous etes dans le fichier: " + this.Name);
            return null;
        }

        public virtual List<File> search(string name)
        {
            
            return null;
        }

        public string getName()
        {
            return this.Name;
        }

        public virtual bool renameTo(string name, string newName)
        {
            return false;
        }

        public virtual bool isFile()
        {
            return true;
        }

        public virtual bool isDirectory()
        {
            return false;
        }

        public string getPath()
        {
            // je sauvegarde la variable parent du file en utilisant une autre variable parent2
            string path = this.Name;
            File parent2 = Parent;
            while (parent2 != null)
            {
                path = parent2.Name+"/" + path;
                parent2 = parent2.Parent;
            }
            return path;
        }

        public string getRoot()
        {
            // je sauvegarde la variable parent du file en utilisant une autre variable parent2
            string root = " ";
            File parent2 = Parent;
            while (parent2.Name != "C:")
            {
                root = parent2.Name;
                parent2 = parent2.Parent;
            }
            return root;
        }

        public virtual File cd(string name)
        {
            return null;
        }
    }
}
