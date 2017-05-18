using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyProject
{
    class ArtList<T>
    {
        T NItem;
        ArtList<T> Next;
        ArtList<T> Head;

        private ArtList(){}

        private ArtList(T Item)
        {
            this.NItem = Item;
            Head = this;
        }

        private void Add(T item)
        {
            if (Head == null)
            {
                Head = new ArtList<T>(item);
            }
            else
            {
                ArtList<T> current = Head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new ArtList<T>(item);
            }
        }

        public int Length
        {
            get
            {
                int l = 0;
                if (Head != null)
                {
                    ArtList<T> current = Head;
                    while (current != null)
                    {
                        current = current.Next;
                        l++;
                    }
                }
                return l;
            }
        }

        public T this[int index]
        {
            get
            {
                int i = 0;
                ArtList<T> current = Head;
                while (i < index)
                {
                    current = current.Next;
                    i++;
                }

                return current.NItem;
            }
        }

        public static ArtList<Picture> GatherPictures()
        {
            string path = Environment.CurrentDirectory;
            string str = "";
            for (int i = 0; i < path.Length - 10; i++)
            {
                str += path[i];
            }
            path = @str + @"\Info\Pictures";
            DirectoryInfo dirInf = new DirectoryInfo(path);

            FileInfo[] FileArr = dirInf.GetFiles();
            ArtList<Picture> resultGallery = new ArtList<Picture>();

            foreach (FileInfo fi in FileArr)
            {
                string PathToFile = path + "\\" + fi.Name;
                string inf = File.ReadAllText(PathToFile);
                string[] infArr = inf.Split('\n');

                Picture newPict = new Picture();
                newPict.Name = infArr[0].Trim().Trim();
                newPict.Artist = infArr[1].Trim().Trim();
                newPict.Year = Convert.ToInt32(infArr[2]);
                newPict.Style = infArr[3].Trim().Trim();
                newPict.Path = @path + @infArr[4];

                resultGallery.Add(newPict);
            }

            return resultGallery;
        }

        public static ArtList<Artist> GatherArtists()
        {
            string path = Environment.CurrentDirectory;
            string str = "";
            for (int i = 0; i < path.Length - 10; i++)
            {
                str += path[i];
            }
            path = @str + @"\Info\Artists";
            DirectoryInfo dirInf = new DirectoryInfo(path);

            FileInfo[] FileArr = dirInf.GetFiles();
            ArtList<Artist> allArtists = new ArtList<Artist>();

            foreach (FileInfo fi in FileArr)
            {
                string PathToFile = path + "\\" + fi.Name;
                string inf = File.ReadAllText(PathToFile);
                string[] separator = new string[] { "\r\n" };
                string[] infArr = inf.Split(separator, StringSplitOptions.None);

                Artist newArtist = new Artist();
                newArtist.Name = infArr[0].Trim().Trim();
                newArtist.YearsOfLife = infArr[1].Trim().Trim();
                newArtist.Style = infArr[2].Trim().Trim();
                newArtist.Nation = infArr[3].Trim().Trim();
                newArtist.Photo = @path + @infArr[4];

                allArtists.Add(newArtist);
            }

            return allArtists;
        }

    }
}
