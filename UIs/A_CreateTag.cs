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
                showToast("SUCCESS", "Create tag successfully");

                nameBox.Clear();
                descriptionBox.Clear();
                nameBox.Focus();
                reload();
            }
            else
            {
                showToast("ERROR", "An Error Occur");

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

            changelanguage();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (Session.Instance.Language == "vi")
            {
                customButton10.Text = "TẠO MÃ CÔNG VIỆC";
                customButton10.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                label3.Text = "MÃ CÔNG VIỆC HIỆN TẠI";
                label2.Text = "TÊN CÔNG VIỆC";
                label1.Text = "MÔ TẢ";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                cancelButton.Text = "HỦY";
                saveButton.Text = "LƯU";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            }
            else
            {
                customButton10.Text = "CREATE TAG";
                customButton10.Font = new Font("Copperplate Gothic Bold", 14);

                label3.Text = "CURRENT TAG";
                label2.Text = "NAME";
                label1.Text = "DESCRIPTION";
                font = new Font("Copperplate Gothic Bold", 10);

                cancelButton.Text = "CANCEL";
                saveButton.Text = "SAVE";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);
            }
            label3.Font = font;
            label2.Font = font;
            label1.Font = font;

            cancelButton.Font = fontSmaller;
            saveButton.Font = fontSmaller;
        }
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
        }
    }
}
