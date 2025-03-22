using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class addMovieForm : UserControl
    {
        public addMovieForm()
        {
            InitializeComponent();
        }

        private void addMovies_importBtn_Click(object sender, EventArgs e)
        {

        }

        private void addMovieForm_Load(object sender, EventArgs e)
        {

        }

        private void addMovies_showDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static implicit operator Form(addMovieForm v)
        {
            throw new NotImplementedException();
        }
    }
}
