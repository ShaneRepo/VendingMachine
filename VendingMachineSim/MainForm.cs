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
    }
}
