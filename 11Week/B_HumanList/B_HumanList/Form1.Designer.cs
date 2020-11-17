namespace B_HumanList
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
            this.plGroup = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lvList = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // plGroup
            // 
            this.plGroup.BackColor = System.Drawing.Color.White;
            this.plGroup.Controls.Add(this.txtName);
            this.plGroup.Controls.Add(this.btnDel);
            this.plGroup.Controls.Add(this.lblPhone);
            this.plGroup.Controls.Add(this.txtPhone);
            this.plGroup.Controls.Add(this.btnModify);
            this.plGroup.Controls.Add(this.txtAge);
            this.plGroup.Controls.Add(this.btnSave);
            this.plGroup.Controls.Add(this.txtJob);
            this.plGroup.Controls.Add(this.lblJob);
            this.plGroup.Controls.Add(this.lblName);
            this.plGroup.Controls.Add(this.lblAge);
            this.plGroup.Location = new System.Drawing.Point(28, 290);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(516, 100);
            this.plGroup.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(86, 21);
            this.txtName.TabIndex = 4;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(399, 66);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(158, 20);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 12);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "전화번호";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(55, 68);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(86, 21);
            this.txtPhone.TabIndex = 5;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(399, 23);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(217, 20);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(86, 21);
            this.txtAge.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(309, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 66);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(217, 68);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(86, 21);
            this.txtJob.TabIndex = 7;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(173, 70);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(29, 12);
            this.lblJob.TabIndex = 3;
            this.lblJob.Text = "직업";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(11, 73);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 12);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "나이";
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chName,
            this.chAge,
            this.chPhone,
            this.chJob});
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(28, 23);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(516, 209);
            this.lvList.TabIndex = 11;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.Click += new System.EventHandler(this.lvList_Click);
            // 
            // chId
            // 
            this.chId.Text = "구분";
            this.chId.Width = 50;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 80;
            // 
            // chAge
            // 
            this.chAge.Text = "나이";
            // 
            // chPhone
            // 
            this.chPhone.Text = "전화번호";
            this.chPhone.Width = 150;
            // 
            // chJob
            // 
            this.chJob.Text = "직업";
            this.chJob.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 422);
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.plGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "인명부";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plGroup.ResumeLayout(false);
            this.plGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chJob;
    }
}

