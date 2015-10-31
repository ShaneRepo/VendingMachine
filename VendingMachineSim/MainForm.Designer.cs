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
            this.listBoxVending = new System.Windows.Forms.ListBox();
            this.buttonLoadMachine = new System.Windows.Forms.Button();
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
            // listBoxVending
            // 
            this.listBoxVending.FormattingEnabled = true;
            this.listBoxVending.Location = new System.Drawing.Point(341, 144);
            this.listBoxVending.Name = "listBoxVending";
            this.listBoxVending.Size = new System.Drawing.Size(120, 95);
            this.listBoxVending.TabIndex = 1;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 628);
            this.Controls.Add(this.buttonLoadMachine);
            this.Controls.Add(this.listBoxVending);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm";
            this.Text = "Vending Machine Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxVending;
        private System.Windows.Forms.Button buttonLoadMachine;
    }
}

