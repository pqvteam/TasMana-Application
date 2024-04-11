using Microsoft.Data.SqlClient;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class A_CreateTag : Form
    {
        TagService tagService = new TagService();
        public A_CreateTag()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string description = descriptionBox.Text;
            bool isSuccess = tagService.createNewTab(name, description);
            if (isSuccess)
            {
                MessageBox.Show("Create tag successfully");
                nameBox.Clear();
                descriptionBox.Clear();
                nameBox.Focus();
                reload();
            }
            else
            {
                MessageBox.Show("Something wrong when create tag");
                MessageBox.Show(nameBox.Text);
                MessageBox.Show(descriptionBox.Text);
            }
        }

        private void tagsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reload()
        {
            tagsGrid.Rows.Clear();
            List<(string name, string taskID, string description)> tags = tagService.getAllTag();
            foreach ((string name, string taskID, string description) tag in tags)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(tagsGrid);
                row.Cells[0].Value = tag.name;
                row.Cells[1].Value = tag.description;
                tagsGrid.Rows.Add(row);
            }
            nameBox.Focus();
        }

        private void A_CreateTag_Load(object sender, EventArgs e)
        {
            tagsGrid.Columns.Add("Tag", "Tag");
            tagsGrid.Columns.Add("Description", "Description");
            reload();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
