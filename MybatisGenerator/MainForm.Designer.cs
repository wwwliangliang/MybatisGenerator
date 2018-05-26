namespace MybatisGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_database = new System.Windows.Forms.TextBox();
            this.btn_testConnection = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_columnOfProperties = new System.Windows.Forms.CheckBox();
            this.cb_callTrim = new System.Windows.Forms.CheckBox();
            this.cb_forceBigDecimal = new System.Windows.Forms.CheckBox();
            this.cb_removeComment = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_savePath = new System.Windows.Forms.TextBox();
            this.btn_savePath = new System.Windows.Forms.Button();
            this.txt_interfacePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mapperPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_modelPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_database);
            this.groupBox1.Controls.Add(this.btn_testConnection);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ip);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库配置";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(0, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Database：";
            // 
            // txt_database
            // 
            this.txt_database.Location = new System.Drawing.Point(97, 159);
            this.txt_database.Name = "txt_database";
            this.txt_database.Size = new System.Drawing.Size(246, 27);
            this.txt_database.TabIndex = 7;
            // 
            // btn_testConnection
            // 
            this.btn_testConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_testConnection.ForeColor = System.Drawing.Color.Teal;
            this.btn_testConnection.Location = new System.Drawing.Point(189, 192);
            this.btn_testConnection.Name = "btn_testConnection";
            this.btn_testConnection.Size = new System.Drawing.Size(154, 31);
            this.btn_testConnection.TabIndex = 8;
            this.btn_testConnection.Text = "Test Connection";
            this.btn_testConnection.UseVisualStyleBackColor = true;
            this.btn_testConnection.Click += new System.EventHandler(this.btn_testConnection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(37, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "密码：";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(97, 126);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(246, 27);
            this.txt_password.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "用户名：";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(97, 93);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(246, 27);
            this.txt_username.TabIndex = 4;
            this.txt_username.Text = "root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口：";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(97, 60);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(246, 27);
            this.txt_port.TabIndex = 2;
            this.txt_port.Text = "3306";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP地址：";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(97, 27);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(246, 27);
            this.txt_ip.TabIndex = 0;
            this.txt_ip.Text = "127.0.0.1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_columnOfProperties);
            this.groupBox2.Controls.Add(this.cb_callTrim);
            this.groupBox2.Controls.Add(this.cb_forceBigDecimal);
            this.groupBox2.Controls.Add(this.cb_removeComment);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(0, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配置中心";
            // 
            // cb_columnOfProperties
            // 
            this.cb_columnOfProperties.AutoSize = true;
            this.cb_columnOfProperties.ForeColor = System.Drawing.Color.Teal;
            this.cb_columnOfProperties.Location = new System.Drawing.Point(24, 86);
            this.cb_columnOfProperties.Name = "cb_columnOfProperties";
            this.cb_columnOfProperties.Size = new System.Drawing.Size(166, 24);
            this.cb_columnOfProperties.TabIndex = 6;
            this.cb_columnOfProperties.Text = "实际列名作为属性名";
            this.cb_columnOfProperties.UseVisualStyleBackColor = true;
            // 
            // cb_callTrim
            // 
            this.cb_callTrim.AutoSize = true;
            this.cb_callTrim.ForeColor = System.Drawing.Color.Teal;
            this.cb_callTrim.Location = new System.Drawing.Point(24, 56);
            this.cb_callTrim.Name = "cb_callTrim";
            this.cb_callTrim.Size = new System.Drawing.Size(194, 24);
            this.cb_callTrim.TabIndex = 5;
            this.cb_callTrim.Text = "在Setter方法调用Trim()";
            this.cb_callTrim.UseVisualStyleBackColor = true;
            // 
            // cb_forceBigDecimal
            // 
            this.cb_forceBigDecimal.AutoSize = true;
            this.cb_forceBigDecimal.ForeColor = System.Drawing.Color.Teal;
            this.cb_forceBigDecimal.Location = new System.Drawing.Point(115, 26);
            this.cb_forceBigDecimal.Name = "cb_forceBigDecimal";
            this.cb_forceBigDecimal.Size = new System.Drawing.Size(142, 24);
            this.cb_forceBigDecimal.TabIndex = 4;
            this.cb_forceBigDecimal.Text = "强制BigDecimal";
            this.cb_forceBigDecimal.UseVisualStyleBackColor = true;
            // 
            // cb_removeComment
            // 
            this.cb_removeComment.AutoSize = true;
            this.cb_removeComment.Checked = true;
            this.cb_removeComment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_removeComment.ForeColor = System.Drawing.Color.Teal;
            this.cb_removeComment.Location = new System.Drawing.Point(24, 26);
            this.cb_removeComment.Name = "cb_removeComment";
            this.cb_removeComment.Size = new System.Drawing.Size(91, 24);
            this.cb_removeComment.TabIndex = 3;
            this.cb_removeComment.Text = "去除注释";
            this.cb_removeComment.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_savePath);
            this.groupBox3.Controls.Add(this.btn_savePath);
            this.groupBox3.Controls.Add(this.txt_interfacePath);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_mapperPath);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_modelPath);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(0, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 167);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "包路径(Java实际包路径)";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txt_savePath
            // 
            this.txt_savePath.ForeColor = System.Drawing.Color.Red;
            this.txt_savePath.Location = new System.Drawing.Point(97, 131);
            this.txt_savePath.Name = "txt_savePath";
            this.txt_savePath.Size = new System.Drawing.Size(246, 27);
            this.txt_savePath.TabIndex = 16;
            // 
            // btn_savePath
            // 
            this.btn_savePath.Location = new System.Drawing.Point(19, 131);
            this.btn_savePath.Name = "btn_savePath";
            this.btn_savePath.Size = new System.Drawing.Size(72, 27);
            this.btn_savePath.TabIndex = 15;
            this.btn_savePath.Text = "保存至";
            this.btn_savePath.UseVisualStyleBackColor = true;
            this.btn_savePath.Click += new System.EventHandler(this.btn_savePath_Click);
            // 
            // txt_interfacePath
            // 
            this.txt_interfacePath.ForeColor = System.Drawing.Color.Red;
            this.txt_interfacePath.Location = new System.Drawing.Point(97, 96);
            this.txt_interfacePath.Name = "txt_interfacePath";
            this.txt_interfacePath.Size = new System.Drawing.Size(246, 27);
            this.txt_interfacePath.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(14, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Interface:";
            // 
            // txt_mapperPath
            // 
            this.txt_mapperPath.ForeColor = System.Drawing.Color.Red;
            this.txt_mapperPath.Location = new System.Drawing.Point(97, 62);
            this.txt_mapperPath.Name = "txt_mapperPath";
            this.txt_mapperPath.Size = new System.Drawing.Size(246, 27);
            this.txt_mapperPath.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(20, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mapper:";
            // 
            // txt_modelPath
            // 
            this.txt_modelPath.ForeColor = System.Drawing.Color.Red;
            this.txt_modelPath.Location = new System.Drawing.Point(97, 29);
            this.txt_modelPath.Name = "txt_modelPath";
            this.txt_modelPath.Size = new System.Drawing.Size(246, 27);
            this.txt_modelPath.TabIndex = 7;
            this.txt_modelPath.TextChanged += new System.EventHandler(this.txt_modelPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(30, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Model:";
            // 
            // btn_start
            // 
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.ForeColor = System.Drawing.Color.Tomato;
            this.btn_start.Location = new System.Drawing.Point(286, 587);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(91, 27);
            this.btn_start.TabIndex = 17;
            this.btn_start.Text = "开  始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(0, 587);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Copyright © 2018";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(387, 620);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mybatis Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_testConnection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_removeComment;
        private System.Windows.Forms.CheckBox cb_forceBigDecimal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_modelPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_interfacePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mapperPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_callTrim;
        private System.Windows.Forms.CheckBox cb_columnOfProperties;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_database;
        private System.Windows.Forms.TextBox txt_savePath;
        private System.Windows.Forms.Button btn_savePath;
    }
}

