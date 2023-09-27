namespace pain
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.XZ = new pain.drawer();
            this.XW = new pain.drawer();
            this.ZW = new pain.drawer();
            this.YW = new pain.drawer();
            this.YZ = new pain.drawer();
            this.XY = new pain.drawer();
            this.gridPlusButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XY)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.XZ, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.XW, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ZW, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.YW, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.YZ, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.XY, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridPlusButton, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 536);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // XZ
            // 
            this.XZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XZ.Location = new System.Drawing.Point(269, 3);
            this.XZ.Name = "XZ";
            this.XZ.Size = new System.Drawing.Size(260, 235);
            this.XZ.TabIndex = 0;
            this.XZ.TabStop = false;
            // 
            // XW
            // 
            this.XW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XW.Location = new System.Drawing.Point(535, 3);
            this.XW.Name = "XW";
            this.XW.Size = new System.Drawing.Size(262, 235);
            this.XW.TabIndex = 1;
            this.XW.TabStop = false;
            // 
            // ZW
            // 
            this.ZW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZW.Location = new System.Drawing.Point(535, 244);
            this.ZW.Name = "ZW";
            this.ZW.Size = new System.Drawing.Size(262, 235);
            this.ZW.TabIndex = 2;
            this.ZW.TabStop = false;
            // 
            // YW
            // 
            this.YW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YW.Location = new System.Drawing.Point(269, 244);
            this.YW.Name = "YW";
            this.YW.Size = new System.Drawing.Size(260, 235);
            this.YW.TabIndex = 3;
            this.YW.TabStop = false;
            // 
            // YZ
            // 
            this.YZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YZ.Location = new System.Drawing.Point(3, 244);
            this.YZ.Name = "YZ";
            this.YZ.Size = new System.Drawing.Size(260, 235);
            this.YZ.TabIndex = 4;
            this.YZ.TabStop = false;
            // 
            // XY
            // 
            this.XY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XY.Location = new System.Drawing.Point(3, 3);
            this.XY.Name = "XY";
            this.XY.Size = new System.Drawing.Size(260, 235);
            this.XY.TabIndex = 5;
            this.XY.TabStop = false;
            this.XY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XY_MouseDown);
            // 
            // gridPlusButton
            // 
            this.gridPlusButton.Location = new System.Drawing.Point(3, 485);
            this.gridPlusButton.Name = "gridPlusButton";
            this.gridPlusButton.Size = new System.Drawing.Size(248, 39);
            this.gridPlusButton.TabIndex = 6;
            this.gridPlusButton.Text = "grid Plus";
            this.gridPlusButton.UseVisualStyleBackColor = true;
            this.gridPlusButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private drawer XZ;
        private drawer XW;
        private drawer ZW;
        private drawer YW;
        private drawer YZ;
        private drawer XY;
        private System.Windows.Forms.Button gridPlusButton;
        private System.Windows.Forms.Timer timer1;
    }
}

