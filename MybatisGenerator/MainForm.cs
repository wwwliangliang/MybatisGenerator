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
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MybatisGenerator
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// is identity database's flag
        /// </summary>
        public static bool IsCheckConnection = false;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// test connection of button's click event, test the connecte mysql of database's information is right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_testConnection_Click(object sender, EventArgs e)
        {
            string ipAddr = txt_ip.Text;
            string port = txt_port.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;
            string database = txt_database.Text;

            if (ipAddr == null || ipAddr.Equals(""))
            {
                MessageBox.Show("请输入数据库连接IP！");
                txt_ip.Focus();
                txt_ip.SelectAll();
                return;
            }
            if (port == null || port.Equals(""))
            {
                MessageBox.Show("请输入数据库连接端口！");
                txt_port.Focus();
                txt_port.SelectAll();
                return;
            }
            if (username == null || username.Equals(""))
            {
                MessageBox.Show("请输入数据库连接用户名！");
                txt_username.Focus();
                txt_username.SelectAll();
                return;
            }
            if (password == null || password.Equals(""))
            {
                MessageBox.Show("请输入数据库连接密码！");
                txt_password.Focus();
                txt_password.SelectAll();
                return;
            }
            if (database == null || database.Equals(""))
            {
                MessageBox.Show("请输入默认数据库名！");
                txt_database.Focus();
                txt_database.SelectAll();
                return;
            }
            btn_testConnection.Enabled = false;
            btn_testConnection.Text = "Connection...";
            string connectionStr = "server=" + ipAddr + ";database="+ database + ";uid=" + username + ";password=" + password;
            MySqlConnection mysqlConnection = new MySqlConnection(connectionStr);
            try
            {
                mysqlConnection.Open();
                if (mysqlConnection.State == ConnectionState.Open)
                {
                    btn_testConnection.ForeColor = Color.Teal;
                    IsCheckConnection = true;
                    MessageBox.Show("连接成功!你现在可以完善后续工作.","连接成功", MessageBoxButtons.OK);
                    btn_testConnection.Enabled = true;
                    btn_testConnection.Text = "Test Connection";
                }
                else
                {
                    btn_testConnection.ForeColor = Color.Red;
                    IsCheckConnection = false;
                    MessageBox.Show("连接失败!");
                    btn_testConnection.Enabled = true;
                    btn_testConnection.Text = "Test Connection";
                }
            }
            catch(Exception ex)
            {
                btn_testConnection.ForeColor = Color.Red;
                IsCheckConnection = false;
                MessageBox.Show(ex.Message, "连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_testConnection.Enabled = true;
                btn_testConnection.Text = "Test Connection";
            }
           
        }

        /// <summary>
        /// button of start event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //ip address
            string ipAddr = txt_ip.Text;
            //port number
            string port = txt_port.Text;
            //user name
            string username = txt_username.Text;
            //password
            string password = txt_password.Text;
            //database
            string database = txt_database.Text;

            //model package
            string model = txt_modelPath.Text;
            //mapper package
            string mapper = txt_mapperPath.Text;
            //interface package
            string interfc = txt_interfacePath.Text;
            //save path
            string savepath = txt_savePath.Text;

            if (ipAddr == null || ipAddr.Equals(""))
            {
                MessageBox.Show("请输入数据库连接IP！");
                txt_ip.Focus();
                txt_ip.SelectAll();
                return;
            }
            if (port == null || port.Equals(""))
            {
                MessageBox.Show("请输入数据库连接端口！");
                txt_port.Focus();
                txt_port.SelectAll();
                return;
            }
            if (username == null || username.Equals(""))
            {
                MessageBox.Show("请输入数据库连接用户名！");
                txt_username.Focus();
                txt_username.SelectAll();
                return;
            }
            if (password == null || password.Equals(""))
            {
                MessageBox.Show("请输入数据库连接密码！");
                txt_password.Focus();
                txt_password.SelectAll();
                return;
            }
            if (database == null || database.Equals(""))
            {
                MessageBox.Show("请输入默认数据库名！");
                txt_database.Focus();
                txt_database.SelectAll();
                return;
            }
            if (model == null || model.Equals(""))
            {
                MessageBox.Show("请输入Model包路径！");
                txt_modelPath.Focus();
                txt_modelPath.SelectAll();
                return;
            }
            if (mapper == null || mapper.Equals(""))
            {
                MessageBox.Show("请输入Mapper包路径！");
                txt_mapperPath.Focus();
                txt_mapperPath.SelectAll();
                return;
            }
            if (interfc == null || interfc.Equals(""))
            {
                MessageBox.Show("请输入Dao接口包路径！");
                txt_interfacePath.Focus();
                txt_interfacePath.SelectAll();
                return;
            }
            if (savepath == null || savepath.Equals(""))
            {
                MessageBox.Show("请输入需要保存的根目录！");
                txt_savePath.Focus();
                txt_savePath.SelectAll();
                return;
            }



            btn_start.Enabled = false;
            btn_start.Text = "Running...";
            DialogResult result = DialogResult.OK;
            if (!IsCheckConnection)
            {
                result = MessageBox.Show("暂未测试或通过数据库连通性,可能会导致生成失败. 点击确认以继续！","提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            if(!IsCheckConnection && result == DialogResult.OK)
            {
                //continue
                doWork();
            }
            else
            {
                //check is pass the connection test
                if (IsCheckConnection)
                {
                    //continue
                    doWork();
                }
                else
                {
                    //skip
                }
            }
            btn_start.Enabled = true;
            btn_start.Text = "开  始";
        }

        /// <summary>
        /// call and check mybatis's tool to do work
        /// </summary>
        private void doWork()
        {
            //init bat file
            initBat();

            //ip address
            string ipAddr = txt_ip.Text;
            //port number
            string port = txt_port.Text;
            //user name
            string username = txt_username.Text;
            //password
            string password = txt_password.Text;
            //database
            string database = txt_database.Text;

            //model package
            string model = txt_modelPath.Text;
            //mapper package
            string mapper = txt_mapperPath.Text;
            //interface package
            string interfc = txt_interfacePath.Text;
            //save path
            string savepath = txt_savePath.Text;
            //remove comment of checkbox
            bool isRemoveComment = cb_removeComment.Checked;
            //force BigDecimal of checkbox
            bool isForceBigDecimal = cb_forceBigDecimal.Checked;
            //on the setter call trim()
            bool isCallTrim = cb_callTrim.Checked;
            //Real column name to propertie name
            bool isColumnOfPropertiesName = cb_columnOfProperties.Checked;

            string configPath = Application.StartupPath+ "\\Generator\\config.xml";
            string jarPath = Application.StartupPath + "\\Generator\\mysql-connector-java-5.1.25.jar";

            StreamWriter xmlOut = new StreamWriter(configPath, false, Encoding.Default);

            //XmlDocument document = new XmlDocument();
            //StreamReader input = new StreamReader(configPath, Encoding.ASCII);
            //document.Load(input);
            //input.Close();

            //Operate the xml document.
            //XmlElement root = document.DocumentElement;

            ////Get node of <classPathEntry>
            //XmlNode classPathEntryNode = root.FirstChild;

            ////Get node of <context>
            //XmlNode contextNode = root.LastChild;
            ////Get node of <commentGenerator>
            //XmlNode commentGeneratorNode = contextNode.SelectSingleNode("commentGenerator");
            //commentGeneratorNode.InnerXml = "<property name=\"suppressAllComments\" value=\""+ isRemoveComment.ToString().ToLower() + "\" />";


            string connectionUrl = "jdbc:mysql://"+ ipAddr.Trim() + ":"+ port.Trim() + "/"+database.Trim()+"?characterEncoding=utf-8";
            string xmlStr = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                            "<!DOCTYPE generatorConfiguration PUBLIC \"-//mybatis.org//DTD MyBatis Generator Configuration 1.0//EN\"  \"http://mybatis.org/dtd/mybatis-generator-config_1_0.dtd\">" +
                            "<generatorConfiguration>" +
                                "<classPathEntry location=\""+ jarPath + "\" />" +
                                "<context id=\"DB2Tables\" targetRuntime=\"MyBatis3\" defaultModelType=\"flat\" >" +
                                    "<commentGenerator>" +
                                        "<property name=\"suppressAllComments\" value=\""+ isRemoveComment.ToString().ToLower() + "\" />" +
                                    "</commentGenerator>" +
                                    "<jdbcConnection driverClass=\"com.mysql.jdbc.Driver\" connectionURL=\""+ connectionUrl + "\" userId=\""+ username.Trim() +"\" password=\""+ password.Trim() +"\"></jdbcConnection>" +
                                    "<javaTypeResolver>" +
                                        "<property name=\"forceBigDecimals\" value=\""+ isForceBigDecimal.ToString().ToLower() +"\" />" +
                                    "</javaTypeResolver>" +
                                    "<javaModelGenerator targetPackage=\""+model.Trim()+"\" targetProject=\""+ savepath.Trim() + "\">" +
                                        "<property name=\"enableSubPackages\" value=\"false\" />" +
                                        "<property name=\"trimStrings\" value=\""+ isCallTrim.ToString().Trim() + "\" />" +
                                    "</javaModelGenerator>" +
                                    "<sqlMapGenerator targetPackage=\""+mapper.Trim()+"\" targetProject=\""+ savepath.Trim() + "\">" +
                                        "<property name=\"enableSubPackages\" value=\"false\" />" +
                                    "</sqlMapGenerator>" +
                                    "<javaClientGenerator type=\"XMLMAPPER\" targetPackage=\""+interfc.Trim()+"\" targetProject=\""+ savepath.Trim() + "\">" +
                                        "<property name=\"enableSubPackages\" value=\"false\" />" +
                                    "</javaClientGenerator>" +
                                    "<table tableName=\"%\" schema=\"dbo\" enableCountByExample=\"false\" enableUpdateByExample=\"false\" enableDeleteByExample=\"false\" enableSelectByExample=\"false\" selectByExampleQueryId=\"false\">" +
                                        "<property name=\"useActualColumnNames\" value=\""+ isColumnOfPropertiesName.ToString().ToLower().Trim()+ "\" />" +
                                    "</table>" +
                                 "</context>" +
                             "</generatorConfiguration>";
            //root.InnerXml = xmlStr;

            //release resource
            //StreamWriter outStream = new StreamWriter(configPath, false,Encoding.UTF8);
            //document.Save(outStream);
            //outStream.Close();
            xmlOut.Write(xmlStr);
            xmlOut.Flush();
            xmlOut.Close();
            //run the software
            string execPath = Application.StartupPath + "\\Generator\\gener.bat";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(execPath);
            MessageBox.Show("Success");


        }

        /// <summary>
        /// 初始化bat批处理文件
        /// </summary>
        private void initBat()
        {
            string absulutionPath = Application.StartupPath + "\\Generator\\gener.bat";
            string jarPath = Application.StartupPath + "\\Generator\\mybatis-generator-core.jar";
            string configPath = Application.StartupPath + "\\Generator\\config.xml";
            using (StreamWriter writer = new StreamWriter(absulutionPath, false, Encoding.ASCII))
            {
                writer.WriteLine("call java -jar "+ jarPath + " -configfile "+ configPath + " -overwrite");
                //Used to debug
                //writer.WriteLine("pause");
                writer.Flush();
            }

        }

        /// <summary>
        /// open the folder dialog,and return checked dir absulution path
        /// </summary>
        /// <param name="description">on the dialog's description text</param>
        /// <returns></returns>
        private string openDirDialog(string description)
        {
            FolderBrowserDialog folderDialoger = new FolderBrowserDialog();
            folderDialoger.Description = description;
            folderDialoger.ShowDialog();
            return folderDialoger.SelectedPath;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// keywork model of first,auto supplement other textbox content. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_modelPath_TextChanged(object sender, EventArgs e)
        {
            string modelPath = txt_modelPath.Text;
            txt_mapperPath.Text = modelPath;
            txt_interfacePath.Text = modelPath;
        }


        string savePath = null;

        private void btn_savePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowDialog();
            savePath = folderDialog.SelectedPath;
            txt_savePath.Text = savePath;
        }

        /// <summary>
        /// 在线查看当前库下的表以及信息 TODO 将代码移动到新的对话框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_online_Click(object sender, EventArgs e)
        {
            //ip address
            string ipAddr = txt_ip.Text;
            //port number
            string port = txt_port.Text;
            //user name
            string username = txt_username.Text;
            //password
            string password = txt_password.Text;
            //database
            string database = txt_database.Text;
            //
            string connectionStr = "server=" + ipAddr + ";database=" + database + ";uid=" + username + ";password=" + password;
            try
            {
                MySQLUtil helper = new MySQLUtil(connectionStr);
                DataSet ds = helper.ExecuteDataSet("select table_name,create_time,table_rows,avg_row_length,data_length from information_schema.tables where table_schema='"+database+"'");
                foreach (DataTable item in ds.Tables)
                {
                    //获取每一列
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
