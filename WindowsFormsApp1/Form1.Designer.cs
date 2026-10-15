namespace WindowsFormsApp1
{
    partial class MainForm_Load
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControlName1 = new WindowsFormsApp1.FolderforModel.UserControlName();
            this.userControlName2 = new WindowsFormsApp1.FolderforModel.UserControlName();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControlName1
            // 
            this.userControlName1.Location = new System.Drawing.Point(70, 43);
            this.userControlName1.Name = "userControlName1";
            this.userControlName1.Size = new System.Drawing.Size(450, 561);
            this.userControlName1.TabIndex = 0;
            this.userControlName1.Load += new System.EventHandler(this.userControlName1_Load);
            // 
            // userControlName2
            // 
            this.userControlName2.Location = new System.Drawing.Point(568, 43);
            this.userControlName2.Name = "userControlName2";
            this.userControlName2.Size = new System.Drawing.Size(450, 561);
            this.userControlName2.TabIndex = 1;
            this.userControlName2.Load += new System.EventHandler(this.userControlName2_Load);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(12, 81);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(52, 447);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(1024, 81);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(52, 447);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // MainForm_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 654);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.userControlName2);
            this.Controls.Add(this.userControlName1);
            this.Name = "MainForm_Load";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FolderforModel.UserControlName userControlName1;
        private FolderforModel.UserControlName userControlName2;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
    }
}

