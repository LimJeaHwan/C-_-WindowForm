namespace B_FormView
{
    partial class Form1
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
            this.btnMadal = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMadal
            // 
            this.btnMadal.BackColor = System.Drawing.Color.MistyRose;
            this.btnMadal.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMadal.ForeColor = System.Drawing.Color.Red;
            this.btnMadal.Location = new System.Drawing.Point(95, 77);
            this.btnMadal.Name = "btnMadal";
            this.btnMadal.Size = new System.Drawing.Size(108, 36);
            this.btnMadal.TabIndex = 0;
            this.btnMadal.Text = "모달";
            this.btnMadal.UseVisualStyleBackColor = false;
            this.btnMadal.Click += new System.EventHandler(this.btnMadal_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModaless.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModaless.ForeColor = System.Drawing.Color.LightGray;
            this.btnModaless.Location = new System.Drawing.Point(95, 206);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(108, 30);
            this.btnModaless.TabIndex = 0;
            this.btnModaless.Text = "모달리스";
            this.btnModaless.UseVisualStyleBackColor = false;
            this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 362);
            this.Controls.Add(this.btnModaless);
            this.Controls.Add(this.btnMadal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "폼 꾸미기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMadal;
        private System.Windows.Forms.Button btnModaless;
    }
}

