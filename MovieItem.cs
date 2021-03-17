using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPTWinformCrawling
{
    public partial class MovieItem : UserControl
    {
        public MovieItem()
        {
            InitializeComponent();
        }
        
        public string _picture;
        public int _pos;
        
        public string Picture
        {
            get { return _picture; }
            set { _picture = value; loadPic(); }
        }

        public int OriginalPos
        {
            get { return _pos; }
            set { _pos = value; }
        }

        public void loadPic()
        {
            picMovieDisp.Load(_picture);
        }

        private void picMovieDisp_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms["frmWebcrawl"] as frmWebcrawl;
            frm.movieView(_pos);
        }
        
    }
}
