using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace GeckoWebBrowser
{

    public partial class Form1 : Form
    {

        //运行flash  屏蔽错误alert弹窗。设置cookie
        public Form1()
        {
            //如果没有Firefox的话，不添加控件，不加载这句，不会出错
            Gecko.Xpcom.Initialize("Firefox");
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            geckoWebBrowser1.LoadHtml("", null);
            geckoWebBrowser1.DocumentCompleted += geckoWebBrowser1_DocumentCompleted;
            geckoWebBrowser1.CreateWindow += geckoWebBrowser1_CreateWindow;

        }

        void geckoWebBrowser1_CreateWindow(object sender, Gecko.GeckoCreateWindowEventArgs e)
        {
            Gecko.GeckoWebBrowser gwb = (Gecko.GeckoWebBrowser)sender;
            gwb.Navigate(e.Uri);//跳转新url
            e.Cancel = true;//禁止弹窗
        }

        void geckoWebBrowser1_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strHtml = @"
<html>
	<head>
		<title></title>
		<meta charset='UTF-8' />
	</head>
	<body>
123
	</body>
	<script type='text/javascript'> 
		alert('123');
		asd
	</script>
</html>

";
            geckoWebBrowser1.Document.Cookie = "diycookie=myjackey";
            geckoWebBrowser1.LoadHtml(strHtml, null);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate("https://www.dianping.com/");
        }
    }
}
