namespace Volumator
{
    partial class sphereForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sphereForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backBut = new System.Windows.Forms.Button();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.titlePic = new System.Windows.Forms.PictureBox();
            this.displayPic = new System.Windows.Forms.PictureBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateBut = new System.Windows.Forms.Button();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.radiusErrorLabel = new System.Windows.Forms.Label();
            this.formulaBut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPic)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.03591F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.891F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.60174F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.43544F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.03591F));
            this.tableLayoutPanel1.Controls.Add(this.backBut, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.radiusTextBox, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.unitComboBox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.titlePic, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.displayPic, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.resultLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.calculateBut, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.radiusLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.radiusErrorLabel, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.formulaBut, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 661);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // backBut
            // 
            this.backBut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.backBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBut.BackgroundImage")));
            this.backBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBut.FlatAppearance.BorderSize = 0;
            this.backBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.backBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBut.Location = new System.Drawing.Point(3, 597);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(150, 60);
            this.backBut.TabIndex = 15;
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radiusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusTextBox.Location = new System.Drawing.Point(475, 478);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 31);
            this.radiusTextBox.TabIndex = 6;
            // 
            // unitComboBox
            // 
            this.unitComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.unitComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(590, 477);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(130, 33);
            this.unitComboBox.TabIndex = 9;
            // 
            // titlePic
            // 
            this.titlePic.BackgroundImage = global::Volumator.Properties.Resources.SphereTitle;
            this.titlePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.SetColumnSpan(this.titlePic, 3);
            this.titlePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePic.Location = new System.Drawing.Point(162, 3);
            this.titlePic.Name = "titlePic";
            this.titlePic.Size = new System.Drawing.Size(558, 99);
            this.titlePic.TabIndex = 11;
            this.titlePic.TabStop = false;
            // 
            // displayPic
            // 
            this.displayPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.SetColumnSpan(this.displayPic, 3);
            this.displayPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPic.Location = new System.Drawing.Point(162, 121);
            this.displayPic.Name = "displayPic";
            this.displayPic.Size = new System.Drawing.Size(558, 258);
            this.displayPic.TabIndex = 12;
            this.displayPic.TabStop = false;
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.resultLabel, 3);
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(401, 614);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(79, 25);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "Result:";
            this.resultLabel.Visible = false;
            // 
            // calculateBut
            // 
            this.calculateBut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.calculateBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.calculateBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calculateBut.BackgroundImage")));
            this.calculateBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calculateBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateBut.FlatAppearance.BorderSize = 0;
            this.calculateBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.calculateBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.calculateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateBut.Location = new System.Drawing.Point(731, 597);
            this.calculateBut.Name = "calculateBut";
            this.calculateBut.Size = new System.Drawing.Size(150, 60);
            this.calculateBut.TabIndex = 14;
            this.calculateBut.UseVisualStyleBackColor = false;
            this.calculateBut.Click += new System.EventHandler(this.calculateBut_Click);
            // 
            // radiusLabel
            // 
            this.radiusLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusLabel.Location = new System.Drawing.Point(341, 481);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(114, 25);
            this.radiusLabel.TabIndex = 17;
            this.radiusLabel.Text = "Radius (R)";
            // 
            // radiusErrorLabel
            // 
            this.radiusErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radiusErrorLabel.AutoSize = true;
            this.radiusErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusErrorLabel.Location = new System.Drawing.Point(728, 469);
            this.radiusErrorLabel.Name = "radiusErrorLabel";
            this.radiusErrorLabel.Size = new System.Drawing.Size(151, 50);
            this.radiusErrorLabel.TabIndex = 21;
            this.radiusErrorLabel.Text = "Please enter a number";
            this.radiusErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiusErrorLabel.Visible = false;
            // 
            // formulaBut
            // 
            this.formulaBut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.formulaBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.formulaBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formulaBut.FlatAppearance.BorderSize = 0;
            this.formulaBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.formulaBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.formulaBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formulaBut.Location = new System.Drawing.Point(3, 464);
            this.formulaBut.Name = "formulaBut";
            this.formulaBut.Size = new System.Drawing.Size(150, 60);
            this.formulaBut.TabIndex = 23;
            this.formulaBut.UseVisualStyleBackColor = false;
            this.formulaBut.Click += new System.EventHandler(this.forumulaBut_Click);
            // 
            // sphereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sphereForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sphere";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.PictureBox titlePic;
        private System.Windows.Forms.PictureBox displayPic;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateBut;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label radiusErrorLabel;
        private System.Windows.Forms.Button formulaBut;
    }
}