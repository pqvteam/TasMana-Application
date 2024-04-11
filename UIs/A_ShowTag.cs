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
    public partial class A_ShowTag : Form
    {
        private string tagName = "";
        public event Action<string> TagSelected;
        TagService tagService = new TagService();
        public A_ShowTag()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            A_CreateTag tag = new A_CreateTag();
            this.Hide();
            tag.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void A_ShowTag_Load(object sender, EventArgs e)
        {
            tagsGrid.Columns.Add("Tag", "Tag");
            tagsGrid.Columns.Add("Description", "Description");
            reload();
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
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tagName))
            {
                TagSelected?.Invoke(tagName);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a member first.");
            }
        }

        private void membersGrid_RowContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tagName = tagsGrid.Rows[e.RowIndex].Cells["Tag"].Value.ToString();
            }
        }
    }
}
