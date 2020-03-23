using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_2020.HeThong
{
    public partial class Frm_SaoLuu_PhucHoi : Form
    {
        public Frm_SaoLuu_PhucHoi()
        {
            InitializeComponent();
        }
        public bool saoLuu = false;
        BLL_HeThong bd;
        int count = 0;
        string err = string.Empty;
        private void btnChonFile_Click(object sender, EventArgs e)
        {
            if (saoLuu)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.AddExtension = true;
                save.DefaultExt = "bak";
                save.RestoreDirectory = true;
                save.FileName = string.Format("fileBackup_{0}{1:00}{2:00}{3:00}{4:00}{5:00}",DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second);
                save.Filter = "backup files (*.bak)|*.bak";
                if(save.ShowDialog()==DialogResult.OK)
                {
                    txtpath.Text = save.FileName;
                }
            }else//phuc hoi
            {
                OpenFileDialog open = new OpenFileDialog();
                open.RestoreDirectory = true;
                open.Filter = "backup files (*.bak)|*.bak";
                if(open.ShowDialog()==DialogResult.OK)
                {
                    txtpath.Text = open.FileName;
                }
            }
        }

        private void Frm_SaoLuu_PhucHoi_Load(object sender, EventArgs e)
        {
            bd = new BLL_HeThong();
            if(saoLuu)
            {
                btnSaoLuu.Text = "Sao lưu";
                this.Text = "Thực hiện chức năng sao lưu dữ liệu";
            }
            else
            {
                btnSaoLuu.Text = "Phục hồi";
                this.Text = "Thực hiện chức năng phục hồi dữ liệu";
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            if(saoLuu)
            {
                if (bd.ThucThiSaoLuuDulieu(ref err, ref count, txtpath.Text))
                {
                    MessageBox.Show("Sao lưu thành công");
                    this.Close();
                }
            }
            else
            {
                string sql = string.Format("USE Master \n ALTER DATABASE {0} SET SINGLE_USER WITH ROLLBACK IMMEDIATE" + " RESTORE DATABASE {1} FROM DISK = N'{2}' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10" + " ALTER DATABASE {3} SET MULTI_USER", ClsMain.DatabaseName, ClsMain.DatabaseName, txtpath.Text, ClsMain.DatabaseName);
                if(bd.ThucThiPhucHoiDulieu(ref err,ref count,sql))
                {
                    MessageBox.Show("phục hồi thành công");
                    this.Close();
                }
            }
        }
    }
}
