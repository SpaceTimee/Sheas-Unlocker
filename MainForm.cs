using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sheath_Unblocker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UnblockButton_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(PathTextBox.Text))
                Text = "解锁中...";
            else
                Text = "文件路径错误";

            Process unblockProcess = new System.Diagnostics.Process();

            #region 配置unblockProcess的参数
            unblockProcess.StartInfo.FileName = "cmd.exe";
            unblockProcess.StartInfo.Arguments = RecurseCheckBox.Checked ?
                @"/c cd /d """ + PathTextBox.Text + @""" && powershell -command ""Get-ChildItem -Recurse | Unblock-File""" :
                @"/c cd /d """ + PathTextBox.Text + @""" && powershell -command ""Get-ChildItem | Unblock-File""";
            unblockProcess.StartInfo.CreateNoWindow = true; //不显示程序窗口 
            unblockProcess.StartInfo.UseShellExecute = false;
            unblockProcess.StartInfo.RedirectStandardInput = true;  //接受调用程序的输入信息 
            unblockProcess.StartInfo.RedirectStandardOutput = true; //由调用程序获取输出信息 
            //unblockProcess.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            #endregion

            unblockProcess.Start();
            unblockProcess.WaitForExit(60 * 1000);
            System.IO.StreamReader streamReader = unblockProcess.StandardOutput;
            string feedBack = streamReader.ReadToEnd();
            unblockProcess.Close();

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
            {
                PathTextBox.Text = folderBrowserDialog.SelectedPath; //路径
            }
        }
    }
}
