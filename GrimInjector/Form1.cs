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
using KrnlAPI;

namespace GrimInjector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void executebutton_Click(object sender, EventArgs e)
        {
            MainAPI.Execute(scriptarea.Text);
        }

        private void erasebutton_Click(object sender, EventArgs e)
        {
            scriptarea.Text = "-- Grim Injector";
        }

        private void openbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            {
                dialog.Filter = "All Files (.*)|*.*";
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                scriptarea.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            {
                dialog.Filter = "Text (^.txt)|^.txt|Lua (^.lua)|^.lua|All Files (^.^)|^.^";
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(dialog.FileName))
                {
                    File.Create(dialog.FileName).Close();
                    File.WriteAllText(dialog.FileName, dialog.FileName);
                }
                else
                {
                    File.WriteAllText(dialog.FileName, scriptarea.Text);
                }
            }
        }

        private void injectbutton_Click(object sender, EventArgs e)
        {
            MainAPI.Inject();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
