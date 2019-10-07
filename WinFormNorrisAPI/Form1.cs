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

        private void BtnQueryAPI_Click(object sender, EventArgs e)
        {
            SearchAPIForJoke();
        }

        private async void PopulateCatagories()
        {
            IEnumerable<String> categories = await ChuckNorrisClient.GetCategories();
            CboCategory.DataSource = categories;
            CboCategory.DisplayMember = nameof(categories);
        }

        private async void SearchAPIForJoke()
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            DialogResult result = MessageBox.Show(joke.JokeText, "Chuck Norris API Joke", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (result.Equals(MessageBoxButtons.OK))
            {
                return;
            }
        }
    }
}
