﻿using Repositories.Entities;
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
                    MessageBox.Show("Please select a member first.");
                }
            }
        }
    }
}