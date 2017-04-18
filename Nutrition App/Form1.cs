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

namespace Nutrition_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\dnshe\Documents\Nutrition.txt";
            if (File.Exists(path))
            {
                string itemName = txtbxSearch.Text;
                List<string> itemNames = new List<string>();
                if (itemName == "all")
                {
                    foreach (string line in File.ReadAllLines(path))
                    {
                        itemNames.Add(line);
                    }
                }
                else
                {
                    foreach (string line in File.ReadAllLines(path))
                    {
                        if (line.Contains(itemName))
                        {
                            itemNames.Add(line);
                        }
                    }

                }

                txtbxResults.Text = itemNames.Count + " item(s) found!\r\n\r\n";

                foreach (object o in itemNames)
                {
                    txtbxResults.Text += o.ToString() + "\r\n";
                    lstbxResults.Items.Add(o.ToString());
                }
            }

            else
            {
                MessageBox.Show("No file found!\r\n\r\nAdd an entry to create a new file.", "Error");
            }
        } 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\dnshe\Documents\Nutrition.txt";
            StreamWriter sw;

            string itemName = txtbxAdd.Text;
            string carbs = txtbxCarbs.Text;

            if (!File.Exists(path))
            {
                using (sw = File.CreateText(path))
                {
                    sw.WriteLine(itemName + " " + carbs);
                }
            }
            else
            {
                using (sw = File.AppendText(path))
                {
                    sw.WriteLine(itemName + " " + carbs);
                }
            }

            sw.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\dnshe\Documents\Nutrition.txt";

            if (File.Exists(path))
            {
                string fullItem = lstbxResults.SelectedItem.ToString();
                List<string> itemNames = new List<string>();

                foreach (string line in File.ReadAllLines(path))
                {
                    if (!line.Contains(fullItem))
                    {
                        itemNames.Add(line);
                    }
                }

                File.Delete(path);

                StreamWriter sw = new StreamWriter(path);

                using (sw = File.CreateText(path))
                {
                    sw.WriteLine(fullItem);
                }

                sw.Close();
            }

            else
            {
                MessageBox.Show("No file found!\r\n\r\nAdd an entry to create a new file.", "Error");
            }
        }

    }
}
