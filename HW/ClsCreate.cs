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

        public string UserNametext, PassWordtext, CheckPassWordtext, Emailtext, ScuExtext, ScuExAAtext;
        /// <summary>
        /// 建立新會員
        /// </summary>
        public void createMemeber()
        {
            using (var cn = new SqlConnection(Settings.Default.NW))
            {
                using (var adp = new SqlCommand(@"insert into 
                                            Member (
                                            UserName, 
                                            Password, 
                                            Email, 
                                            SecurityIssues, 
                                            SecuritySolution)
                                            values(
                                            @Name,
                                            @Password,
                                            @Email,
                                            @SecurityIssues,
                                            @SecuritySolution)", cn))
                {

                    //adp.CommandType = CommandType.Text;
                    adp.Parameters.Add("@Name", SqlDbType.NVarChar, 16).Value = this.UserNametext;
                    adp.Parameters.Add("@Password", SqlDbType.NVarChar).Value = this.PassWordtext;
                    adp.Parameters.Add("@Email", SqlDbType.NVarChar).Value = this.Emailtext;
                    adp.Parameters.Add("@SecurityIssues", SqlDbType.NVarChar).Value = this.ScuExtext;
                    adp.Parameters.Add("@SecuritySolution", SqlDbType.NVarChar).Value = this.ScuExAAtext;
                    cn.Open();
                    MessageBox.Show("建立成功");
                    adp.ExecuteNonQuery();

                }
            }

        }
        /// <summary>
        /// 帳號密碼確認
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        public void checkUsertext(string UserName, string Password)
        {
            using (var cn = new SqlConnection(Settings.Default.NW))
            using (var adp = new SqlCommand($"select * from Member where UserName = '{@UserName}' and password = '{@Password}'", cn))
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
                        FrmClsMain fm = new FrmClsMain();
                        fm.Show();
 
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

        public string UserForget(string UserName)//void不回傳值
        {
            string sytxt = "";
            using (var cn = new SqlConnection(Settings.Default.NW))
            using (var adp = new SqlCommand($"select SecurityIssues from Member where UserName = '{@UserName}'", cn))
            {
                adp.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UserName;
                cn.Open();
                SqlDataReader dataReader = adp.ExecuteReader();
               
                if (dataReader.Read() == true)
                {
                    sytxt = dataReader[0].ToString();
                   
                }
                
                else
                {
                    MessageBox.Show("輸入錯誤");
                }
            }
            return sytxt;
        }


        public string UserForgetpassword(string SecuritySolution)//void不回傳值
        {
            string Fpassword = "";
            using (var cn = new SqlConnection(Settings.Default.NW))
            using (var adp = new SqlCommand($"select Password from Member where SecuritySolution = '{@SecuritySolution}'", cn))
            {
                adp.Parameters.Add("@SecuritySolution", SqlDbType.NVarChar, 50).Value = SecuritySolution;
                cn.Open();
                SqlDataReader dataReader = adp.ExecuteReader();
                if (dataReader.Read() == true)
                {
                    Fpassword = dataReader[0].ToString();
                    
                }
                else
                {
                    MessageBox.Show("輸入錯誤");
                }
            }
            return Fpassword;

        }
    }
}
