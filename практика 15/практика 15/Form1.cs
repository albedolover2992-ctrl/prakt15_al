using System.Numerics;

namespace практика_15
{
    public partial class Form1 : Form
    {
        // Поля
        double x;
        double y;
        double z;


        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (X_end.Text != "" && Y_end.Text != "" && Z_end.Text != "")
                {
                    x = Convert.ToDouble(X_end.Text);
                    y = Convert.ToDouble(Y_end.Text);
                    z = Convert.ToDouble(Z_end.Text);
                    Vectors vec = new Vectors(x, y, z);
                    Vectors.Add_vec(vec);
                    switch (Vectors.List_count())
                    {
                        case 1:
                            {
                                Vec_1.Text = "(0; 0; 0) (" + vec.X.ToString() + "; " + vec.Y.ToString() + "; " + vec.Z.ToString() + ")";
                                break;
                            }
                        case 2:
                            {
                                {
                                    Vec_2.Text = "(0; 0; 0) (" + vec.X.ToString() + "; " + vec.Y.ToString() + "; " + vec.Z.ToString() + ")";
                                    break;
                                }
                            }
                    }
                    X_end.Text = "";
                    Y_end.Text = "";
                    Z_end.Text = "";
                }
                if (Vectors.List_count() == 2)
                {
                    X_end.Enabled = false;
                    Y_end.Enabled = false;
                    Z_end.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат данных");
            }
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            if (Vectors.List_count() == 2)
            {
                Vectors vec = Vectors.Sum_vec();
                Res.Text = "Сумма векторов: \n(0; 0; 0) (" + vec.X.ToString() + "; " + vec.Y.ToString() + "; " + vec.Z.ToString() + ")";
            }
            else
            {
                MessageBox.Show("Неверное кол-во элементов");
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            if (Vectors.List_count() == 2)
            {
                Vectors vec = Vectors.Sub_vec();
                Res.Text = "Разница векторов: \n(0; 0; 0) (" + vec.X.ToString() + "; " + vec.Y.ToString() + "; " + vec.Z.ToString() + ")";
            }
            else
            {
                MessageBox.Show("Неверное кол-во элементов");
            }
        }

        private void Com_Click(object sender, EventArgs e)
        {
            if (Vectors.List_count() == 2)
            {
                double com = Vectors.Com_vec();
                Res.Text = "Сколярное произведение векторов:\n" + com;
            }
            else
            {
                MessageBox.Show("Неверное кол-во элементов");
            }
        }

        private void Len_Click(object sender, EventArgs e)
        {
            if (Vectors.List_count() == 2)
            {
                double len1 = Vectors.Len_vec(1);
                double len2 = Vectors.Len_vec(2);
                Res.Text = "Длина вектора 1:" + len1 + "\nДлина вектора 2:" + len2;
            }
            else
            {
                MessageBox.Show("Неверное кол-во элементов");
            }
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            if (Vectors.List_count() == 2)
            {
                if (Vectors.Len_vec(1) != 0 && Vectors.Len_vec(2) != 0)
                {
                    double cos = Vectors.Cos_vec();
                    Res.Text = "Косинус между векторами: \n" + cos;
                }
                else
                {
                    MessageBox.Show("Длина вектора не может быть равна нулю");
                }
            }
            else
            {
                MessageBox.Show("Неверное кол-во элементов");
            }
        }

        private void Replay_Click(object sender, EventArgs e)
        {
            Vectors.Clean_vec();
            X_end.Enabled = true;
            Y_end.Enabled = true;
            Z_end.Enabled = true;
            Vec_1.Text = "";
            Vec_2.Text = "";
            Res.Text = "";
        }
    }
}
