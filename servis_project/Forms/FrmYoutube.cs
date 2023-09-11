using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servis_project.Forms
{
    public partial class FrmYoutube : Form
    {
        string _url;
        public string VideoID
        {
            get 
            {
                var yMatch = new Regex(@"http(?:s ?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(_url);
                return yMatch.Success ? yMatch.Groups[1].Value : String.Empty;
            }
        }
        public FrmYoutube()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            _url = txtLink.Text;
            webBrowser1.DocumentText = String.Format("<meta http-equiv=\"X-UA-Compatible\" Content=\"IE=Edge\" /> " +
                "<iframe width=\"100%\" height=\"380\" src=\"https://www.youtube.com/embed/{0}?autoplay=1\"" +
                "title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>", VideoID);
            //string html = "<html><head>";
            //html += " <meta content='IE=Edge' http-equiv='X-UA-Compatible'/> ";
            //html += " <iframe id='video' src= https://www.youtube.com/embed/{0}?autoplay=1\' width='600' height='300' frameborder='0' allowfullscreen></iframe> ";  
            //html += " </head></html> ";
            //this.webBrowser1.DocumentText = string.Format(html, txtLink.Text.Split('=')[1]);
        }
    }
}
