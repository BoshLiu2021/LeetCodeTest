using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UsDaL
    {
         public SqlConnection ConnString = new SqlConnection(ConfigurationManager.ConnectionStrings["connString_us"].ConnectionString);


        public DataTable get_All_List(string name)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = ConnString;
            sqlCmd.CommandType = CommandType.Text;

            string sqlString = @"";

            sqlCmd.Parameters.Add(new SqlParameter("@ball_name", name));
         
            sqlCmd.CommandText = sqlString;
            try
            {
                return runParaCmd(sqlCmd).ToTable();
            }
            catch (Exception ex)
            {
                sqlCmd.Connection.Close();
                sqlCmd.Connection.Dispose();
                sqlCmd.Dispose();
                throw new Exception("get_All_List錯誤訊息：" + ex.Message);
            }
            finally
            {
            }
        }



        #region SQL CMD
        public DataView runParaCmd(SqlCommand sqlCmd)
        {
            sqlCmd.Connection = ConnString;

            //取代可能的攻擊字眼
            ReplaceMaliciousParametersSqlCommand(ref sqlCmd);

            SqlDataAdapter cmdSQL = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            cmdSQL.Fill(ds, "myTable");

            ConnString.Close();

            return ds.Tables["myTable"].DefaultView;
        }

        public static void ReplaceMaliciousParametersSqlCommand(ref SqlCommand sc)
        {
            foreach (System.Data.SqlClient.SqlParameter p in sc.Parameters)
            {
                if (p.Value != null)
                {
                    p.Value = RemoveHTMLTags(DoReplace(p.Value.ToString()));
                }
            }
        }



        public void runParaCmd1(SqlCommand sqlCmd)
        {
            //取代可能的攻擊字眼
            ReplaceMaliciousParametersSqlCommand(ref sqlCmd);

            sqlCmd.Connection = ConnString;
            ConnString.Open();
            sqlCmd.ExecuteNonQuery();
            ConnString.Close();
        }

        /// <summary>
        /// 目前可通過掃描的項目
        /// </summary>
        /// <param name="strOri">參數</param>
        /// <returns></returns>
        private static string DoReplace(string strOri)
        {
            if (strOri.Length > 0)
            {
                strOri = strOri.Replace("|", "︱");
                strOri = strOri.Replace("&", "＆");
                //strOri = strOri.Replace(";", "；");
                strOri = strOri.Replace("$", "＄");
                strOri = strOri.Replace("%", "％");
                strOri = strOri.Replace("@", "＠");
                strOri = strOri.Replace("'", "’");
                strOri = strOri.Replace("<", "＜");
                //strOri = strOri.Replace("(", "（");
                //strOri = strOri.Replace("\"", "＂");
                strOri = strOri.Replace(">", "＞");
                //strOri = strOri.Replace(")", "）");
                strOri = strOri.Replace("+", "＋");
                strOri = strOri.Replace("#", "＃");
                //strOri = strOri.Replace(" CR ", "ＣＲ");
                // strOri = strOri.Replace(" LF ", "ＬＦ");
                //strOri = strOri.Replace("\\", "＼");
                //strOri = strOri.Replace("&lt", "＆lt");
                // strOri = strOri.Replace("&gt", "＆gt");

                //如果有連續兩個以上的"-"，則將所有的"-"變成全型"－"
                if (strOri.IndexOf("--") > -1)
                    strOri = strOri.Replace("-", "－");

            }

            return strOri;
        }



        #endregion
        #region 移除HTML Tags
        /// <summary>
        /// 移除HTML Tags
        /// </summary>
        /// <param name="HtmlSource"></param>
        /// <returns></returns>
        public static string RemoveHTMLTags(string HtmlSource)
        {
            string PureText = System.Text.RegularExpressions.Regex.Replace(Regex.Replace(HtmlSource.ToString(), "(?is)<.+?>", "").ToString(), "(?is)&.+?;", "").ToString();
            return PureText;
        }
        #endregion
    }
}
