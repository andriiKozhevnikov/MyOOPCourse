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
    public partial class ArtGuide : Form
    {
        ArtList<Picture> gallery;
        ArtList<Artist> artists;


        private void GatherInfo()
        {
            this.gallery = ArtList<Picture>.GatherPictures();
            this.artists = ArtList<Artist>.GatherArtists();
        }

        private void ShowMyCollection()
        {
            string path = Environment.CurrentDirectory;
            string str = "";
            for (int i = 0; i < path.Length - 10; i++ )
            {
                str += path[i];
            }
            path = @str + @"\Info\MyCollection";
            DirectoryInfo dirInf = new DirectoryInfo(path);

            FileInfo[] FileArr = dirInf.GetFiles();

            ListBox MyCollectionList = new ListBox();
            MyCollectionList.Location = new Point(12, 20);
            MyCollectionList.Size = new System.Drawing.Size(720, 400);
            MyCollectionList.Font = new Font("Palatino Linotype", 16);
            MainPanel.Controls.Add(MyCollectionList);


            foreach (FileInfo fi in FileArr)
            {
                MyCollectionList.Items.Add(File.ReadAllText(path + "\\" + fi.Name));
            }
        }

        private void FindPicture()
        {
            string pName = PictureSearchBox.Text.ToLower();
            PictureSearchBox.Text = "";
            int count = 0;
            int num = 0;

            for (int i = 0; i < gallery.Length; i++)
            {
                if (pName == gallery[i].Name.ToLower() )
                {
                    Picture pict = new Picture(gallery[i]);
                    ShowPicture(pict);
                    return;
                }
                if ( gallery[i].Name.ToLower().Contains(pName) )
                {
                    count++;
                    num = i;
                }
            }

            if (count == 1)
            {
                Picture pict = new Picture(gallery[num]);
                ShowPicture(pict);
                return;
            }
            if (count == 0)
            {
                MessageBox.Show("Nothis has found. \nWe don't have this picture or you have entered wrong name of the picture.");
            }
            if (count > 1)
            {
                MessageBox.Show("Found several examples. Please, enter full name of the picture.");
            }
        }

        private void ShowPicture(Picture p)
        {
            PictureBox pictBox = new PictureBox();
            pictBox.Size = new Size(470, 470);
            pictBox.Location = new Point(10, 10);
            pictBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictBox.ImageLocation = p.Path;
            MainPanel.Controls.Add(pictBox);

            Label infText = new Label();
            infText.Size = new Size(300, 200);
            infText.Location = new Point(500, 170);
            infText.Font = new Font("Palatino Linotype", 16);
            infText.ForeColor = Color.Black;
            infText.Text = "Name: " + p.Name + "\nArtist: " + p.Artist + "\nYear: " + p.Year + "\nStyle: " + p.Style;
            MainPanel.Controls.Add(infText);

            AddLabelWorkWithMyCollection(p);
        }

        private void AddLabelWorkWithMyCollection(Picture p)
        {
            Label workWithMyCollection = new Label();
            workWithMyCollection.Font = new Font("Tw Cen MT", 12);
            workWithMyCollection.Size = new Size(300, 200);
            workWithMyCollection.Location = new Point(500, 400);
            workWithMyCollection.ForeColor = Color.LightGreen;
            workWithMyCollection.Text = "Add to my collection";
            workWithMyCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            workWithMyCollection.Name = "workWithMyCollection";
            
            workWithMyCollection.Click += new EventHandler(this.workWithMyCollection_Click);
            MenuHiddenName.Text = p.Name + " - " + p.Artist;
            MenuHiddenText.Text = "n";
            MainPanel.Controls.Add(workWithMyCollection);

            string path = Environment.CurrentDirectory;
            string str = "";
            for (int i = 0; i < path.Length - 10; i++)
            {
                str += path[i];
            }
            path = @str + @"\Info\MyCollection";
            DirectoryInfo dirInf = new DirectoryInfo(path);

            FileInfo[] FileArr = dirInf.GetFiles();

            foreach (FileInfo fi in FileArr)
            {
                if (p.Name + " - " + p.Artist + ".txt" == fi.Name)
                {
                    workWithMyCollection.Text = "Delete from my collection";
                    workWithMyCollection.ForeColor = Color.Coral;
                    MenuHiddenText.Text = "y";
                    break;
                }
            }
        }

        private void ProcessButtonWorkWithMyCollection()
        {
            if (MenuHiddenText.Text == "n")                
            {
                AddToMyCollection();
            }
            if (MenuHiddenText.Text == "y")
            {
                DeleteFromMyCollectiom();
            }
        }

        private void AddToMyCollection()
        {
            string Name = MenuHiddenName.Text;
            string path = Environment.CurrentDirectory;
            string str = "";
            for (int i = 0; i < path.Length - 10; i++)
            {
                str += path[i];
            }
            path = @str + @"\Info\MyCollection";

            System.IO.File.WriteAllText(path + "\\" + Name + ".txt", Name);            
        }

        private void DeleteFromMyCollectiom()
        {
            string Name = MenuHiddenName.Text;
            string path = Environment.CurrentDirectory;
            string str = "";
            for (int i = 0; i < path.Length - 10; i++)
            {
                str += path[i];
            }
            path = @str + @"\Info\MyCollection";

            System.IO.File.Delete(path + "\\" + Name + ".txt");
        }

        private void FindArtist()
        {
            string aName = ArtistSearchBox.Text.ToLower();
            ArtistSearchBox.Text = "";
            int count = 0;
            int num = 0;

            for (int i = 0; i < artists.Length; i++)
            {
                if (aName == artists[i].Name.ToLower())
                {
                    Artist artst = new Artist(artists[i]);
                    ShowArtist(artst);
                    return;
                }
                if (artists[i].Name.ToLower().Contains(aName))
                {
                    count++;
                    num = i;
                }
            }

            if (count == 1)
            {
                Artist artst = new Artist(artists[num]);
                ShowArtist(artst);
                return;
            }
            if (count == 0)
            {
                MessageBox.Show("Nothis has found. \nWe don't have this artist or you have entered wrong name of the artist.");
            }
            if (count > 1)
            {
                MessageBox.Show("Found several people. Please, enter full name of the artist.");
            }
        }

        private void ShowArtist(Artist artst)
        {
            PictureBox pictBox = new PictureBox();
            pictBox.Size = new Size(470, 470);
            pictBox.Location = new Point(10, 10);
            pictBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictBox.ImageLocation = artst.Photo;
            MainPanel.Controls.Add(pictBox);

            Label infText = new Label();
            infText.Size = new Size(300, 200);
            infText.Location = new Point(500, 170);
            infText.Font = new Font("Palatino Linotype", 16);
            infText.ForeColor = Color.Black;
            infText.Text = "Name: " + artst.Name + "\nYears of life: " + artst.YearsOfLife + "\nStyle: " + artst.Style + "\nNation: " + artst.Nation;
            MainPanel.Controls.Add(infText);
        }

        private void ViewAllPictures()
        {
            ListBox PicturesList = new ListBox();
            PicturesList.Location = new Point(12, 20);
            PicturesList.Size = new System.Drawing.Size(720, 400);
            PicturesList.Font = new Font("Palatino Linotype", 16);
            MainPanel.Controls.Add(PicturesList);


            for (int i = 0; i < gallery.Length; i++)
            {
                PicturesList.Items.Add(gallery[i].Name + " - " + gallery[i].Artist);
            }

            
        }

        private void ViewAllArtists()
        {
            ListBox ArtistsList = new ListBox();
            ArtistsList.Location = new Point(12, 20);
            ArtistsList.Size = new System.Drawing.Size(720, 400);
            ArtistsList.Font = new Font("Palatino Linotype", 16);
            MainPanel.Controls.Add(ArtistsList);


            for (int i = 0; i < artists.Length; i++)
            {
                ArtistsList.Items.Add(artists[i].Name + " - " + artists[i].YearsOfLife);
            }
        }
    }
}
