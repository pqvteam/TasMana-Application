using Repositories.Entities;
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
    public partial class A_ShowVenue : Form
    {
        private string selectedVenueID = "";
        public event Action<string> VenueSelected;

        private void venuesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string venueId = venuesGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                selectedVenueID = venueId;
            }
        }

        public A_ShowVenue()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customButton10_Click(object sender, EventArgs e)
        {

        }

        private void A_ShowVenue_Load(object sender, EventArgs e)
        {
            changelanguage();
            CanHoService canHoService = new CanHoService();
            List<CanHo> apartments = canHoService.getAllApartments();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Location", typeof(string));
            dataTable.Columns.Add("User ID", typeof(string));

            foreach (CanHo apartment in apartments)
            {
                dataTable.Rows.Add(apartment.MaCh, apartment.ViTri, apartment.ViTri, apartment.MaCuDan);
            }

            venuesGrid.DataSource = dataTable;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(selectedVenueID))
                {
                    VenueSelected?.Invoke(selectedVenueID);
                    this.Close();
                }
                else
                {
                    showToast("WARNING", "Please select a member first.");

                }
            }
        }

        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (Session.Instance.Language == "vi")
            {
                customButton10.Text = "KHU VỰC LÀM VIỆC";
                customButton10.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                cancelButton.Text = "HỦY";
                saveButton.Text = "LƯU";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            }
            else
            {
                customButton10.Text = "WORKPLACE";
                customButton10.Font = new Font("Copperplate Gothic Bold", 14);

                cancelButton.Text = "CANCEL";
                saveButton.Text = "SAVE";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);
            }

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
