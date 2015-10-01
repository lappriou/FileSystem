using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class Directory : File
    {
        public List<File> ListFile = new List<File>();
        public Directory(string Name, Directory Parent) : base(Name, Parent)
        {
            this.Permission = 4;
        }



        public override bool createNewFile(string name)
        {
            bool exist = false;

            for (int i = 0; i < ListFile.Count() && exist == false; i++)
            {
                exist = name == ListFile[i].Name;
            }
            if (this.canWrite() && exist == false)
            {
                ListFile.Add(new File(name, this));
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool mkdir(string name)
        {
            bool exist = false;

            for (int i = 0; exist == false && i < ListFile.Count(); i++)
            {
                exist = name == ListFile[i].Name;
            }
            if (this.canWrite() && exist == false)
            {
                ListFile.Add(new Directory(name, this));
                return true;
            }
            else
            {
                return false;
            }
        }

        public override List<File> ls()
        {
            if (this.canRead())
            {
                return this.ListFile;
            }
            else
                return null;
        }

        public override bool isFile()
        {
            return false;
        }

        public override bool isDirectory()
        {
            return true;
        }

        public override bool renameTo(string name, string newName)
        {
            bool existFile = false;
            bool existName = false;
            int indice = 0;
            for (int i = 0; i < this.ListFile.Count() && existName == false; i++)
            {

                if (existFile = name == this.ListFile[i].Name)
                {
                    indice = i;
                }
                existName = newName == this.ListFile[i].Name;
            }

            if (existFile == true && existName == false)
            {
                this.ListFile[indice].Name = newName;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool delete(string name)
        {
            bool exist = false;
            for (int i = 0; i < ListFile.Count() && exist == false; i++)
            {

                if (exist = name == ListFile[i].Name)
                {
                    this.ListFile.Remove(ListFile[i]);
                }

            }
            return exist;
        }

        public override List<File> search(string name)
        {
            List<File> resultat = new List<File>();

            if (this.canRead())
            {
                for (int i = 0; i < ListFile.Count(); i++)
                {

                    if (name == ListFile[i].Name)
                    {

                        resultat.Add(ListFile[i]);
                    }

                    if (Convert.ToString((ListFile[i].GetType())) == "FileSystem.Directory")
                    {

                        resultat.AddRange(ListFile[i].search(name));
                    }
                }
            }
            return resultat;
        }

        public override File cd(string name)
        {
            File newFileCurrent = null;
            bool deplace = false;
            for (int i = 0; deplace == false && i < ListFile.Count; i++)
            {
                if (ListFile[i].Name == name && ListFile[i].canRead() && deplace == false)
                {
                    newFileCurrent = ListFile[i];
                    deplace = true;
                }

            }

            return newFileCurrent;
        }

    }
}
