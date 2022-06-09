using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasswaveMusicPlayerNet
{
    public partial class BasswaveMusicPlayer : Form
    {
        public BasswaveMusicPlayer()
        {
            InitializeComponent();
        }

        //Save music titles
        String[] paths, files;


        // Select Song
        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            
            //Select multiple files
            dlg.Multiselect = true;

            //save names and paths in array, display songs in list
            if (dlg.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = dlg.SafeFileNames;
                paths = dlg.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    SongsList.Items.Add(files[i]);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



        //play music
        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[SongsList.SelectedIndex];
        }

        // close app
        private void pictureBox1_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
