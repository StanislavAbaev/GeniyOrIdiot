using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class UserResults : Form
    {
        public UserResults()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserResults_Load(object sender, EventArgs e)
        {
            var userResults = UsersResultsStorage.GetAll();
            foreach (var user in userResults)
            {
                dataGridView1.Rows.Add(user.Name, user.CountOfRightAnswers, user.Diagnosis);
            }
        }
    }
}
