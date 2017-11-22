using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HW.Properties;
using System.Data;
using System.Windows.Forms;
using System.Security;


namespace HW
{
    class ClsCreate
    {

        public string UserNametext;
        public string PassWordtext;
        public string CheckPassWordtext;
        public string Emailtext;
        public string ScuExtext;
        public string ScuExAAtext;
        /// <summary>
        /// 
        /// </summary>

        public void setUserNametext()
        {
            using (var cn = new SqlConnection(Settings.Default.NW))
            using (var adp = new SqlCommand(@"insert into 
                                            Member (
                                            UserName, 
                                            Password, 
                                            Email, 
                                            SecurityIssues, 
                                            SecuritySolution)
                                            values(
                                            @Name,
                                            @Password
                                            @Email
                                            @SecurityIssues
                                            @SecuritySolution);", cn))
            {
                //adp.CommandType = CommandType.Text;
                adp.Parameters.Add("UserName", SqlDbType.NVarChar, 16).Value = UserNametext;
                adp.Parameters.Add("Password", SqlDbType.NVarChar).Value = PassWordtext;
                adp.Parameters.Add("Email", SqlDbType.NVarChar).Value = Emailtext;
                adp.Parameters.Add("SecurityIssues", SqlDbType.NVarChar).Value = ScuExtext;
                adp.Parameters.Add("SecuritySolution", SqlDbType.NVarChar).Value = ScuExAAtext;
                cn.Open();
                adp.ExecuteNonQuery();
               
            }

        }

        public void checkUsertext()
        {
            using (var cn = new SqlConnection(Settings.Default.NW))
            using (var adp = new SqlCommand(@"select *
                                               from Member
                                              where UserName =@UserName and Password=@Password);", cn))
            {

                adp.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UserNametext;
                adp.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = PassWordtext;
                cn.Open();
                SqlDataReader dataReader = adp.ExecuteReader();
                dataReader.Read();

                if (dataReader.HasRows)
                {
                    if (PassWordtext == dataReader["Password"].ToString())
                    {
                        MessageBox.Show("登入成功");
                    }
                    else
                    {
                        MessageBox.Show("密碼錯誤");
                    }
                }
                else
                {
                    MessageBox.Show("密碼錯誤");
                }

            }
        }
    }
}
