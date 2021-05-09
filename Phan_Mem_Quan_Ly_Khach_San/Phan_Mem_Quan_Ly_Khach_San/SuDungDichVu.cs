using Controrler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly_Khach_San
{
    public partial class SuDungDichVu : Form
    {
        public SuDungDichVu()
        {
            InitializeComponent();
        }

        public SuDungDichVu(string here)
        {
            InitializeComponent();
            this.here = here;
        }

        AccountController controller = new AccountController();
        private string here;

        private void btnCancelSer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuDungDichVu_Load(object sender, EventArgs e)
        {
            DataTable dichVu = controller.LoadCboDichVu();
            cboTenDV.DataSource = dichVu;
            cboTenDV.DisplayMember = "TenDV";
            cboTenDV.ValueMember = "MaDV";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isNumber(txtSL.Text))
            {
                if (controller.SuDungDichVu(Convert.ToInt32(here), Convert.ToInt32(cboTenDV.SelectedValue.ToString()), Convert.ToInt32(txtSL.Text)))
                {
                    MessageBox.Show("OK");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi vui lòng thử lại sau hoặc liên hệ với quản trị");
                }
            }
            else
            {
                MessageBox.Show("Số Lượng phải là số!!");
            }

        }
        public bool isNumber(string str)
        {
            foreach (Char c in str)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
