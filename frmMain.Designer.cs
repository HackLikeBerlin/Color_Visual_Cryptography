namespace CCC
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnStacker = new System.Windows.Forms.Button();
            this.btnSlicer = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(880, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // btnStacker
            // 
            this.btnStacker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStacker.Location = new System.Drawing.Point(173, 0);
            this.btnStacker.Name = "btnStacker";
            this.btnStacker.Size = new System.Drawing.Size(155, 49);
            this.btnStacker.TabIndex = 124;
            this.btnStacker.Text = "Stacker";
            this.btnStacker.UseVisualStyleBackColor = true;
            this.btnStacker.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnSlicer
            // 
            this.btnSlicer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlicer.Location = new System.Drawing.Point(12, 0);
            this.btnSlicer.Name = "btnSlicer";
            this.btnSlicer.Size = new System.Drawing.Size(155, 49);
            this.btnSlicer.TabIndex = 123;
            this.btnSlicer.Text = "Slicer";
            this.btnSlicer.UseVisualStyleBackColor = true;
            this.btnSlicer.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(880, 25);
            this.ToolStrip.TabIndex = 119;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(880, 24);
            this.MenuStrip.TabIndex = 118;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 453);
            this.Controls.Add(this.btnStacker);
            this.Controls.Add(this.btnSlicer);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Visual Cryptography";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.Button btnStacker;
        internal System.Windows.Forms.Button btnSlicer;
        internal System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.ToolStrip ToolStrip;
        internal System.Windows.Forms.MenuStrip MenuStrip;
    }
}



