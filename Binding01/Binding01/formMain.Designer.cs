namespace Binding01
{
    partial class formMain
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
            this.btnValue = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.cbTest = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(274, 27);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(150, 55);
            this.btnValue.TabIndex = 0;
            this.btnValue.Text = "Show the Value";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(274, 88);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(150, 55);
            this.btnText.TabIndex = 1;
            this.btnText.Text = "Show the Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // cbTest
            // 
            this.cbTest.FormattingEnabled = true;
            this.cbTest.Location = new System.Drawing.Point(36, 77);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(204, 23);
            this.cbTest.TabIndex = 2;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 178);
            this.Controls.Add(this.cbTest);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnValue);
            this.Name = "formMain";
            this.Text = "TEST";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.ComboBox cbTest;
    }
}

