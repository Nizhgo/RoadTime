namespace RoadTime
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddAddressTextBox = new System.Windows.Forms.TextBox();
            this.AddAddressBtn = new System.Windows.Forms.Button();
            this.TimersTextBox = new System.Windows.Forms.TextBox();
            this.AutomaticTimerUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddressDataGrid = new System.Windows.Forms.DataGridView();
            this.TravelTimeDataGrid = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelTimeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAddressTextBox
            // 
            this.AddAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddAddressTextBox.Location = new System.Drawing.Point(569, 388);
            this.AddAddressTextBox.Name = "AddAddressTextBox";
            this.AddAddressTextBox.Size = new System.Drawing.Size(208, 25);
            this.AddAddressTextBox.TabIndex = 2;
            this.AddAddressTextBox.TextChanged += new System.EventHandler(this.AddAddressTextBox_TextChanged);
            // 
            // AddAddressBtn
            // 
            this.AddAddressBtn.Font = new System.Drawing.Font("Rocketfont", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAddressBtn.Location = new System.Drawing.Point(569, 416);
            this.AddAddressBtn.Name = "AddAddressBtn";
            this.AddAddressBtn.Size = new System.Drawing.Size(207, 25);
            this.AddAddressBtn.TabIndex = 3;
            this.AddAddressBtn.Text = "Добавить";
            this.AddAddressBtn.UseVisualStyleBackColor = true;
            this.AddAddressBtn.Click += new System.EventHandler(this.AddAdressBtn_Click);
            // 
            // TimersTextBox
            // 
            this.TimersTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TimersTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimersTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TimersTextBox.Location = new System.Drawing.Point(569, 48);
            this.TimersTextBox.Name = "TimersTextBox";
            this.TimersTextBox.Size = new System.Drawing.Size(208, 25);
            this.TimersTextBox.TabIndex = 4;
            this.TimersTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // AutomaticTimerUpdate
            // 
            this.AutomaticTimerUpdate.AccessibleDescription = "Установить";
            this.AutomaticTimerUpdate.AccessibleName = "Установить";
            this.AutomaticTimerUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AutomaticTimerUpdate.BackgroundImage")));
            this.AutomaticTimerUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AutomaticTimerUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutomaticTimerUpdate.FlatAppearance.BorderSize = 0;
            this.AutomaticTimerUpdate.Location = new System.Drawing.Point(781, 43);
            this.AutomaticTimerUpdate.Name = "AutomaticTimerUpdate";
            this.AutomaticTimerUpdate.Size = new System.Drawing.Size(32, 31);
            this.AutomaticTimerUpdate.TabIndex = 5;
            this.AutomaticTimerUpdate.UseVisualStyleBackColor = true;
            this.AutomaticTimerUpdate.Click += new System.EventHandler(this.AutomaticTimerUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rocketfont", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(569, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Автоматическое оновление в:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rocketfont", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(569, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 11);
            this.label2.TabIndex = 11;
            this.label2.Text = "Например: «12:00»\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rocketfont", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(569, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 11);
            this.label3.TabIndex = 12;
            this.label3.Text = "несколько значений через запятую (до 3)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rocketfont", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(569, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Адреса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rocketfont", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(569, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 11);
            this.label5.TabIndex = 14;
            this.label5.Text = "Например Москва, Щукинская, 7\r\n";
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "Импорт";
            this.button2.AccessibleName = "Импорт";
            this.button2.BackgroundImage = global::RoadTime.Properties.Resources.outline_file_download_black_24dp;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(497, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 31);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rocketfont", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дорожное время";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.AccessibleDescription = "Получить данные сейчас";
            this.UpdateBtn.AccessibleName = "Получить данные сейчас";
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateBtn.Location = new System.Drawing.Point(459, 129);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(32, 31);
            this.UpdateBtn.TabIndex = 18;
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 38);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // AddressDataGrid
            // 
            this.AddressDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddressDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.AddressDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressDataGrid.ColumnHeadersVisible = false;
            this.AddressDataGrid.EnableHeadersVisualStyles = false;
            this.AddressDataGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddressDataGrid.Location = new System.Drawing.Point(569, 163);
            this.AddressDataGrid.Name = "AddressDataGrid";
            this.AddressDataGrid.RowHeadersVisible = false;
            this.AddressDataGrid.RowHeadersWidth = 51;
            this.AddressDataGrid.RowTemplate.Height = 29;
            this.AddressDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AddressDataGrid.Size = new System.Drawing.Size(207, 207);
            this.AddressDataGrid.TabIndex = 20;
            this.AddressDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddressDataGrid_CellDoubleClick);
            // 
            // TravelTimeDataGrid
            // 
            this.TravelTimeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TravelTimeDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TravelTimeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TravelTimeDataGrid.ColumnHeadersVisible = false;
            this.TravelTimeDataGrid.Location = new System.Drawing.Point(39, 163);
            this.TravelTimeDataGrid.Name = "TravelTimeDataGrid";
            this.TravelTimeDataGrid.RowHeadersVisible = false;
            this.TravelTimeDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TravelTimeDataGrid.RowTemplate.Height = 29;
            this.TravelTimeDataGrid.Size = new System.Drawing.Size(490, 278);
            this.TravelTimeDataGrid.TabIndex = 21;
            this.TravelTimeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TravelTimeDataGrid_CellContentClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RoadTime";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Автообновление в:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 475);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TravelTimeDataGrid);
            this.Controls.Add(this.AddressDataGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutomaticTimerUpdate);
            this.Controls.Add(this.TimersTextBox);
            this.Controls.Add(this.AddAddressBtn);
            this.Controls.Add(this.AddAddressTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelTimeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox AddAddressTextBox;
        private Button AddAddressBtn;
        private TextBox TimersTextBox;
        private Button AutomaticTimerUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Label label6;
        private Button UpdateBtn;
        private PictureBox pictureBox1;
        private DataGridView AddressDataGrid;
        private DataGridView TravelTimeDataGrid;
        private NotifyIcon notifyIcon1;
        private Label label8;
        private Label label7;
    }
}