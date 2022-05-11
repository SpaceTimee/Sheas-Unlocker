using System;
using System.IO;
using System.Windows.Forms;

namespace Sheas_Unlocker
{
    internal partial class MainForm : Form
    {
        internal MainForm() => InitializeComponent();

        private void UnlockButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(PathBox.Text))
                    throw new Exception("文件路径错误");

                Text = "解锁中...";

                PowerShell powerShell = new(this);
                if (RecurseCheckBox.Checked)
                    powerShell.ShellRun(PathBox.Text, @"Get-ChildItem -Recurse | Unblock-File");
                else
                    powerShell.ShellRun(PathBox.Text, @"Get-ChildItem | Unblock-File");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); Text = "解锁失败"; return; }
        }
        private void NavigateButton_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new();

                #region 配置folderBrowserDialog的参数
                folderBrowserDialog.Description = "Sheath Importer";
                folderBrowserDialog.UseDescriptionForTitle = true;  //修改标题
                folderBrowserDialog.AutoUpgradeEnabled = true;   //自动升级对话框样式
                #endregion 配置folderBrowserDialog的参数

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    PathBox.Text = folderBrowserDialog.SelectedPath; //路径
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); Text = "浏览失败"; return; }
        }
    }
}