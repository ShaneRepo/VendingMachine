namespace VendingMachineSim
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.buttonLoadMachine = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(99, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(288, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Vending Machine Simulator";
            // 
            // listBoxName
            // 
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.Location = new System.Drawing.Point(30, 99);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(161, 95);
            this.listBoxName.TabIndex = 1;
            this.listBoxName.SelectedIndexChanged += new System.EventHandler(this.listBoxName_SelectedIndexChanged);
            // 
            // buttonLoadMachine
            // 
            this.buttonLoadMachine.Location = new System.Drawing.Point(46, 225);
            this.buttonLoadMachine.Name = "buttonLoadMachine";
            this.buttonLoadMachine.Size = new System.Drawing.Size(127, 23);
            this.buttonLoadMachine.TabIndex = 2;
            this.buttonLoadMachine.Text = "Display Items For Sale";
            this.buttonLoadMachine.UseVisualStyleBackColor = true;
            this.buttonLoadMachine.Click += new System.EventHandler(this.buttonLoadMachine_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(212, 136);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // textBoxQty
            // 
            this.textBoxQty.Location = new System.Drawing.Point(350, 136);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(100, 20);
            this.textBoxQty.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vending Machine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(212, 225);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(100, 23);
            this.buttonPurchase.TabIndex = 8;
            this.buttonPurchase.Text = "Purchase Product";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(350, 225);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel Purchase";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(553, 304);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonLoadMachine);
            this.Controls.Add(this.listBoxName);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm";
            this.Text = "Vending Machine Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.Button buttonLoadMachine;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Button buttonCancel;
    }
}

