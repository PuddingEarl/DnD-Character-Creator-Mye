using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Character_Creator_Mye.SecondaryForms
{
    public partial class NewCharacterForm : Form
    {
        static public Form1 form;

        public NewCharacterForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            int points;
            if(int.TryParse(textBoxPoints.Text, out points))
            {
                form.createCharacter(points, textBoxName.Text);
                Close();
            }
            else
            {
                labelError.Text = "Invalid Point Value. Please enter a number.";
            }
        }
    }
}
