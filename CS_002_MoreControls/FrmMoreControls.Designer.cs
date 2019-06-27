namespace CS_002_MoreControls
{
    partial class FrmMoreControls
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.hsbNumber = new System.Windows.Forms.HScrollBar();
            this.mnuColors = new System.Windows.Forms.MenuStrip();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGoToSecondForm = new System.Windows.Forms.Button();
            this.mnuColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(355, 42);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(329, 20);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // hsbNumber
            // 
            this.hsbNumber.LargeChange = 1;
            this.hsbNumber.Location = new System.Drawing.Point(9, 401);
            this.hsbNumber.Maximum = 50;
            this.hsbNumber.Name = "hsbNumber";
            this.hsbNumber.Size = new System.Drawing.Size(300, 40);
            this.hsbNumber.TabIndex = 1;
            this.hsbNumber.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbNumber_Scroll);
            // 
            // mnuColors
            // 
            this.mnuColors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem});
            this.mnuColors.Location = new System.Drawing.Point(0, 0);
            this.mnuColors.Name = "mnuColors";
            this.mnuColors.Size = new System.Drawing.Size(800, 24);
            this.mnuColors.TabIndex = 2;
            this.mnuColors.Text = "menuStrip1";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // btnGoToSecondForm
            // 
            this.btnGoToSecondForm.Location = new System.Drawing.Point(261, 156);
            this.btnGoToSecondForm.Name = "btnGoToSecondForm";
            this.btnGoToSecondForm.Size = new System.Drawing.Size(285, 61);
            this.btnGoToSecondForm.TabIndex = 3;
            this.btnGoToSecondForm.Text = "Go To 2nd Form";
            this.btnGoToSecondForm.UseVisualStyleBackColor = true;
            this.btnGoToSecondForm.Click += new System.EventHandler(this.btnGoToSecondForm_Click);
            // 
            // FrmMoreControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToSecondForm);
            this.Controls.Add(this.hsbNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.mnuColors);
            this.MainMenuStrip = this.mnuColors;
            this.Name = "FrmMoreControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mnuColors.ResumeLayout(false);
            this.mnuColors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.HScrollBar hsbNumber;
        private System.Windows.Forms.MenuStrip mnuColors;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.Button btnGoToSecondForm;
    }
}

