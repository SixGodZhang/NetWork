using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class 自定义浏览器 : Form
    {
        public 自定义浏览器()
        {
            InitializeComponent();
            InitializeWebPage();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            wb.Navigated += OnURLChanged;
        }

        private void OnURLChanged(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlText.Text = wb.Url.ToString();
        }

        private void InitializeWebPage()
        {
            wb.Navigate("http://www.baidu.com");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void moveBtnClick(object sender, EventArgs e)
        {
            string url = urlText.Text;
            wb.Navigate(url);
        }

        private void OnPreBtnClick(object sender, EventArgs e)
        {
            if (wb.CanGoBack)
                wb.GoBack();
            else
                MessageBox.Show("前面没有内容了!");
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (wb.CanGoForward)
                wb.GoForward();
            else
                MessageBox.Show("后面没有内容了!");
        }
    }
}
