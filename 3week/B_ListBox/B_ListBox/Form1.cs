using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string OrgStr = ""; //결과 : 저장

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblResult.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtList.Text != "")
            {
                this.lbView.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
            }
            else
            {
                MessageBox.Show("아이템을 입력하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtList.Focus();
            }
        }

        private void lbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbView.SelectedItem == null)
            {
                this.lblResult.Text = OrgStr;
            }
            else
            {
                this.lblResult.Text = OrgStr + this.lbView.SelectedItem.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
            this.lbView.Items.Remove(this.lbView.SelectedItem);

        }
    }
}
