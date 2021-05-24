using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTPWEBREQUEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread refeshHTML = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    addHTML();
                    Thread.Sleep(30000);
                }
            }));
            refeshHTML.IsBackground = true;
            Thread coutdown = new Thread(new ThreadStart(() => {
                for(int i=30; i>=0;i--)
                {
                    lb_time.Text = i.ToString()+"s";
                    Thread.Sleep(1000);
                    if (i == 0)
                        i = 30;
                   
                }
            }));
            refeshHTML.IsBackground = true;
            coutdown.IsBackground = true;
            coutdown.Start();
            refeshHTML.Start();
        }
        private void addHTML()
        {
            tb_bitcoin.Text = tb_eere.Text = tb_tt.Text= richTextBox1.Text = "Wait for loading";

            string data = getHTML();
            richTextBox1.Text = data;

            HtmlAgilityPack.HtmlDocument hd = new HtmlAgilityPack.HtmlDocument();
            hd.LoadHtml(data);

            string bitcoin = hd.DocumentNode.SelectSingleNode("//table[@class='table table-bordered table-hover table-striped tygia-table crypto-table']//tbody//tr[1]//td[3]").InnerHtml.ToString();
            tb_bitcoin.Text = bitcoin;
            string Ethereum = hd.DocumentNode.SelectSingleNode("//table[@class='table table-bordered table-hover table-striped tygia-table crypto-table']//tbody//tr[2]//td[3]").InnerHtml.ToString();
            tb_eere.Text = Ethereum;
            string Tether = hd.DocumentNode.SelectSingleNode("//table[@class='table table-bordered table-hover table-striped tygia-table crypto-table']//tbody//tr[3]//td[3]").InnerHtml.ToString();
            tb_tt.Text = Tether;
        }
        private string getHTML()
        {
            string szURL = "https://tygia.com.vn/tien-dien-tu/";
            // Tạo request URL.
            WebRequest request = WebRequest.Create(szURL);
            // Nhận phản hồi.
            WebResponse response = request.GetResponse();
            // Nhận luồn chứa nội dung trả về từ server.
            Stream dataStream = response.GetResponseStream();
            // Mỡ stream serder để dễ truy cập.
            StreamReader reader = new StreamReader(dataStream);
            // Đọc du liệu.
            string responseFromServer = reader.ReadToEnd();
            // Đóng kết nối.
            response.Close();
            return responseFromServer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread resfreshButton = new Thread(() =>
             {
                 addHTML();
             });
            resfreshButton.IsBackground = true;
            resfreshButton.Start();
        }
    }
}
