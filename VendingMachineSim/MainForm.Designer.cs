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
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.listBoxQuantity = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(217, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(288, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Vending Machine Simulator";
            // 
            // listBoxName
            // 
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.Location = new System.Drawing.Point(210, 144);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(161, 95);
            this.listBoxName.TabIndex = 1;
            // 
            // buttonLoadMachine
            // 
            this.buttonLoadMachine.Location = new System.Drawing.Point(53, 144);
            this.buttonLoadMachine.Name = "buttonLoadMachine";
            this.buttonLoadMachine.Size = new System.Drawing.Size(127, 23);
            this.buttonLoadMachine.TabIndex = 2;
            this.buttonLoadMachine.Text = "Display Items For Sale";
            this.buttonLoadMachine.UseVisualStyleBackColor = true;
            this.buttonLoadMachine.Click += new System.EventHandler(this.buttonLoadMachine_Click);
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.Location = new System.Drawing.Point(384, 144);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(146, 95);
            this.listBoxPrice.TabIndex = 3;
            // 
            // listBoxQuantity
            // 
            this.listBoxQuantity.FormattingEnabled = true;
            this.listBoxQuantity.Location = new System.Drawing.Point(543, 144);
            this.listBoxQuantity.Name = "listBoxQuantity";
            this.listBoxQuantity.Size = new System.Drawing.Size(146, 95);
            this.listBoxQuantity.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 628);
            this.Controls.Add(this.listBoxQuantity);
            this.Controls.Add(this.listBoxPrice);
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
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.ListBox listBoxQuantity;
    }
}

