namespace Diplom
{
    partial class MenuAdmin
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
            this.buttonGoDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGoChangeAccess = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUnAuth = new System.Windows.Forms.Button();
            this.buttonUserList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGoDelete
            // 
            this.buttonGoDelete.Location = new System.Drawing.Point(12, 122);
            this.buttonGoDelete.Name = "buttonGoDelete";
            this.buttonGoDelete.Size = new System.Drawing.Size(139, 46);
            this.buttonGoDelete.TabIndex = 1;
            this.buttonGoDelete.Text = "Удалить пользователя";
            this.buttonGoDelete.UseVisualStyleBackColor = true;
            this.buttonGoDelete.Click += new System.EventHandler(this.buttonGoDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Здравствуйте, admin!";
            // 
            // buttonGoChangeAccess
            // 
            this.buttonGoChangeAccess.Location = new System.Drawing.Point(12, 174);
            this.buttonGoChangeAccess.Name = "buttonGoChangeAccess";
            this.buttonGoChangeAccess.Size = new System.Drawing.Size(139, 46);
            this.buttonGoChangeAccess.TabIndex = 3;
            this.buttonGoChangeAccess.Text = "Изменить права пользователя";
            this.buttonGoChangeAccess.UseVisualStyleBackColor = true;
            this.buttonGoChangeAccess.Click += new System.EventHandler(this.buttonGoChangeAccess_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(671, 394);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(117, 44);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Закрыть приложение";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonUnAuth
            // 
            this.buttonUnAuth.Location = new System.Drawing.Point(671, 344);
            this.buttonUnAuth.Name = "buttonUnAuth";
            this.buttonUnAuth.Size = new System.Drawing.Size(117, 44);
            this.buttonUnAuth.TabIndex = 5;
            this.buttonUnAuth.Text = "Выйти из аккаунта";
            this.buttonUnAuth.UseVisualStyleBackColor = true;
            this.buttonUnAuth.Click += new System.EventHandler(this.buttonUnAuth_Click);
            // 
            // buttonUserList
            // 
            this.buttonUserList.Location = new System.Drawing.Point(12, 70);
            this.buttonUserList.Name = "buttonUserList";
            this.buttonUserList.Size = new System.Drawing.Size(139, 46);
            this.buttonUserList.TabIndex = 6;
            this.buttonUserList.Text = "Список пользователей";
            this.buttonUserList.UseVisualStyleBackColor = true;
            this.buttonUserList.Click += new System.EventHandler(this.buttonUserList_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUserList);
            this.Controls.Add(this.buttonUnAuth);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGoChangeAccess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGoDelete);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGoDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGoChangeAccess;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUnAuth;
        private System.Windows.Forms.Button buttonUserList;
    }
}