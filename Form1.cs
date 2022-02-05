using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        TableLayoutPanel tb = new TableLayoutPanel();
        TextBox txt = new TextBox();
        readonly TextBox txtmini = new TextBox();
        int operation = -1;
        double prevnumber = -1;
        string g = "deg";
        int t = 1;
        public void set_tb()
        {
            tb.ColumnCount = 5;
            tb.RowCount = 7;
            tb.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tb.Location = new Point(10, 140);
            tb.Size = new Size(txt.Width, 455);


            for (int i = 0; i < 5; i++)
            {
                tb.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, txt.Width / 5 - 5));
            }
            for (int j = 0; j < 7; j++)
            {
                tb.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            }
            tb.Left = (this.ClientSize.Width - tb.Width) / 2;

            // width = 71, height = 66
            

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Button btn = new Button();
                    tb.Controls.Add(btn, i, j);
                    btn.Text = Set_button_text(i, j);
                    btn.AutoSize = true;
                    btn.TabStop = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }

            
            
            Controls.Add(tb);
        }

        public void upd()
        {
            MessageBox.Show("Ошибка", "Ошибка");
            txt.Clear();
            txtmini.Clear();
        }
        public string Set_button_text(int c, int r)
        {
            if (c == 0 && r == 0)
            {
                Control c1 = tb.GetControlFromPosition(c, r);
                c1.Click += C1_Click;
                return "2nd";
            }

            else if (c == 1 && r == 0)
            {
                Control c2 = tb.GetControlFromPosition(c, r);
                c2.Click += C2_Click;
                return "p";
            }

            else if (c == 2 && r == 0)
            {
                Control c3 = tb.GetControlFromPosition(c, r);
                c3.Click += C3_Click;
                return "e";
            }

            else if (c == 3 && r == 0)
            {
                Control c4 = tb.GetControlFromPosition(c, r);
                c4.Click += C4_Click;
                return "C";
            }

            else if (c == 4 && r == 0)
            {
                Control c5 = tb.GetControlFromPosition(c, r);
                c5.Click += C5_Click;
                return "<<";
            }

            else if (c == 0 && r == 1)
            {
                Control c6 = tb.GetControlFromPosition(c, r);
                c6.Click += C6_Click;
                return "x^2";
            }


            else if (c == 1 && r == 1)
            {
                Control c7 = tb.GetControlFromPosition(c, r);
                c7.Click += C7_Click;
                return "1/x";
            }

            else if (c == 2 && r == 1)
            {
                Control c8 = tb.GetControlFromPosition(c, r);
                c8.Click += C8_Click;
                return "abs";
            }

            else if (c == 3 && r == 1)
            {
                Control c9 = tb.GetControlFromPosition(c, r);
                c9.Click += C9_Click;
                return "exp";
            }
            else if (c == 4 && r == 1)
            {
                Control c10 = tb.GetControlFromPosition(c, r);
                c10.Click += C10_Click;
                return "mod";
            }
            else if (c == 0 && r == 3)
            {
                Control c11 = tb.GetControlFromPosition(c, r);
                c11.Click += C11_Click;
                return "sqrt";
            }
            else if (c == 0 && r == 2)
            {
                Control c36 = tb.GetControlFromPosition(c, r);
                c36.Click += C36_Click; ;
                return "deg";
            }
            else if (c == 1 && r == 2)
            {
                Control c12 = tb.GetControlFromPosition(c, r);
                c12.Click += C12_Click;
                return "sin";
            }
            else if (c == 2 && r == 2)
            {
                Control c13 = tb.GetControlFromPosition(c, r);
                c13.Click += C13_Click;
                return "cos";
            }
            else if (c == 3 && r == 2)
            {
                Control c14 = tb.GetControlFromPosition(c, r);
                c14.Click += C14_Click;
                return "x!";
            }
            else if (c == 4 && r == 2)
            {
                Control c15 = tb.GetControlFromPosition(c, r);
                c15.Click += C15_Click;
                return "/";
            }

            else if (c == 0 && r == 4)
            {
                Control c16 = tb.GetControlFromPosition(c, r);
                c16.Click += C16_Click;
                return "x^y";
            }
            else if (c == 1 && r == 3)
            {
                Control c17 = tb.GetControlFromPosition(c, r);
                c17.Click += C17_Click;
                return "7";
            }
            else if (c == 2 && r == 3)
            {
                Control c18 = tb.GetControlFromPosition(c, r);
                c18.Click += C18_Click;
                return "8";
            }
            else if (c == 3 && r == 3)
            {
                Control c19 = tb.GetControlFromPosition(c, r);
                c19.Click += C19_Click;
                return "9";
            }
            else if (c == 4 && r == 3)
            {
                Control c20 = tb.GetControlFromPosition(c, r);
                c20.Click += C20_Click;
                return "*";
            }
            else if (c == 0 && r == 5)
            {
                Control c21 = tb.GetControlFromPosition(c, r);
                c21.Click += C21_Click;
                return "10^x";
            }
            else if (c == 1 && r == 4)
            {
                Control c22 = tb.GetControlFromPosition(c, r);
                c22.Click += C22_Click;
                return "4";
            }
            else if (c == 2 && r == 4)
            {
                Control c23 = tb.GetControlFromPosition(c, r);
                c23.Click += C23_Click;
                return "5";
            }
            else if (c == 3 && r == 4)
            {
                Control c24 = tb.GetControlFromPosition(c, r);
                c24.Click += C24_Click;
                return "6";
            }
            else if (c == 4 && r == 4)
            {
                Control c25 = tb.GetControlFromPosition(c, r);
                c25.Click += C25_Click;
                return "-";
            }
            else if (c == 0 && r == 6)
            {
                Control c26 = tb.GetControlFromPosition(c, r);
                c26.Click += C26_Click;
                return "log";
            }
            else if (c == 1 && r == 5)
            {
                Control c27 = tb.GetControlFromPosition(c, r);
                c27.Click += C27_Click;
                return "1";
            }
            else if (c == 2 && r == 5)
            {
                Control c28 = tb.GetControlFromPosition(c, r);
                c28.Click += C28_Click;
                return "2";
            }
            else if (c == 3 && r == 5)
            {
                Control c29 = tb.GetControlFromPosition(c, r);
                c29.Click += C29_Click;
                return "3";
            }
            else if (c == 4 && r == 5)
            {
                Control c30 = tb.GetControlFromPosition(c, r);
                c30.Click += C30_Click;
                return "+";
            }

            else if (c == 1 && r == 6)
            {
                Control c32 = tb.GetControlFromPosition(c, r);
                c32.Click += C32_Click;
                return "+/-";
            }
            else if (c == 2 && r == 6)
            {
                Control c33 = tb.GetControlFromPosition(c, r);
                c33.Click += C33_Click;
                return "0";
            }
            else if (c == 3 && r == 6)
            {
                Control c34 = tb.GetControlFromPosition(c, r);
                c34.Click += C34_Click;
                return ",";
            }
            else if (c == 4 && r == 6)
            {
                Control c35 = tb.GetControlFromPosition(c, r);
                c35.Click += C35_Click;
                return "=";
            }
            else return "-1";
        }

        private void C36_Click(object sender, EventArgs e)
        {
            Control c = tb.GetControlFromPosition(0, 2);
            if (g == "deg") g = "rad";
            else if (g == "rad") g = "grad";
            else if (g == "grad") g = "deg";
            c.Text = g;
        }

        private void C35_Click(object sender, EventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(txt.Text);
                txtmini.Text += Convert.ToString(n) + " = ";
                if (operation == 30) n += prevnumber;
                else if (operation == 15)
                {
                    if (n == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя", "Ошибка");
                        txtmini.Clear();
                        txt.Clear();
                    }
                    else
                    {
                        n = prevnumber / n;
                    }

                }
                else if (operation == 25) n = prevnumber - n;
                else if (operation == 20) n = prevnumber * n;
                else if (operation == 10) n = prevnumber % n;
                else if (operation == 16) n = Math.Pow(prevnumber, n);
                else if (operation == 100)
                {
                    n = Math.Pow(prevnumber, Convert.ToDouble(1.0 / n));
                }
                else if (operation == 101)
                {
                    n = Math.Log(prevnumber, n);
                }

                txt.Text = Convert.ToString(n);
            }
            catch
            {
                upd();
            }
            
            
        }

        private void C34_Click(object sender, EventArgs e)
        {
            try
            {
                txt.AppendText(",");
            }
            catch
            {
                upd();
            }
        }

        private void C33_Click(object sender, EventArgs e)
        {
            txt.Text += "0";
        }

        private void C32_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = " (-1) * " + txt.Text;
                double n = Convert.ToDouble(txt.Text);
                n = -1 * n;
                txt.Text = Convert.ToString(n);
            }
            catch
            {
                upd();
            }
        }


        private void C30_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = txt.Text + " + ";
                prevnumber = Convert.ToDouble(txt.Text);
                txt.Clear();
                operation = 30;
            }
            catch
            {
                upd();
            }
        }

        private void C29_Click(object sender, EventArgs e)
        {
            txt.Text += "3";
        }

        private void C28_Click(object sender, EventArgs e)
        {
            txt.Text += "2";
        }

        private void C27_Click(object sender, EventArgs e)
        {
            txt.Text += "1";
        }

        private void C26_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = $"log({txt.Text})";
                double n = Convert.ToDouble(txt.Text);
                n = Math.Log10(n);
                txt.Text = Convert.ToString(n);
            }
            catch
            {
                upd();
            }
        }

        private void C25_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = txt.Text + " - ";
                prevnumber = Convert.ToDouble(txt.Text);
                txt.Clear();
                operation = 25;
            }
            catch
            {
                upd();
            }
        }

        private void C24_Click(object sender, EventArgs e)
        {
            txt.Text += "6";
        }

        private void C23_Click(object sender, EventArgs e)
        {
            txt.Text += "5";
        }

        private void C22_Click(object sender, EventArgs e)
        {
            txt.Text += "4";
        }

        private void C21_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = "10 ^ " + txt.Text;
                double n = Convert.ToDouble(txt.Text);
                n = Math.Pow(10, n);
                txt.Text = Convert.ToString(n);
            }
            catch
            {
                upd();
            }
        }

        private void C20_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = txt.Text + " * ";
                prevnumber = Convert.ToDouble(txt.Text);
                txt.Clear();
                operation = 20;
            }
            catch
            {
                upd();
            }
        }

        private void C19_Click(object sender, EventArgs e)
        {
            txt.Text += "9";
        }

        private void C18_Click(object sender, EventArgs e)
        {
            txt.Text += "8";
        }

        private void C17_Click(object sender, EventArgs e)
        {
            txt.Text += "7";
        }

        private void C16_Click(object sender, EventArgs e)
        {
            try {
                txtmini.Text = txt.Text + " ^ ";
                prevnumber = Convert.ToDouble(txt.Text);
                txt.Clear();
                operation = 16;
            }
            catch
            {
                upd();
            }
        }

        private void C15_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = txt.Text + " / ";
                prevnumber = Convert.ToDouble(txt.Text);
                txt.Clear();
                operation = 15;
            }
            catch { upd(); }
        }

        private void C14_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = txt.Text + "!";
                bool comma = txt.Text.Contains(",");
                double n = Convert.ToDouble(txt.Text);
                if (comma)
                {
                    n = DoubleFact(n);
                }
                else
                {
                    n = Fact(n);
                }


                txt.Text = Convert.ToString(n);
            } catch { upd(); }
        }

        private double DoubleFact(double n)
        {
            // очень неточно, но нормально
            double l = Math.Log10(Fact(Math.Floor(n))) + (n - Math.Floor(n)) * Math.Log10(Math.Ceiling(n));
            double res = Math.Pow(10, l);
            return res;
        }

        private double Fact(double n)
        {
            if (n == 0 || n == 1) return 1;
            else return Fact(n - 1) * n;
        }

        private void C13_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = $"cos({txt.Text})";
                double n = Convert.ToDouble(txt.Text);
                if (g == "rad") n = Math.Cos(n);
                else if (g == "deg") n = Math.Cos(0.0174533 * n);
                else if (g == "grad") n = Math.Cos(0.0157079633 * n);
                txt.Text = Convert.ToString(n);
            }
            catch { upd(); }
        }

        private void C12_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = $"sin({txt.Text})";
                double n = Convert.ToDouble(txt.Text);
                if (g == "rad") n = Math.Sin(n);
                else if (g == "deg") n = Math.Sin(0.0174533 * n);
                else if (g == "grad") n = Math.Sin(0.0157079633 * n);
                txt.Text = Convert.ToString(n);

            }
            catch
            {
                upd();
            }
        }

        private void C11_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = $"sqrt({txt.Text})";
                double n = Convert.ToDouble(txt.Text);
                n = Math.Sqrt(n);
                txt.Text = Convert.ToString(n);
            }
            catch { upd(); }
        }

        private void C10_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = txt.Text + " mod ";
                prevnumber = Convert.ToDouble(txt.Text);
                txt.Clear();
                operation = 10;
            }
            catch { upd(); }
        }

        private void C9_Click(object sender, EventArgs e)
        {try
            {
                txtmini.Text = $"exp({txt.Text})";
                double n = Convert.ToDouble(txt.Text);
                n = Math.Exp(n);
                txt.Text = Convert.ToString(n);
            }
            catch { upd(); }
        }

        private void C7_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = $"1/({txt.Text})";
                double n = Convert.ToDouble(txt.Text);
                n = 1.0 / n;
                //operation = 7;
                txt.Text = Convert.ToString(n);
            }
            catch { upd(); }
        }

        private void C8_Click(object sender, EventArgs e)
        {try
            {
                txtmini.Text = $"abs({txt.Text})";
                double n = Convert.ToDouble(txt.Text);
                n = Math.Abs(n);
                txt.Text = Convert.ToString(n);
            }
            catch { upd(); }
        }

        private void C6_Click(object sender, EventArgs e)
        {
            try
            {
                txtmini.Text = txt.Text + " ^ 2";
                double n = Convert.ToDouble(txt.Text);
                n *= n;
                txt.Text = Convert.ToString(n);
            }
            catch { upd(); }
        }

        private void C5_Click(object sender, EventArgs e)
        {
            if (txt.Text.Length > 0) txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            txt.Clear();
            txtmini.Clear();
            Control t = tb.GetControlFromPosition(3, 6);
            t.Enabled = true;
        }

        private void C3_Click(object sender, EventArgs e)
        {
            txt.Text = "2,718281828459";
        }

        private void C2_Click(object sender, EventArgs e)
        {
            txt.Text = "3,14159265";
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (t == 1)
            {
                Control c1 = tb.GetControlFromPosition(0, 1);
                c1.Text = "x^3";
                c1.Click -= C6_Click;
                c1.Click += C1_Click1;

                Control c2 = tb.GetControlFromPosition(0, 3);
                c2.Font = new Font("Consolas", 11);
                c2.Text = "sqrt3";
                c2.Click -= C11_Click;
                c2.Click += C2_Click1;

                Control c3 = tb.GetControlFromPosition(0, 4);
                c3.Text = "sqrt_y";
                c3.Font = new Font("Consolas", 9);
                c3.Click -= C16_Click;
                c3.Click += C3_Click1;

                Control c4 = tb.GetControlFromPosition(0, 5);
                c4.Text = "2^x";
                c4.Font = new Font("Consolas", 12);
                c4.Click -= C21_Click;
                c4.Click += C4_Click1;

                Control c5 = tb.GetControlFromPosition(0, 6);
                c5.Text = "log_y";
                c5.Font = new Font("Consolas", 9);
                c5.Click -= C26_Click;
                c5.Click += C5_Click1;

                t = 2;
            }
            else
            {
                Control c1 = tb.GetControlFromPosition(0, 1);
                c1.Text = "x^2";
                c1.Click += C6_Click;
                c1.Click -= C1_Click1;

                Control c2 = tb.GetControlFromPosition(0, 3);
                c2.Text = "sqrt";
                c2.Font = new Font("Consolas", 12);
                c2.Click += C11_Click;
                c2.Click -= C2_Click1;

                Control c3 = tb.GetControlFromPosition(0, 4);
                c3.Text = "x^y";
                c3.Font = new Font("Consolas", 11);
                c3.Click += C16_Click;
                c3.Click -= C3_Click1;

                Control c4 = tb.GetControlFromPosition(0, 5);
                c4.Text = "10^x";
                c4.Click += C21_Click;
                c4.Click -= C4_Click1;

                Control c5 = tb.GetControlFromPosition(0, 6);
                c5.Text = "log";
                c5.Font = new Font("Consolas", 12);
                c5.Click += C26_Click;
                c5.Click -= C5_Click1;

                t = 1;
            }
            
        }

        private void C5_Click1(object sender, EventArgs e)
        {try
            {
                txtmini.Text = $"{txt.Text} log base ";
                prevnumber = Convert.ToDouble(txt.Text);
                txt.Clear();
                operation = 101;
            }
            catch { upd(); }
        }

        private void C4_Click1(object sender, EventArgs e)
        {try
            {
                txtmini.Text = "2 ^ " + txt.Text;
                double n = Convert.ToDouble(txt.Text);
                n = Math.Pow(2, n);
                txt.Text = Convert.ToString(n);
            }
            catch { upd(); }
        }

        private void C3_Click1(object sender, EventArgs e)
        {try
            {
                txtmini.Text = $"{txt.Text} yroot ";
                prevnumber = Convert.ToDouble(txt.Text);
                txt.Clear();
                operation = 100;
            }
            catch { upd(); }
        }

        private void C2_Click1(object sender, EventArgs e)
        {try
            {
                txtmini.Text = $"sqrt3({txt.Text})";
                double n = Convert.ToDouble(txt.Text);
                n = Math.Pow(n, Convert.ToDouble(1.0 / 3.0));
                txt.Text = Convert.ToString(n);
            }
            catch { upd(); }
        }

        private void C1_Click1(object sender, EventArgs e)
        {try
            {
                txtmini.Text = txt.Text + " ^ 3";
                double n = Convert.ToDouble(txt.Text);
                n = Math.Pow(n, 3);
                txt.Text = Convert.ToString(n);
            }
            catch { upd(); }
        }

        public void set_txt()
        {
            txt.Font = new Font("Consolas", 18);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Location = new Point(10, 50);
            txt.BackColor = Color.Silver;
            txt.ForeColor = Color.Black;
            txt.TextAlign = HorizontalAlignment.Right;
            txt.TextChanged += Txt_TextChanged;
            
            
            this.txt.AutoSize = false;
            this.txt.Size = new System.Drawing.Size(400, 60);
            txt.Left = (this.ClientSize.Width - txt.Width) / 2;
            Controls.Add(txt);
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            bool comma = get_comma(txt.Text);
            if (comma)
            {
                Control t = tb.GetControlFromPosition(3, 6);
                t.Enabled = false;
            }
            else
            {
                Control t = tb.GetControlFromPosition(3, 6);
                t.Enabled = true;
            }
        }

        public void set_form()
        {
            this.Font = new Font("Consolas", 12);
            this.BackColor = Color.Silver;
            //this.AutoSize = true;
            this.Size = new Size(450, 670);
            this.MaximumSize = new Size(450, 670);
            this.MinimumSize = new Size(450, 670);
        }
        public void set_txt_mini()
        {
            txtmini.Enabled = false;
            txtmini.Font = new Font("Consolas", 12);
            txtmini.BorderStyle = BorderStyle.FixedSingle;
            txtmini.Location = new Point(10, 10);
            txtmini.BackColor = Color.Silver;
            txtmini.ForeColor = Color.Black;
            txtmini.TextAlign = HorizontalAlignment.Right;
            this.txtmini.AutoSize = false;
            this.txtmini.Size = new System.Drawing.Size(400, 30);
            txtmini.Left = (this.ClientSize.Width - txtmini.Width) / 2;
            Controls.Add(txtmini);
        }
        public Form1()
        {
            InitializeComponent();
        }
        public bool get_comma(string s)
        {
            foreach (char e in s) {
                if (e == ',') return true;
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            set_form();
            set_txt();
            set_txt_mini();
            set_tb();
        }
    }
}
