namespace Diplom
{
    partial class AdmDeleteUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonList_users_admin = new System.Windows.Forms.Button();
            this.buttonList_users_pro = new System.Windows.Forms.Button();
            this.buttonList_users_user = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonDeleteUser_users = new System.Windows.Forms.Button();
            this.buttonDeleteUser_pro = new System.Windows.Forms.Button();
            this.buttonDeleteUser_admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Таблица:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(702, 404);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(86, 34);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "Закрыть";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonList_users_admin
            // 
            this.buttonList_users_admin.Location = new System.Drawing.Point(432, 404);
            this.buttonList_users_admin.Name = "buttonList_users_admin";
            this.buttonList_users_admin.Size = new System.Drawing.Size(186, 34);
            this.buttonList_users_admin.TabIndex = 22;
            this.buttonList_users_admin.Text = "Администраторы";
            this.buttonList_users_admin.UseVisualStyleBackColor = true;
            this.buttonList_users_admin.Click += new System.EventHandler(this.buttonList_users_admin_Click);
            // 
            // buttonList_users_pro
            // 
            this.buttonList_users_pro.Location = new System.Drawing.Point(223, 404);
            this.buttonList_users_pro.Name = "buttonList_users_pro";
            this.buttonList_users_pro.Size = new System.Drawing.Size(186, 34);
            this.buttonList_users_pro.TabIndex = 21;
            this.buttonList_users_pro.Text = "Опытные пользователи";
            this.buttonList_users_pro.UseVisualStyleBackColor = true;
            this.buttonList_users_pro.Click += new System.EventHandler(this.buttonList_users_pro_Click);
            // 
            // buttonList_users_user
            // 
            this.buttonList_users_user.Location = new System.Drawing.Point(12, 404);
            this.buttonList_users_user.Name = "buttonList_users_user";
            this.buttonList_users_user.Size = new System.Drawing.Size(186, 34);
            this.buttonList_users_user.TabIndex = 20;
            this.buttonList_users_user.Text = "Пользователи";
            this.buttonList_users_user.UseVisualStyleBackColor = true;
            this.buttonList_users_user.Click += new System.EventHandler(this.buttonList_users_user_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(561, 366);
            this.dataGridViewUsers.TabIndex = 19;
            // 
            // buttonDeleteUser_users
            // 
            this.buttonDeleteUser_users.Location = new System.Drawing.Point(590, 333);
            this.buttonDeleteUser_users.Name = "buttonDeleteUser_users";
            this.buttonDeleteUser_users.Size = new System.Drawing.Size(198, 34);
            this.buttonDeleteUser_users.TabIndex = 25;
            this.buttonDeleteUser_users.Text = "Удалить пользователя";
            this.buttonDeleteUser_users.UseVisualStyleBackColor = true;
            this.buttonDeleteUser_users.Click += new System.EventHandler(this.buttonDeleteUser_users_Click);
            // 
            // buttonDeleteUser_pro
            // 
            this.buttonDeleteUser_pro.Location = new System.Drawing.Point(590, 333);
            this.buttonDeleteUser_pro.Name = "buttonDeleteUser_pro";
            this.buttonDeleteUser_pro.Size = new System.Drawing.Size(198, 34);
            this.buttonDeleteUser_pro.TabIndex = 26;
            this.buttonDeleteUser_pro.Text = "Удалить пользователя";
            this.buttonDeleteUser_pro.UseVisualStyleBackColor = true;
            this.buttonDeleteUser_pro.Click += new System.EventHandler(this.buttonDeleteUser_pro_Click);
            // 
            // buttonDeleteUser_admin
            // 
            this.buttonDeleteUser_admin.Location = new System.Drawing.Point(590, 333);
            this.buttonDeleteUser_admin.Name = "buttonDeleteUser_admin";
            this.buttonDeleteUser_admin.Size = new System.Drawing.Size(198, 34);
            this.buttonDeleteUser_admin.TabIndex = 27;
            this.buttonDeleteUser_admin.Text = "Удалить пользователя";
            this.buttonDeleteUser_admin.UseVisualStyleBackColor = true;
            this.buttonDeleteUser_admin.Click += new System.EventHandler(this.buttonDeleteUser_admin_Click);
            // 
            // AdmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteUser_admin);
            this.Controls.Add(this.buttonDeleteUser_pro);
            this.Controls.Add(this.buttonDeleteUser_users);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonList_users_admin);
            this.Controls.Add(this.buttonList_users_pro);
            this.Controls.Add(this.buttonList_users_user);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "AdmDeleteUser";
            this.Text = "AdmDeleteUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonList_users_admin;
        private System.Windows.Forms.Button buttonList_users_pro;
        private System.Windows.Forms.Button buttonList_users_user;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonDeleteUser_users;
        private System.Windows.Forms.Button buttonDeleteUser_pro;
        private System.Windows.Forms.Button buttonDeleteUser_admin;
    }
}