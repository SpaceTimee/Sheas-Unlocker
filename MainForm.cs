using System;
using System.Windows.Forms;
using SheasCore;

namespace Sheas_Unlocker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UnlockButton_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(PathTextBox.Text))
                Text = "解锁中...";
            else
            {
                Text = "文件路径错误";
                return;
            }

            string feedBack = "未知错误";
            if (RecurseCheckBox.Checked)
                feedBack = PowerShell.PowerShellRun(PathTextBox.Text, @"Get-ChildItem -Recurse | Unblock-File");
            else
                feedBack = PowerShell.PowerShellRun(PathTextBox.Text, @"Get-ChildItem | Unblock-File");

            if (feedBack == "")
                Text = "解锁成功";
            else
                Text = "解锁失败";  //feedBack
        }
        private void NavigateButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            #region 配置folderBrowserDialog的参数
            folderBrowserDialog.Description = "Sheath Importer";
            folderBrowserDialog.UseDescriptionForTitle = true;  //修改标题
            folderBrowserDialog.AutoUpgradeEnabled = true;   //自动升级对话框样式
            #endregion

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                PathTextBox.Text = folderBrowserDialog.SelectedPath; //路径
        }
    }
}
