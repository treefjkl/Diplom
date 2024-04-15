namespace Diplom
{
    partial class AdmUserList
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonList_users_user = new System.Windows.Forms.Button();
            this.buttonList_users_pro = new System.Windows.Forms.Button();
            this.buttonList_users_admin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1065, 366);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // buttonList_users_user
            // 
            this.buttonList_users_user.Location = new System.Drawing.Point(12, 404);
            this.buttonList_users_user.Name = "buttonList_users_user";
            this.buttonList_users_user.Size = new System.Drawing.Size(186, 34);
            this.buttonList_users_user.TabIndex = 1;
            this.buttonList_users_user.Text = "Пользователи";
            this.buttonList_users_user.UseVisualStyleBackColor = true;
            this.buttonList_users_user.Click += new System.EventHandler(this.buttonList_users_user_Click);
            // 
            // buttonList_users_pro
            // 
            this.buttonList_users_pro.Location = new System.Drawing.Point(223, 404);
            this.buttonList_users_pro.Name = "buttonList_users_pro";
            this.buttonList_users_pro.Size = new System.Drawing.Size(186, 34);
            this.buttonList_users_pro.TabIndex = 2;
            this.buttonList_users_pro.Text = "Опытные пользователи";
            this.buttonList_users_pro.UseVisualStyleBackColor = true;
            this.buttonList_users_pro.Click += new System.EventHandler(this.buttonList_users_pro_Click);
            // 
            // buttonList_users_admin
            // 
            this.buttonList_users_admin.Location = new System.Drawing.Point(432, 404);
            this.buttonList_users_admin.Name = "buttonList_users_admin";
            this.buttonList_users_admin.Size = new System.Drawing.Size(186, 34);
            this.buttonList_users_admin.TabIndex = 3;
            this.buttonList_users_admin.Text = "Администраторы";
            this.buttonList_users_admin.UseVisualStyleBackColor = true;
            this.buttonList_users_admin.Click += new System.EventHandler(this.buttonList_users_admin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(991, 404);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(86, 34);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Закрыть";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Таблица:";
            // 
            // AdmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonList_users_admin);
            this.Controls.Add(this.buttonList_users_pro);
            this.Controls.Add(this.buttonList_users_user);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "AdmUserList";
            this.Text = "AdmUserList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonList_users_user;
        private System.Windows.Forms.Button buttonList_users_pro;
        private System.Windows.Forms.Button buttonList_users_admin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
    }
}