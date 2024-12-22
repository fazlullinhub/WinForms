using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class MainForm : Form
    {
        private TextBox textBoxFIO;             
        private TextBox textBoxBirthDate;       
        private Button buttonShowTime;           
        private Button buttonShowFIO;            
        private Button buttonShowBirthDate;      
        private Button buttonShowAll;            
        private Button buttonExit;              

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxFIO = new TextBox();
            this.textBoxBirthDate = new TextBox();
            this.buttonShowTime = new Button();
            this.buttonShowFIO = new Button();
            this.buttonShowBirthDate = new Button();
            this.buttonShowAll = new Button();
            this.buttonExit = new Button();

            
            this.textBoxFIO.Location = new System.Drawing.Point(30, 30);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(200, 20);
            this.textBoxFIO.TabIndex = 0;

             
            this.textBoxBirthDate.Location = new System.Drawing.Point(30, 70);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(200, 20);
            this.textBoxBirthDate.TabIndex = 1;

            
            this.buttonShowTime.Location = new System.Drawing.Point(30, 110);
            this.buttonShowTime.Name = "buttonShowTime";
            this.buttonShowTime.Size = new System.Drawing.Size(200, 30);
            this.buttonShowTime.Text = "Нынешнее время";
            this.buttonShowTime.Click += new System.EventHandler(this.button1_Click);

            
            this.buttonShowFIO.Location = new System.Drawing.Point(30, 150);
            this.buttonShowFIO.Name = "buttonShowFIO";
            this.buttonShowFIO.Size = new System.Drawing.Size(200, 30);
            this.buttonShowFIO.Text = "Вывод ФИО";
            this.buttonShowFIO.Click += new System.EventHandler(this.button2_Click);

             
            this.buttonShowBirthDate.Location = new System.Drawing.Point(30, 190);
            this.buttonShowBirthDate.Name = "buttonShowBirthDate";
            this.buttonShowBirthDate.Size = new System.Drawing.Size(200, 30);
            this.buttonShowBirthDate.Text = "Вывод даты рождения";
            this.buttonShowBirthDate.Click += new System.EventHandler(this.button3_Click);

             
            this.buttonShowAll.Location = new System.Drawing.Point(30, 230);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(200, 30);
            this.buttonShowAll.Text = "Вывод информации";
            this.buttonShowAll.Click += new System.EventHandler(this.button4_Click);

            
            this.buttonExit.Location = new System.Drawing.Point(30, 270);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 30);
            this.buttonExit.Text = "Выход";
            this.buttonExit.Click += new System.EventHandler(this.button5_Click);

            
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.textBoxBirthDate);
            this.Controls.Add(this.buttonShowTime);
            this.Controls.Add(this.buttonShowFIO);
            this.Controls.Add(this.buttonShowBirthDate);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonExit);
            this.Name = "MainForm";
            this.Text = "Информация о себе";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нынешнее время: " + DateTime.Now.ToString("HH:mm:ss"), "Текущее время");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fio = textBoxFIO.Text;
            MessageBox.Show("Ваши ФИО: " + fio, "Вывод ФИО");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string birthDate = textBoxBirthDate.Text;
            MessageBox.Show("Ваша дата рождения: " + birthDate, "День рождения");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fio = textBoxFIO.Text;
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            string birthDate = textBoxBirthDate.Text;

            string message = $"Нынешнее время: {currentTime}\nВаши ФИО: {fio}\nВаша дата рождения: {birthDate}";
            MessageBox.Show(message, "Информация");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
