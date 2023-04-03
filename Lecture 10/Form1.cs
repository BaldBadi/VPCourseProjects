using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_10
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private object txtNumOfContorls;


        private void btnCreateControls_Click(object sender, EventArgs e)
        {
            int NumberOfControls = int.Parse(txtNumOfContorls.Text);

            if (comboBox1.Text == "Button")
            {
                for (int i = 0; i < NumberOfControls; i++)
                {
                    Button newButton = new Button();
                    newButton.Name = "Button" + (i + 1);
                    newButton.Text = "Button" + (i + 1);
                    newButton.Size = new Size(120, 40);
                    newButton.Location = new Point(0, (i * 50));
                    pnlDynamicControls.Controls.Add(newButton);
                }
            }

            if (comboBox1.Text == "TextBox")
            {
                for (int i = 0; i < NumberOfControls; i++)
                {
                    TextBox TextBox = new TextBox();
                    TextBox.Name = "TextBox" + (i + 1);
                    TextBox.Text = "TextBox" + (i + 1);
                    TextBox.Size = new Size(130, 40);
                    TextBox.Location = new Point(0, (i * 50));
                    pnlDynamicControls.Controls.Add(TextBox);
                }
            }

            if (comboBox1.Text == "Label")
            {
                for (int i = 0; i < NumberOfControls; i++)
                {
                    Label Label = new Label();
                    Label.Name = "Label" + (i + 1);
                    Label.Text = "Label" + (i + 1);
                    Label.Size = new Size(140, 40);
                    Label.Location = new Point(0, (i * 50));
                    pnlDynamicControls.Controls.Add(Label);
                }
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


