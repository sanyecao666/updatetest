using SharpUpdate;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private SharpUpdater updater;

        public Form1()
        {
            InitializeComponent();

            label1.Text = ProductName + "\n" + ProductVersion;
            //从服务器测试
            //updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri("http://192.168.3.20:80/MainPageController/Getxml")); //自己测试的地址,这个不是xml中的url，xml中url是软件更新.exe文件从服务器下载的url地址
            //从github测试
            //updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri("https://raw.githubusercontent.com/henryxrl/SharpUpdate/master/project.xml")); //原有作者的url地址
           //从本地更新
            //updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri(new System.IO.FileInfo(@"..\..\..\project.xml").FullName));       // for local testing
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }
    }
}
