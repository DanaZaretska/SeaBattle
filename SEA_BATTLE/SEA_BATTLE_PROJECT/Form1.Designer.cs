
namespace SEA_BATTLE_PROJECT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerGrid = new System.Windows.Forms.DataGridView();
            this.computerGrid = new System.Windows.Forms.DataGridView();
            this.startButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerGrid
            // 
            this.playerGrid.AllowUserToAddRows = false;
            this.playerGrid.AllowUserToDeleteRows = false;
            this.playerGrid.AllowUserToResizeColumns = false;
            this.playerGrid.AllowUserToResizeRows = false;
            this.playerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playerGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.playerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerGrid.ColumnHeadersVisible = false;
            this.playerGrid.GridColor = System.Drawing.Color.Silver;
            this.playerGrid.Location = new System.Drawing.Point(14, 19);
            this.playerGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playerGrid.Name = "playerGrid";
            this.playerGrid.ReadOnly = true;
            this.playerGrid.RowHeadersVisible = false;
            this.playerGrid.RowHeadersWidth = 51;
            this.playerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            this.playerGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.playerGrid.RowTemplate.Height = 25;
            this.playerGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.playerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.playerGrid.Size = new System.Drawing.Size(343, 397);
            this.playerGrid.TabIndex = 2;
            this.playerGrid.SelectionChanged += new System.EventHandler(this.playerGrid_SelectionChanged);
            // 
            // computerGrid
            // 
            this.computerGrid.AllowUserToAddRows = false;
            this.computerGrid.AllowUserToDeleteRows = false;
            this.computerGrid.AllowUserToResizeColumns = false;
            this.computerGrid.AllowUserToResizeRows = false;
            this.computerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.computerGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.computerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerGrid.ColumnHeadersVisible = false;
            this.computerGrid.GridColor = System.Drawing.Color.Silver;
            this.computerGrid.Location = new System.Drawing.Point(558, 19);
            this.computerGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.computerGrid.Name = "computerGrid";
            this.computerGrid.ReadOnly = true;
            this.computerGrid.RowHeadersVisible = false;
            this.computerGrid.RowHeadersWidth = 51;
            this.computerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            this.computerGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.computerGrid.RowTemplate.Height = 25;
            this.computerGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.computerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.computerGrid.Size = new System.Drawing.Size(343, 397);
            this.computerGrid.TabIndex = 3;
            this.computerGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.computerGrid_CellClick);
            this.computerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.computerGrid_CellContentClick);
            this.computerGrid.SelectionChanged += new System.EventHandler(this.computerGrid_SelectionChanged);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.startButton.Location = new System.Drawing.Point(363, 19);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(189, 103);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start new game";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.randomButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.randomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.randomButton.Location = new System.Drawing.Point(363, 129);
            this.randomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(189, 33);
            this.randomButton.TabIndex = 5;
            this.randomButton.Text = "Random positioning";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.exitButton.Location = new System.Drawing.Point(363, 383);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(189, 33);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::SEA_BATTLE_PROJECT.Properties.Resources.image225;
            this.pictureBox1.Location = new System.Drawing.Point(363, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(909, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 208);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(909, 235);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 208);
            this.textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 448);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.computerGrid);
            this.Controls.Add(this.playerGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sea Battle";
            ((System.ComponentModel.ISupportInitialize)(this.playerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView playerGrid;
        private System.Windows.Forms.DataGridView computerGrid;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

