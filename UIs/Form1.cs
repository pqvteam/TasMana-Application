using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-SM9GFST3\SQLEXPRESS;Initial Catalog=TasMana;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select file to be upload";
            //fDialog.Filter = "PDF Files|*.pdf|All Files|*.*";
            fDialog.Filter = "PDF Files|*.pdf";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fDialog.FileName.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        void LoadGrid()
        {
            dataGridView1.Columns.Clear();
            sqlcon.Open();
            sqlcmd = new SqlCommand("select maGiaoViec from GiaoViec where maGiaoViec='GD-001.002'", sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            dt = new DataTable();
            da.Fill(dt);
            sqlcon.Close();
            if (dt.Rows.Count > 0)
            {
                DataGridViewLinkColumn links = new DataGridViewLinkColumn();
                links.UseColumnTextForLinkValue = true;
                links.HeaderText = "Download";
                links.DataPropertyName = "lnkColumn";
                links.ActiveLinkColor = Color.White;
                links.LinkBehavior = LinkBehavior.SystemDefault;
                links.LinkColor = Color.Blue;
                links.Text = "Click here";
                links.TrackVisitedState = true;
                links.VisitedLinkColor = Color.YellowGreen;
                dataGridView1.Columns.Add(links);
                dataGridView1.DataSource = dt;

                dataGridView1.AutoResizeColumns();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filetype;
            string filename;

            filetype = textBox1.Text.Substring(Convert.ToInt32(textBox1.Text.LastIndexOf(".")) + 1, textBox1.Text.Length - (Convert.ToInt32(textBox1.Text.LastIndexOf(".")) + 1));

            //Validate user upload only specific bytes - un comment below lines if you need to validate only PDF files

            if (filetype.ToUpper() != "PDF")
            {
                MessageBox.Show("Upload Only PDF Files");
                return;
            }

            byte[] FileBytes = null;

            try
            {
                // Open file to read using file path
                FileStream FS = new FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                // Add filestream to binary reader
                BinaryReader BR = new BinaryReader(FS);

                // get total byte length of the file
                long allbytes = new FileInfo(textBox1.Text).Length;

                // read entire file into buffer
                FileBytes = BR.ReadBytes((Int32)allbytes);

                // close all instances
                FS.Close();
                FS.Dispose();
                BR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during File Read " + ex.ToString());
            }

            //Store File Bytes in database image filed 

            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("update GiaoViec set dinhKemFile = @FB where maGiaoViec = 'KT-501.002'", sqlcon);
            sqlcmd.Parameters.AddWithValue("@FB", FileBytes);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            LoadGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string id;
                FileStream FS = null;
                byte[] dbbyte;

                sqlcon.Open();
                sqlcmd = new SqlCommand("select dinhKemFile from GiaoViec where maGiaoViec = 'AN-402.001'", sqlcon);
                da = new SqlDataAdapter(sqlcmd);
                dt = new DataTable();
                da.Fill(dt);
                sqlcon.Close();


                if (dt.Rows.Count > 0)
                {
                    dbbyte = (byte[])dt.Rows[0]["dinhKemFile"];

                    string filepath = "D:\\temp.pdf";

                    File.WriteAllBytes(filepath, dbbyte);

                    Process.Start("explorer", filepath);
                }
            }
        }

    }
}
