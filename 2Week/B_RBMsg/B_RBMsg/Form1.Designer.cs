﻿namespace B_RBMsg
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
            this.gbOption1 = new System.Windows.Forms.GroupBox();
            this.gbOption2 = new System.Windows.Forms.GroupBox();
            this.rbOK = new System.Windows.Forms.RadioButton();
            this.rbOKCancel = new System.Windows.Forms.RadioButton();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.rbInformation = new System.Windows.Forms.RadioButton();
            this.rbQuestion = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbOption1.SuspendLayout();
            this.gbOption2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOption1
            // 
            this.gbOption1.BackColor = System.Drawing.Color.Yellow;
            this.gbOption1.Controls.Add(this.rbYesNo);
            this.gbOption1.Controls.Add(this.rbOKCancel);
            this.gbOption1.Controls.Add(this.rbOK);
            this.gbOption1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbOption1.Location = new System.Drawing.Point(93, 123);
            this.gbOption1.Name = "gbOption1";
            this.gbOption1.Size = new System.Drawing.Size(211, 196);
            this.gbOption1.TabIndex = 0;
            this.gbOption1.TabStop = false;
            this.gbOption1.Text = "Type";
            // 
            // gbOption2
            // 
            this.gbOption2.BackColor = System.Drawing.Color.Moccasin;
            this.gbOption2.Controls.Add(this.rbQuestion);
            this.gbOption2.Controls.Add(this.rbInformation);
            this.gbOption2.Controls.Add(this.rbError);
            this.gbOption2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbOption2.Location = new System.Drawing.Point(364, 123);
            this.gbOption2.Name = "gbOption2";
            this.gbOption2.Size = new System.Drawing.Size(210, 196);
            this.gbOption2.TabIndex = 1;
            this.gbOption2.TabStop = false;
            this.gbOption2.Text = "Icon";
            // 
            // rbOK
            // 
            this.rbOK.AutoSize = true;
            this.rbOK.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbOK.Location = new System.Drawing.Point(25, 43);
            this.rbOK.Name = "rbOK";
            this.rbOK.Size = new System.Drawing.Size(47, 19);
            this.rbOK.TabIndex = 0;
            this.rbOK.TabStop = true;
            this.rbOK.Text = "OK";
            this.rbOK.UseVisualStyleBackColor = true;
            // 
            // rbOKCancel
            // 
            this.rbOKCancel.AutoSize = true;
            this.rbOKCancel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbOKCancel.Location = new System.Drawing.Point(25, 92);
            this.rbOKCancel.Name = "rbOKCancel";
            this.rbOKCancel.Size = new System.Drawing.Size(98, 19);
            this.rbOKCancel.TabIndex = 1;
            this.rbOKCancel.TabStop = true;
            this.rbOKCancel.Text = "OKCancel";
            this.rbOKCancel.UseVisualStyleBackColor = true;
            // 
            // rbYesNo
            // 
            this.rbYesNo.AutoSize = true;
            this.rbYesNo.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbYesNo.Location = new System.Drawing.Point(25, 140);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(72, 19);
            this.rbYesNo.TabIndex = 2;
            this.rbYesNo.TabStop = true;
            this.rbYesNo.Text = "YesNo";
            this.rbYesNo.UseVisualStyleBackColor = true;
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbError.Location = new System.Drawing.Point(31, 43);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(60, 19);
            this.rbError.TabIndex = 0;
            this.rbError.TabStop = true;
            this.rbError.Text = "Error";
            this.rbError.UseVisualStyleBackColor = true;
            // 
            // rbInformation
            // 
            this.rbInformation.AutoSize = true;
            this.rbInformation.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbInformation.Location = new System.Drawing.Point(31, 92);
            this.rbInformation.Name = "rbInformation";
            this.rbInformation.Size = new System.Drawing.Size(107, 19);
            this.rbInformation.TabIndex = 1;
            this.rbInformation.TabStop = true;
            this.rbInformation.Text = "Information";
            this.rbInformation.UseVisualStyleBackColor = true;
            // 
            // rbQuestion
            // 
            this.rbQuestion.AutoSize = true;
            this.rbQuestion.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbQuestion.Location = new System.Drawing.Point(31, 140);
            this.rbQuestion.Name = "rbQuestion";
            this.rbQuestion.Size = new System.Drawing.Size(93, 19);
            this.rbQuestion.TabIndex = 2;
            this.rbQuestion.TabStop = true;
            this.rbQuestion.Text = "Question";
            this.rbQuestion.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShow.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShow.Location = new System.Drawing.Point(652, 283);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gbOption2);
            this.Controls.Add(this.gbOption1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "메시지 박스 보기";
            this.gbOption1.ResumeLayout(false);
            this.gbOption1.PerformLayout();
            this.gbOption2.ResumeLayout(false);
            this.gbOption2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOption1;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.RadioButton rbOKCancel;
        private System.Windows.Forms.RadioButton rbOK;
        private System.Windows.Forms.GroupBox gbOption2;
        private System.Windows.Forms.RadioButton rbQuestion;
        private System.Windows.Forms.RadioButton rbInformation;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.Button btnShow;
    }
}

