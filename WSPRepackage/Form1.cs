using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Deployment.Compression.Cab;
using Microsoft.Deployment.Compression;
using System.IO;
using System.Diagnostics;


namespace WSPRepackage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void btn_src_Click(object sender, EventArgs e)
        {
            
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_source.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_dir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_output.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_repackage_Click(object sender, EventArgs e)
        {
            try
            {
                CabInfo cab = new CabInfo(txt_output.Text + "\\" + txt_wspname.Text + ".wsp");
                cab.Pack(txt_source.Text, true, Microsoft.Deployment.Compression.CompressionLevel.Max, null);
                MessageBox.Show(String.Format("WSP created successfully")); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("An error as ocurred :(")); 
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://handsonsharepoint.net/");
        }
       
    }   
}
