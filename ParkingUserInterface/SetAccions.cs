using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingUserInterface
{
    public class SetAccions : Form
    {
        private string country;
        private TextBox textBoxChange1;
        private Label labelChange2;
        private TextBox textBoxChange2;
        private Button btnMoveAlong;
        private Button btnBack;
        private Button btnUruguay2;
        private Button btnArgentina2;
        private Label labelChange1;

        public SetAccions(string accion, string country)
        {
            InitializeComponent();
            labelChange2.Hide();
            labelChange1.Hide();
            textBoxChange1.Hide();
            textBoxChange2.Hide();
            btnMoveAlong.Hide();
            this.country = country;
            

            if (accion=="AddAccount")
            {
                
                labelChange1.Text = "Number";
                labelChange1.Show();
                labelChange2.Text = "Balance";
                labelChange2.Show();
                textBoxChange2.Show();
                textBoxChange1.Show();
                btnMoveAlong.Text = "Add Account";
                btnMoveAlong.Show();
            }

            if (accion == "AddBalance")
            {
                labelChange1.Text = "Number";
                labelChange1.Show();
                labelChange2.Text = "Balance";
                labelChange2.Show();
                textBoxChange2.Show();
                textBoxChange1.Show();
                btnMoveAlong.Text = "Add Balance";
                btnMoveAlong.Show();
            }
            if (accion == "BuyParking")
            {
                labelChange1.Text = "Number";
                labelChange1.Show();
                labelChange2.Text = "Text";
                labelChange2.Show();
                textBoxChange2.Show();
                textBoxChange1.Show();
                btnMoveAlong.Text = "Buy Parking";
                btnMoveAlong.Show();
            }
            if (accion == "CheckParking")
            {
                labelChange1.Text = "License Plate";
                labelChange1.Show();
                labelChange2.Text = "Date";
                labelChange2.Show();
                textBoxChange2.Show();
                textBoxChange1.Show();
                btnMoveAlong.Text = "Check License";
                btnMoveAlong.Show();
            }
            if (accion == "SetCostParking")
            {
                labelChange1.Text = "Cost Per Minute";
                labelChange1.Show();
                textBoxChange1.Show();
                btnMoveAlong.Text = "Change";
                btnMoveAlong.Show();
            }
            


        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetAccions));
            this.labelChange1 = new System.Windows.Forms.Label();
            this.textBoxChange1 = new System.Windows.Forms.TextBox();
            this.labelChange2 = new System.Windows.Forms.Label();
            this.textBoxChange2 = new System.Windows.Forms.TextBox();
            this.btnMoveAlong = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUruguay2 = new System.Windows.Forms.Button();
            this.btnArgentina2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChange1
            // 
            this.labelChange1.AutoSize = true;
            this.labelChange1.Location = new System.Drawing.Point(108, 119);
            this.labelChange1.Name = "labelChange1";
            this.labelChange1.Size = new System.Drawing.Size(46, 17);
            this.labelChange1.TabIndex = 0;
            this.labelChange1.Text = "label1";
            // 
            // textBoxChange1
            // 
            this.textBoxChange1.Location = new System.Drawing.Point(199, 116);
            this.textBoxChange1.Name = "textBoxChange1";
            this.textBoxChange1.Size = new System.Drawing.Size(132, 22);
            this.textBoxChange1.TabIndex = 1;
            // 
            // labelChange2
            // 
            this.labelChange2.AutoSize = true;
            this.labelChange2.Location = new System.Drawing.Point(108, 181);
            this.labelChange2.Name = "labelChange2";
            this.labelChange2.Size = new System.Drawing.Size(46, 17);
            this.labelChange2.TabIndex = 2;
            this.labelChange2.Text = "label2";
            // 
            // textBoxChange2
            // 
            this.textBoxChange2.Location = new System.Drawing.Point(199, 181);
            this.textBoxChange2.Name = "textBoxChange2";
            this.textBoxChange2.Size = new System.Drawing.Size(132, 22);
            this.textBoxChange2.TabIndex = 3;
            // 
            // btnMoveAlong
            // 
            this.btnMoveAlong.Location = new System.Drawing.Point(337, 360);
            this.btnMoveAlong.Name = "btnMoveAlong";
            this.btnMoveAlong.Size = new System.Drawing.Size(129, 36);
            this.btnMoveAlong.TabIndex = 5;
            this.btnMoveAlong.Text = "MoveAlong";
            this.btnMoveAlong.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(101, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnUruguay2
            // 
            this.btnUruguay2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUruguay2.FlatAppearance.BorderSize = 5;
            this.btnUruguay2.Image = ((System.Drawing.Image)(resources.GetObject("btnUruguay2.Image")));
            this.btnUruguay2.Location = new System.Drawing.Point(12, 12);
            this.btnUruguay2.Name = "btnUruguay2";
            this.btnUruguay2.Size = new System.Drawing.Size(127, 87);
            this.btnUruguay2.TabIndex = 7;
            this.btnUruguay2.UseVisualStyleBackColor = true;
            // 
            // btnArgentina2
            // 
            this.btnArgentina2.FlatAppearance.BorderSize = 5;
            this.btnArgentina2.Image = ((System.Drawing.Image)(resources.GetObject("btnArgentina2.Image")));
            this.btnArgentina2.Location = new System.Drawing.Point(410, 12);
            this.btnArgentina2.Name = "btnArgentina2";
            this.btnArgentina2.Size = new System.Drawing.Size(127, 87);
            this.btnArgentina2.TabIndex = 8;
            this.btnArgentina2.UseVisualStyleBackColor = true;
            // 
            // SetAccions
            // 
            this.ClientSize = new System.Drawing.Size(549, 478);
            this.Controls.Add(this.btnArgentina2);
            this.Controls.Add(this.btnUruguay2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMoveAlong);
            this.Controls.Add(this.textBoxChange2);
            this.Controls.Add(this.labelChange2);
            this.Controls.Add(this.textBoxChange1);
            this.Controls.Add(this.labelChange1);
            this.Name = "SetAccions";
            this.Load += new System.EventHandler(this.SetAccions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SetAccions_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddAccountSecond_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            goPrincipal();

        }
        public void goPrincipal()
        {
            this.Hide();
            FirstAndPrincipal firstAndPrincipal = new FirstAndPrincipal(country);
            firstAndPrincipal.ShowDialog();
            this.Close();
        }
    }
}
