using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Xml.Linq;
using SimpleDBProject.Models;

namespace SimpleDBProject
{
    public partial class Form1 : Form
    {
        int establishmentId = 1;
        public Form1()
        {
            InitializeComponent();
        }

        public void ReadAdressFile()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\GodOfWar\Desktop\db.sql");

            text = text.Replace("\n", "");
            text = text.Replace("'", "");
            string[] CRC = text.Split(new string[] { "INSERT INTO" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < CRC.Length; i++)
            {
                CRC[i] = CRC[i].Split(new string[] { "VALUES" }, StringSplitOptions.RemoveEmptyEntries)[1];
            }

            using (var context = new EstablishmentContext())
            {
                string[] cities = CRC[0].Split(new string[] { ")," }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < cities.Length; i++)
                {
                    string[] element = cities[i].Split(new string[] { "," }, StringSplitOptions.None);
                    element[0] = element[0].Replace("(", "");
                    City city = new City()
                    {
                        Id_City = int.Parse(element[0].Replace(" ", "")),
                        Id_Region = int.Parse(element[1].Replace(" ", "")),
                        Id_Country = int.Parse(element[2].Replace(" ", "")),
                        Name = element[3] != "" ? element[3] : "--"
                    };
                    context.Cityes.Add(city);
                }
                string[] countries = CRC[1].Split(new string[] { ")," }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < countries.Length; i++)
                {
                    string[] element = countries[i].Split(new string[] { "," }, StringSplitOptions.None);
                    element[0] = element[0].Replace("(", "");
                    Countrie countrie = new Countrie()
                    {
                        Id_Country = int.Parse(element[0].Replace(" ", "")),
                        Name = element[1] != "" ? element[1] : "--"
                    };
                    context.Countries.Add(countrie);
                }
                string[] regions = CRC[2].Split(new string[] { ")," }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < regions.Length; i++)
                {
                    string[] element = regions[i].Split(new string[] { "," }, StringSplitOptions.None);
                    element[0] = element[0].Replace("(", "");
                    Region region = new Region()
                    {
                        Id_Region = int.Parse(element[0].Replace(" ", "")),
                        Id_Country = int.Parse(element[1].Replace(" ", "")),
                        Name = element[2] != "" ? element[2] : "--"
                    };
                    context.Regions.Add(region);
                }
                context.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCountryes.Items.Clear();
            using (var context = new EstablishmentContext())
            {
                string[] countries = (from c in context.Countries
                                      select c.Name).ToArray();
                comboBoxCountryes.Items.AddRange(countries);
                comboBoxCountryes.SelectedIndex = 0;
                DataGridViewEstablishment_Refresh(context);
                DataGridViewRoom_Refresh(context, establishmentId);
            }
            comboBoxEstablishmentType.SelectedIndex = 0;
        }

        private void comboBoxCountryes_TextChanged(object sender, EventArgs e)
        {
            comboBoxRegions.Items.Clear();
            using (var context = new EstablishmentContext())
            {
                int id_country = (from c in context.Countries
                                  where c.Name == comboBoxCountryes.SelectedItem.ToString()
                                   select c.Id_Country).ToArray()[0];
                string[] regions = (from r in context.Regions
                                    where r.Id_Country == id_country
                                    orderby r.Name
                                    select r.Name).ToArray();
                comboBoxRegions.Items.AddRange(regions);
                comboBoxRegions.SelectedIndex = 0;
            }
        }

        private void comboBoxRegions_TextChanged(object sender, EventArgs e)
        {
            comboBoxCities.Items.Clear();
            using (var context = new EstablishmentContext())
            {
                int id_country = (from c in context.Countries
                                  where c.Name == comboBoxCountryes.SelectedItem.ToString()
                                  select c.Id_Country).ToArray()[0];
                int id_region = (from r in context.Regions
                                  where r.Name == comboBoxRegions.SelectedItem.ToString()
                                  select r.Id_Region).ToArray()[0];
                string[] cities = (from ct in context.Cityes
                                    where ct.Id_Country == id_country
                                   where ct.Id_Region== id_region
                                   orderby ct.Name
                                    select ct.Name).ToArray();
                comboBoxCities.Items.AddRange(cities);
                comboBoxCities.SelectedIndex = 0;
            }
        }

        private void buttonAddEstablishment_Click(object sender, EventArgs e)
        {
            using (var context = new EstablishmentContext())
            {
                using(var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (textBoxEstablishmentName.Text == "" ||
                            comboBoxEstablishmentType.SelectedIndex == -1 ||
                            comboBoxCities.SelectedIndex == -1 ||
                            textBoxAdress.Text == "")
                            throw new Exception();
                        int number,length;
                        if ((length = context.Establishments.ToArray().Length) == 0)
                            number = 0;
                        else 
                            number = context.Establishments.ToArray()[length - 1].Number;

                        Establishment establishment = new Establishment()
                        {
                            Number = number + 1,
                            EstablishmentName = textBoxEstablishmentName.Text,
                            EstablishmentType = comboBoxEstablishmentType.SelectedItem.ToString(),
                            EstablishmentAdress = "м." + comboBoxCities.SelectedItem.ToString() + 
                            " " + textBoxAdress.Text,
                        };
                        context.Establishments.Add(establishment);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                    DataGridViewEstablishment_Refresh(context);
                }
            }
        }

        private void dataGridViewEstablishment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new EstablishmentContext())
            {
                establishmentId = (int)dataGridViewEstablishment[0, e.RowIndex].Value;
                dataGridViewEstablishment.Rows[e.RowIndex].Selected = !dataGridViewEstablishment.Rows[e.RowIndex].Selected;
                DataGridViewRoom_Refresh(context, establishmentId);
            }
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            using (var context = new EstablishmentContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        int placeCount, area;
                        if (textBox3.Text == "" ||
                            (!int.TryParse(textBox1.Text, out placeCount) && textBox1.Text == "") ||
                            !int.TryParse(textBox2.Text, out area))
                            throw new Exception();
                        int number, length;
                        if ((length = context.Rooms.ToArray().Length) == 0)
                            number = 0;
                        else
                            number = context.Rooms.ToArray()[length - 1].RoomId;

                        Room room = new Room()
                        {
                            RoomId = number + 1,
                            EstablishmentId = establishmentId,
                            RoomType = textBox3.Text,
                            PlaceCount = placeCount ,
                            Area = area
                        };
                        context.Rooms.Add(room);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                    DataGridViewRoom_Refresh(context, establishmentId);
                }
            }
        }

        private void DataGridViewEstablishment_Refresh(EstablishmentContext context)
        {
            dataGridViewEstablishment.DataSource = (from e in context.Establishments
                                                    select new
                                                    {
                                                        e.Number,
                                                        e.EstablishmentName,
                                                        e.EstablishmentType,
                                                        e.EstablishmentAdress,
                                                    }).ToList();
            dataGridViewEstablishment.Columns[0].HeaderText = "Номер";
            dataGridViewEstablishment.Columns[1].HeaderText = "Назва закладу";
            dataGridViewEstablishment.Columns[2].HeaderText = "Тип закладу";
            dataGridViewEstablishment.Columns[3].HeaderText = "Адреса";
            dataGridViewEstablishment.Columns[0].Width = 30;
            dataGridViewEstablishment.Columns[1].Width = 200;
            dataGridViewEstablishment.Columns[2].Width = 180;
            dataGridViewEstablishment.Columns[3].Width = 245;
            dataGridViewEstablishment.Refresh();
        }

        private void DataGridViewRoom_Refresh(EstablishmentContext context, int establishmentId)
        {
            dataGridViewRoom.DataSource = (from r in context.Rooms
                                           where r.EstablishmentId == establishmentId
                                           select new
                                           {
                                               r.RoomType,
                                               r.PlaceCount,
                                               r.Area
                                           }).ToList();
            dataGridViewRoom.Columns[0].HeaderText = "Тип приміщення";
            dataGridViewRoom.Columns[1].HeaderText = "К-сть місць";
            dataGridViewRoom.Columns[2].HeaderText = "Площа";
            dataGridViewRoom.Columns[0].Width = 520;
            dataGridViewRoom.Columns[1].Width = 100;
            dataGridViewRoom.Columns[2].Width = 45;
            dataGridViewRoom.Refresh();
        }

        private void buttonRemoveEstablishment_Click(object sender, EventArgs e)
        {
            using (var context = new EstablishmentContext())
            {
                var establishments = (from es in context.Establishments
                                     where es.Number == establishmentId
                                     select es).ToArray();
                if (establishments.Length == 0)
                    return;
                Establishment establishment = establishments[0];
                context.Establishments.Remove(establishment);
                context.SaveChanges();
                DataGridViewEstablishment_Refresh(context);
            }
        }

        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoom.SelectedRows.Count == 0)
                return;
            using (var context = new EstablishmentContext())
            {
                string roomType = dataGridViewRoom.SelectedRows[0].Cells[0].Value.ToString();
                var rooms = (from r in context.Rooms
                             where r.RoomType == roomType
                             select r).ToArray();
                if (rooms.Length == 0)
                    return;
                Room room = rooms[0];
                context.Rooms.Remove(room);
                context.SaveChanges();
                DataGridViewRoom_Refresh(context,establishmentId);
            }
        }

        private void dataGridViewRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewRoom.Rows[e.RowIndex].Selected = !dataGridViewRoom.Rows[e.RowIndex].Selected;
        }
    }
}
