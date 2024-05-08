using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace login
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection conn;


        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection();

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection.ConnectionString);
                conn.ConnectionString =
                    "Data Source=caresqldbuat;" +
                    "Initial Catalog=kaustubh;" +
                    "User id=Sa;" +
                    "Password=care@123456;";
                conn.Open();
                var EmpID = EmpIDbox.Text;
                var password = passwordbox.Text;
                cmd = new SqlCommand("Select * From UserRegister Where EmpId =" + EmpID + " and Password ='" + password + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login Done", "Succesful", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No Account Available with this username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                conn.Close();

            }
            catch (Exception ex)
            {
                SendErrorToText(ex);
                MessageBox.Show("Login Failed:" + ex.Message);

            }

        }



        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static String ErrorlineNo, Errormsg, extype, exurl, hostIp, ErrorLocation, HostAdd;
        public static void SendErrorToText(Exception ex)
        {
            var line = Environment.NewLine + Environment.NewLine;

            ErrorlineNo = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
            Errormsg = ex.GetType().Name.ToString();
            extype = ex.GetType().ToString();
            //exurl = context.Current.Request.Url.ToString();
            ErrorLocation = ex.Message.ToString();



            try
            {
                string filepath = "C:/Users/kaustubh.wavare/source/repos/login/login/ExceptionDetailsFile/ErrorLog/ErrorLog";  //Text File Path



                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);



                }
                filepath = filepath + DateTime.Today.ToString("dd-MM-yy") + ".txt";   //Text File Name
                if (!File.Exists(filepath))
                {





                    File.Create(filepath).Dispose();



                }
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    string error = "Log Written Date:" + " " + DateTime.Now.ToString() + line + "Error Line No :" + " " + ErrorlineNo + line + "Error Message:" + " " + Errormsg + line + "Exception Type:" + " " + extype + line + "Error Location :" + " " + ErrorLocation + line + " Error Page Url:" + " " + exurl + line + "User Host IP:" + " " + hostIp + line;
                    sw.WriteLine("-----------Exception Details on " + " " + DateTime.Now.ToString() + "-----------------");
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(line);
                    sw.WriteLine(error);
                    sw.WriteLine("--------------------------------*End*------------------------------------------");
                    sw.WriteLine(line);
                    sw.Flush();
                    sw.Close();



                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
