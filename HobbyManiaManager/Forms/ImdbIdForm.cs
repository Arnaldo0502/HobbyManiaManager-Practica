using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HobbyManiaManager.Forms
{
    public partial class ImdbIdForm : Form
    {

        private string _imdbId;

        public ImdbIdForm(string imdbId)
        {
            InitializeComponent();
            _imdbId = imdbId;
        }

        private void webViewImdbId_Click(object sender, EventArgs e)
        {

        }

        private void ImdbIdForm_Load(object sender, EventArgs e)
        {
            string url = $"https://www.imdb.com/title/{_imdbId}";
            webViewImdbId.Source = new Uri(url);
        }
    }
}
