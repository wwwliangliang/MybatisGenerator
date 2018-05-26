/* Copyright 2018 icefrog.su@qq.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */






using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MybatisGenerator
{
    class MySQLUtil
    {
        /// <summary>
        /// 数据库连接地址
        /// </summary>
        private string address;

        /// <summary>
        /// 数据库连接对象
        /// </summary>
        private MySqlConnection conn;

        /// <summary>
        /// 实例化数据库连接地址和数据库连接对象
        /// </summary>
        /// <param name="connectionString">mysql连接字符串</param>
        public MySQLUtil(string connectionString)
        {
            address = connectionString;
            conn = new MySqlConnection(address);
        }

        public MySqlDataReader ReBuildMySQLDataReader(string sql)
        {
            MySqlDataReader reader = null;
            MySqlConnection reConn = new MySqlConnection(address);
            try
            { //错误处理
                reConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, reConn);
                reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            { //返回异常值
                return reader;
            }
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {//异常处理块
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int flag = cmd.ExecuteNonQuery();
                return flag;
            }
            catch
            {
                //出现异常则返回-1
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public object ExecuteScalar(string sql)
        {
            try
            { //异常处理块
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                object obj = cmd.ExecuteScalar();
                return obj;
            }
            catch
            { //抛出异常返回值
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public MySqlDataReader ExecuteDataReader(string sql)
        {
            try
            { //错误处理
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            { //返回异常值
                return null;
            }
        }

        public DataSet ExecuteDataSet(string sql)
        {
            try
            {//异常处理块
                MySqlDataAdapter dat = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                dat.Fill(ds);
                return ds;
            }
            catch
            { //抓取异常返回异常值
                return null;
            }
        }

        public DataTable ExecuteDataTable(string sql)
        {
            DataTable dt = new DataTable();
            dt = ExecuteDataSet(sql).Tables[0];
            return dt;
        }

        public DataRow ExecuteDataRow(string sql)
        {
            DataRow dr;
            dr = ExecuteDataSet(sql).Tables[0].Rows[0];
            return dr;
        }
    }
}
