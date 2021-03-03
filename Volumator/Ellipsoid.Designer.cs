namespace Volumator
{
    partial class ellipsoidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ellipsoidForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backBut = new System.Windows.Forms.Button();
            this.axisATextBox = new System.Windows.Forms.TextBox();
            this.axisBTextBox = new System.Windows.Forms.TextBox();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.titlePic = new System.Windows.Forms.PictureBox();
            this.displayPic = new System.Windows.Forms.PictureBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.axisCTextBox = new System.Windows.Forms.TextBox();
            this.axisAErrorLabel = new System.Windows.Forms.Label();
            this.axisBErrorLabel = new System.Windows.Forms.Label();
            this.axisCErrorLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.axisATextBox, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.axisBTextBox, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.unitComboBox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.titlePic, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.displayPic, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.resultLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.calculateBut, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.axisCTextBox, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.axisAErrorLabel, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.axisBErrorLabel, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.axisCErrorLabel, 4, 6);
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
            // axisATextBox
            // 
            this.axisATextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.axisATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisATextBox.Location = new System.Drawing.Point(475, 412);
            this.axisATextBox.Name = "axisATextBox";
            this.axisATextBox.Size = new System.Drawing.Size(100, 31);
            this.axisATextBox.TabIndex = 5;
            // 
            // axisBTextBox
            // 
            this.axisBTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.axisBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisBTextBox.Location = new System.Drawing.Point(475, 478);
            this.axisBTextBox.Name = "axisBTextBox";
            this.axisBTextBox.Size = new System.Drawing.Size(100, 31);
            this.axisBTextBox.TabIndex = 6;
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
            this.titlePic.BackgroundImage = global::Volumator.Properties.Resources.EllipsoidTitle;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Axis A (A)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Axis B (B)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Axis C (C)";
            // 
            // axisCTextBox
            // 
            this.axisCTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.axisCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisCTextBox.Location = new System.Drawing.Point(475, 544);
            this.axisCTextBox.Name = "axisCTextBox";
            this.axisCTextBox.Size = new System.Drawing.Size(100, 31);
            this.axisCTextBox.TabIndex = 19;
            // 
            // axisAErrorLabel
            // 
            this.axisAErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.axisAErrorLabel.AutoSize = true;
            this.axisAErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisAErrorLabel.Location = new System.Drawing.Point(728, 403);
            this.axisAErrorLabel.Name = "axisAErrorLabel";
            this.axisAErrorLabel.Size = new System.Drawing.Size(151, 50);
            this.axisAErrorLabel.TabIndex = 20;
            this.axisAErrorLabel.Text = "Please enter a number";
            this.axisAErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.axisAErrorLabel.Visible = false;
            // 
            // axisBErrorLabel
            // 
            this.axisBErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.axisBErrorLabel.AutoSize = true;
            this.axisBErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisBErrorLabel.Location = new System.Drawing.Point(728, 469);
            this.axisBErrorLabel.Name = "axisBErrorLabel";
            this.axisBErrorLabel.Size = new System.Drawing.Size(151, 50);
            this.axisBErrorLabel.TabIndex = 21;
            this.axisBErrorLabel.Text = "Please enter a number";
            this.axisBErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.axisBErrorLabel.Visible = false;
            // 
            // axisCErrorLabel
            // 
            this.axisCErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.axisCErrorLabel.AutoSize = true;
            this.axisCErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisCErrorLabel.Location = new System.Drawing.Point(728, 535);
            this.axisCErrorLabel.Name = "axisCErrorLabel";
            this.axisCErrorLabel.Size = new System.Drawing.Size(151, 50);
            this.axisCErrorLabel.TabIndex = 22;
            this.axisCErrorLabel.Text = "Please enter a number";
            this.axisCErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.axisCErrorLabel.Visible = false;
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
            this.formulaBut.Click += new System.EventHandler(this.formulaBut_Click);
            // 
            // ellipsoidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ellipsoidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ellipsoid";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.TextBox axisATextBox;
        private System.Windows.Forms.TextBox axisBTextBox;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.PictureBox titlePic;
        private System.Windows.Forms.PictureBox displayPic;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox axisCTextBox;
        private System.Windows.Forms.Label axisAErrorLabel;
        private System.Windows.Forms.Label axisBErrorLabel;
        private System.Windows.Forms.Label axisCErrorLabel;
        private System.Windows.Forms.Button formulaBut;
    }
}