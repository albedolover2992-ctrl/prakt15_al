using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_15
{
    internal class Vectors
    {
        // Поля
        double x;
        double y;
        double z;
        public static List <Vectors> vec = new List <Vectors> ();

        public Vectors(double x_, double y_, double z_)
        {
            x = x_;
            y = y_;
            z = z_;
        }
        

        // Добавить в лист
        public static void Add_vec (Vectors vec_)
        {
            vec.Add(vec_);
        }

        // Очистить лист
        public static void Clean_vec ()
        {
            vec.Clear();
        }

        // Кол-во эл в листе
        public static int List_count ()
        {
            return vec.Count;
        }

        // Сумма векторов
        public static Vectors Sum_vec ()
        {
            double x = vec[0].X + vec[1].X;
            double y = vec[0].Y + vec[1].Y;
            double z = vec[0].Z + vec[1].Z;
            Vectors vec_ = new Vectors (x, y, z);
            return vec_;
        }

        // Вычитание векторов
        public static Vectors Sub_vec ()
        {
            double x = vec[0].X - vec[1].X;
            double y = vec[0].Y - vec[1].Y;
            double z = vec[0].Z - vec[1].Z;
            Vectors vec_ = new Vectors(x, y, z);
            return vec_;
        }

        // Скалярное произведение
        public static double Com_vec ()
        {
            return (vec[0].X * vec[1].X) + (vec[0].Y * vec[1].Y) + (vec[0].Z * vec[1].Z);
        }

        // Длина векторов
        public static double Len_vec (int n)
        {
            double len = 0;
            switch (n)
            {
                case 1:
                    {
                        len = Math.Round(Math.Sqrt(Math.Pow(vec[0].X,2) + Math.Pow(vec[0].Y,2) + Math.Pow(vec[0].Z,2)),2); 
                        break;
                    }
                case 2:
                    {
                        len = Math.Round(Math.Sqrt(Math.Pow(vec[1].X, 2) + Math.Pow(vec[1].Y, 2) + Math.Pow(vec[1].Z, 2)),2);
                        break;
                    }
            }
            return len;
        }

        // Косинус между векторами
        public static double Cos_vec ()
        {
            return Math.Round(Com_vec() / (Len_vec(1) * Len_vec(2)),2);
        }

        // Свойства
        public double X { get { return x; } private set { this.x = value; } }
        public double Y { get { return y; } private set { this.y = value; } }
        public double Z { get { return z; } private set { this.z = value; } }
    }
}
