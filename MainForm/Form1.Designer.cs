namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_InPutStudent = new System.Windows.Forms.Button();
            this.button_Outstudent = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_InPutStudent
            // 
            this.button_InPutStudent.Location = new System.Drawing.Point(84, 195);
            this.button_InPutStudent.Name = "button_InPutStudent";
            this.button_InPutStudent.Size = new System.Drawing.Size(287, 107);
            this.button_InPutStudent.TabIndex = 0;
            this.button_InPutStudent.Text = "학생입력";
            this.button_InPutStudent.UseVisualStyleBackColor = true;
            this.button_InPutStudent.Click += new System.EventHandler(this.button_InPutStudent_Click);
            // 
            // button_Outstudent
            // 
            this.button_Outstudent.Location = new System.Drawing.Point(479, 195);
            this.button_Outstudent.Name = "button_Outstudent";
            this.button_Outstudent.Size = new System.Drawing.Size(287, 107);
            this.button_Outstudent.TabIndex = 1;
            this.button_Outstudent.Text = "학생정보출력";
            this.button_Outstudent.UseVisualStyleBackColor = true;
            this.button_Outstudent.Click += new System.EventHandler(this.button_Outstudent_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(84, 418);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(287, 96);
            this.button_Reset.TabIndex = 2;
            this.button_Reset.Text = "초기화";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 92);
            this.button1.TabIndex = 3;
            this.button1.Text = "파일불러오기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Outstudent);
            this.Controls.Add(this.button_InPutStudent);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_InPutStudent;
        private System.Windows.Forms.Button button_Outstudent;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button1;
    }
}

