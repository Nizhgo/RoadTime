using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Timers;
using System.Data;
using System;
using System.Text;

namespace RoadTime

{

    public partial class Form1 : Form

    {
        public Form1()
        {

            InitializeComponent();
            IO.GetLocalData();          //�������� �������� ����������� ������
            AutoTimer.Initialize();     //�������������� ��������� ������ �� �������
            TravelTimeGirdUpdate();     //��������� ������� � ������������� � ����
            AdressDataGirdUpdate();     //��������� ������� � ��������
            UpdateChek();               //�������� ���������� ������������ ������� � ������������ �� �������
        }

        public void TravelTimeGirdUpdate()  //������ �������� ��������� ��� ������� � ������
        {
            var sourse = new BindingList<TravelTimeData>(AppSettings.travelTimeData);
            TravelTimeDataGrid.DataSource = sourse;
        }
        public void AdressDataGirdUpdate()  //������ �������� ��������� ��� ������� � ���������
        {
            if (AppSettings.address != null)
            AddressDataGrid.DataSource = AppSettings.address.Select(s => new { value = s }).ToList();
        }

        private void AddAdressBtn_Click(object sender, EventArgs e)  //���������� ������� � ������
        {
            string AddressCandidate = AddAddressTextBox.Text;
            if (AddressCandidate != "")
            {
                bool status = IO.AddAddress(AddressCandidate);
                if (status)
                {
                    AdressDataGirdUpdate();
                    return;
                }
            }
            Message("������������ ������ ������ ��� ����� ����� ��� ��������");
        }

        private void UpdateChek() //��������� �� ������ �� ����� �������� ������� � ������������� � ����
        {
            var timer = new System.Timers.Timer();
            timer.Interval = 31245; //�������� ���������� � 31 �������
            timer.Start();
            timer.Elapsed += (sender, args) =>
            {
                string?[] timers = label7.Text.Trim(' ').Split(" ");
                if (timers != null && timers[0] != "")
                foreach (string timer in timers)
                {
                    if (timer.Split(":")[0] == DateTime.Now.Hour.ToString() && timer.Split(":")[1] == DateTime.Now.Minute.ToString())
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                TravelTimeGirdUpdate();
                            });
                        }
                }
            };
        }

        private void AddAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            AddAddressTextBox.ForeColor = Color.Black;
        }

        private void Message(string message)
        {
            MessageBox.Show(message, "������", MessageBoxButtons.OK);
            AddAddressTextBox.ForeColor = Color.Red;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            AppSettings.GetRoadTimeBetweenAllAddresses();
            TravelTimeGirdUpdate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TravelTimeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 58 && number != 32 && number != 44) //��������� ������ �����, ������� BackSpace, ��������� � ������� � ASCII
            {
                e.Handled = true;
            }
        }

        private void AutomaticTimerUpdate_Click(object sender, EventArgs e) //���������� �������� (�������� ������������ � �� ������� ������� � �� ������� ����������
        {
            string s = TimersTextBox.Text.Trim(new char[] { ' ', ',', ':' });
            TimersTextBox.Text = s;
            if (IO.SetTimers(s))
            {
                TimersTextBox.Clear();
                label7.Text = "";
                foreach (DateTime timer in AppSettings.timers)
                    label7.Text += timer.Hour.ToString() + ":" + timer.Minute.ToString() + " ";
            }
            else
                Message("������������ ������ �������");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "JSON (*.json)|*.json";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var json = IO.SaveJsonDuration();
                System.IO.StreamWriter file = new System.IO.StreamWriter( new FileStream(saveFileDialog1.FileName.ToString(), FileMode.CreateNew), Encoding.UTF32);
                file.Write(json);
                file.Close();
            }
        }
    }
}
