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
        Boolean isOn = false;
        char[] delim = { ',' };     
        string line;
        string[] tokens;
        StreamReader file;
        public MainForm()
        {
            InitializeComponent();
        }
        // lists to hold data
        List <string> name = new List<string>();
        List<string> price = new List<string>();
        List<string> qty = new List<string>();
        
        private void buttonLoadMachine_Click(object sender, EventArgs e)
        {  
            if (isOn == true) // check if machine is loaded already
            {
                // inform user machine is loaded and exit event handler
                MessageBox.Show("The machine is already on!");
                return;
            }
            try
            {
                file = File.OpenText("JunkFood.csv");
                while (!file.EndOfStream)
                {
                    // read the junkfood csv file
                    line = file.ReadLine();
                    // tokenize the csv file
                    tokens = line.Split(delim);
                    // add product name to string list
                    name.Add(tokens[0]);
                    // add product price to string list
                    price.Add(tokens[1]);
                    // add product quantity  to string list
                    qty.Add(tokens[2]);
                                                       
                }
                foreach (string list in name)
                {
                    listBoxName.Items.Add(list).ToString(); // add names to listbox
                }
                isOn = true; // flag set to true if machine is loaded
            }                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                file.Close(); // close file
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void listBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {         // switch statement to determine price and qty
            double curr;
            int many = 0;
            int index = listBoxName.SelectedIndex;
            switch(index)
            {
                case 0:
                    {
                        curr = double.Parse(price[0]);
                        textBoxPrice.Text = curr.ToString("C");
                        many = int.Parse(qty[0]);
                        textBoxQty.Text = many.ToString();
                        break;
                    }
                case 1:
                    {
                        curr = double.Parse(price[1]);
                        textBoxPrice.Text = curr.ToString("C");
                        many = int.Parse(qty[1]);
                        textBoxQty.Text = many.ToString();
                        break;
                    }
                case 2:
                    {
                        curr = double.Parse(price[2]);
                        textBoxPrice.Text = curr.ToString("C");
                        many = int.Parse(qty[2]);
                        textBoxQty.Text = many.ToString();
                        break;
                    }
                case 3:
                    {
                        curr = double.Parse(price[3]);
                        textBoxPrice.Text = curr.ToString("C");
                        many = int.Parse(qty[3]);
                        textBoxQty.Text = many.ToString();
                        break;
                    }
                case 4:
                    {
                        curr = double.Parse(price[4]);
                        textBoxPrice.Text = curr.ToString("C");
                        many = int.Parse(qty[4]);
                        textBoxQty.Text = many.ToString();
                        break;
                    }
                case 5:
                    {
                        curr = double.Parse(price[5]);
                        textBoxPrice.Text = curr.ToString("C");
                        many = int.Parse(qty[5]);
                        textBoxQty.Text = many.ToString();
                        break;
                    }
                case 6:
                    {
                        curr = double.Parse(price[6]);
                        textBoxPrice.Text = curr.ToString("C");
                        many = int.Parse(qty[6]);
                        textBoxQty.Text = many.ToString();
                        break;
                    }
                case 7:
                    {
                        curr = double.Parse(price[7]);
                        textBoxPrice.Text = curr.ToString("C");
                        many = int.Parse(qty[7]);
                        textBoxQty.Text = many.ToString();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Select an item to see how much it costs.");
                        break;
                    }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you, come again :) .");
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            if (listBoxName.SelectedIndex != -1)
            {
                MessageBox.Show("Thank you for your purchase.");
            }
            else
            {
                MessageBox.Show("Select an item to see how much it costs.");
                return;
            }
        }
    }
}
