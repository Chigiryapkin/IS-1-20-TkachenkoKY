using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace IS_1_20_TkachenkoKY
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private Form currentChildForm;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            Authh Auth2 = new Authh();
            //Вызов формы в режиме диалога
            Auth2.ShowDialog();
            //Если авторизации была успешна и в поле класса хранится истина, то делаем движуху:
            if (Auth.auth)
            {
                //Отображаем рабочую форму
                this.Show();
                //Вытаскиваем из класса поля в label'ы
                metroLabel1.ForeColor = Color.GreenYellow;
                metroLabel1.Text = Auth.auth_id;
                metroLabel1.Text = Auth.auth_fio;
                metroLabel1.Text = $"Здравствуйте, {Auth.auth_fio}";
                //Красим текст в label в зелёный цвет
            }
            //иначе
            else
            {
                //Закрываем форму
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            Authh f = new Authh();
            //Вызов формы в режиме диалога
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму сотрудники
            Employee f = new Employee();
            //Вызов формы в режиме диалога
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму сотрудники
             f = new ();
            //Вызов формы в режиме диалога
            f.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}