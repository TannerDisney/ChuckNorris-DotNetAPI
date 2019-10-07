using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace WinFormNorrisAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateCatagories();
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void PopulateCatagories()
        {
            IEnumerable<String> categories = await ChuckNorrisClient.GetCategories();
            CboCategory.DataSource = categories;
            CboCategory.DisplayMember = nameof(categories);
        }
    }
}
