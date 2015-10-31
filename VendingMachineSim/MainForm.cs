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
        string name = "Name";
        string price = "Price";
        string quantity = "Quantity";
        string border = "------------------";
        string line;
        string[] tokens;
        StreamReader file;
        public MainForm()
        {
            InitializeComponent();
        }
        
        
        private void buttonLoadMachine_Click(object sender, EventArgs e)
        {        
            try
            {
                file = File.OpenText("JunkFood.csv");
                while (!file.EndOfStream)
                {
                    line = file.ReadLine();
                    tokens = line.Split(delim);
                    listBoxName.Items.Add(tokens[0]);
                    listBoxPrice.Items.Add(tokens[1]);
                    listBoxQuantity.Items.Add(tokens[2]);
                    //for (int i = 0; i < tokens.Length; i++)
                    //{
                    //    listBoxName.Items.Add(tokens[i]);
                    //    listBoxPrice.Items.Add(tokens[i + 1]);
                    //    listBoxQuantity.Items.Add(tokens[i + 2]);
                    //}
                    //for (int j = 1; j < tokens.Length; j++)
                    //{
                    //    listBoxPrice.Items.Add(tokens[j]);
                    //}
                    //for (int k = 2; k < tokens.Length; k++)
                    //{
                    //    listBoxQuantity.Items.Add(tokens[k]);
                    //}
                            
                        
                        
                    
                    //listBoxVending.Items.Add(line);
                    //listBoxName.Items.Add(border);
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
            listBoxName.Items.Add(name);
            listBoxName.Items.Add(border);
            listBoxPrice.Items.Add(price);
            listBoxPrice.Items.Add(border);
            listBoxQuantity.Items.Add(quantity);
            listBoxQuantity.Items.Add(border);
        }
    }
}
