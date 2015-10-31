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

namespace VendingMachineSim
{
    public partial class MainForm : Form
    {
        char[] delim = { ',' };
        //string name = "Name";
        //string price = "Price";
        //string quantity = "Quantity";
        string border = "------------------";
        string line;
        string[] tokens;
        StreamReader file;
        public MainForm()
        {
            InitializeComponent();
        }
        List <string> name = new List<string>();
        List<string> price = new List<string>();
        List<string> qty = new List<string>();
        
        private void buttonLoadMachine_Click(object sender, EventArgs e)
        {        
            try
            {
                file = File.OpenText("JunkFood.csv");
                while (!file.EndOfStream)
                {
                    line = file.ReadLine();
                    tokens = line.Split(delim);
                    name.Add(tokens[0]);
                    price.Add(tokens[1]);
                    qty.Add(tokens[2]);
                                                       
                }
                foreach (string list in name)
                {
                    listBoxName.Items.Add(list).ToString();
                }  
            }                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                file.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //listBoxName.Items.Add(name);
            //listBoxName.Items.Add(border);
            //listBoxPrice.Items.Add(price);
            //listBoxPrice.Items.Add(border);
            //listBoxQuantity.Items.Add(quantity);
            //listBoxQuantity.Items.Add(border);
        }

        private void listBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int name = 0;
            //int price = 0;
            double curr;
            int many = 0;
            int index = listBoxName.SelectedIndex;
            switch(index)
            {
                case 0:
                    {
                        curr = double.Parse(price[0]);
                        textBox1.Text = curr.ToString("C");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Select an item to see how much it costs.");
                        break;
                    }
            }

        }
    }
}
