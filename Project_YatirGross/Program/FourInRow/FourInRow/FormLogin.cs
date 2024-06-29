﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FourInRow
{
    public partial class FormLogin : Form
    {
        private OleDbConnection dataConnection;
        public FormLogin()
        {
            InitializeComponent();
            OpenDb();
        }
        private void OpenDb()
        {
            dataConnection = new OleDbConnection();
            try
            {
                dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Projects_2016\\Project_YatirGross\\Access\\dbFourInRow.accdb";
                dataConnection.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error accessing the database:" + e.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckButtonClick(object sender, EventArgs e)
        {
            string line, password;
            int id;
            bool isManager;
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT playerID, playerPassword, playerIsManager " +
                                          "FROM tblPlayers " + 
                                          "WHERE playerID = " + this.idNumber.Text;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                id = dataReader.GetInt32(0);
                password = dataReader.GetString(1);
                isManager = dataReader.GetBoolean(2);
                if(password==this.password.Text)
                {
                    this.Hide();
                    FormMenu frMenu = new FormMenu(dataConnection, isManager);
                    frMenu.Show();
                    frMenu.Disposed += new EventHandler(frMenu_Disposed);
                }
                else
                {
                    line = "Invalid password:" + this.password.Text;
                    MessageBox.Show(line, "Error");
                }
            }
            catch(Exception err)
            {
                line = "Invalid id:" + this.idNumber.Text + err.Message;
                MessageBox.Show(line, "Error");
            }
        }

        void frMenu_Disposed(object sender, EventArgs e)
        {
            this.idNumber.Text = "";
            this.password.Text = "";
            this.Show();
            this.Activate();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
