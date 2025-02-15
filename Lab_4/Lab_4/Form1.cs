﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        List<Cosmetic> cosmeticsList = new List<Cosmetic>();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            DatabaseHelper.InitializeDatabase();
            LoadData();
        }

        private void LoadData()
        {
            cosmeticsList = DatabaseHelper.GetCosmetics();
            dgvCosmetics.DataSource = null;
            dgvCosmetics.DataSource = cosmeticsList;
        }

        private void InitializeDataGridView()
        {
            dgvCosmetics.AutoGenerateColumns = false;

            dgvCosmetics.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Type",
                HeaderText = "Вид",
                Name = "TypeColumn"
            });

            dgvCosmetics.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Brand",
                HeaderText = "Марка",
                Name = "BrandColumn"
            });

            dgvCosmetics.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Manufacturer",
                HeaderText = "Виробник",
                Name = "ManufacturerColumn"
            });

            dgvCosmetics.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExpiryDate",
                HeaderText = "Термін придатності",
                Name = "ExpiryDateColumn"
            });

            dgvCosmetics.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Ціна",
                Name = "PriceColumn"
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtType.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text) ||
                string.IsNullOrWhiteSpace(txtManufacturer.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Будь ласка, введіть коректну ціну.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cosmetic cosmetic = new Cosmetic
            {
                Type = txtType.Text,
                Brand = txtBrand.Text,
                Manufacturer = txtManufacturer.Text,
                ExpiryDate = dtpExpiryDate.Value,
                Price = price
            };

            cosmeticsList.Add(cosmetic);
            dgvCosmetics.DataSource = null;
            dgvCosmetics.DataSource = cosmeticsList;

            // Зберегти косметику в базу даних
            DatabaseHelper.AddCosmetic(cosmetic);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCosmetics.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть рядок для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedCosmetic = (Cosmetic)dgvCosmetics.SelectedRows[0].DataBoundItem;
            cosmeticsList.Remove(selectedCosmetic);
            dgvCosmetics.DataSource = null;
            dgvCosmetics.DataSource = cosmeticsList;

            // Видалити косметику з бази даних
            DatabaseHelper.DeleteCosmetic(selectedCosmetic);
        }

        private void lblBrand_Click(object sender, EventArgs e)
        {
            // Обробник подій для lblBrand
        }
    }

    public class Cosmetic
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
    }
}
