using Pract03._05;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pract03._05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbThreePairs.IsChecked = true;
        }

        private void Summ_Click(object sender, RoutedEventArgs e)
        {
            if (rbTwoPairs.IsChecked == true)
            {
                if (Int32.TryParse(tbX1.Text, out int x1) == true && Int32.TryParse(tbX2.Text, out int x2) == true && Int32.TryParse(tbY1.Text, out int y1) == true && Int32.TryParse(tbY2.Text, out int y2) == true)
                {
                    Pair pair1 = new Pair(x1, x2);
                    Pair pair2 = new Pair(y1, y2);
                    Pair pair3 = new Pair();
                    pair3 = Pair.Sum(pair1, pair2);
                    tbRez1.Text = Convert.ToString(pair3.A);
                    tbRez2.Text = Convert.ToString(pair3.B);
                }
                else MessageBox.Show("!!!Введите удобоваримые значения!!!");
            }
            else if (rbThreePairs.IsChecked == true)
            {
                if (Int32.TryParse(tbX1.Text, out int x1) == true && Int32.TryParse(tbX2.Text, out int x2) == true && Int32.TryParse(tbY1.Text, out int y1) == true && Int32.TryParse(tbY2.Text, out int y2) == true && Int32.TryParse(tbZ1.Text, out int z1) == true && Int32.TryParse(tbZ2.Text, out int z2) == true)
                {
                    Pair pair1 = new Pair(x1, x2);
                    Pair pair2 = new Pair(y1, y2);
                    Pair pair3 = new Pair(z1, z2);
                    Pair pair4 = new Pair();
                    pair4 = Pair.Sum(pair1, pair2, pair3);
                    tbRez1.Text = Convert.ToString(pair4.A);
                    tbRez2.Text = Convert.ToString(pair4.B);
                }
                else MessageBox.Show("!!!Введите удобоваримые значения!!!");
            }
        }

        private void OnePlus_Click(object sender, RoutedEventArgs e)
        {
            if (rbTwoPairs.IsChecked == true)
            {
                if (Int32.TryParse(tbX1.Text, out int x1) == true && Int32.TryParse(tbX2.Text, out int x2) == true && Int32.TryParse(tbY1.Text, out int y1) == true && Int32.TryParse(tbY2.Text, out int y2) == true)
                {
                    Pair pair1 = new Pair(x1, x2);
                    Pair pair2 = new Pair(y1, y2);
                    Pair.AddOne(ref pair1);
                    Pair.AddOne(ref pair2);
                    tbX1.Text = Convert.ToString(pair1.A);
                    tbX2.Text = Convert.ToString(pair1.B);
                    tbY1.Text = Convert.ToString(pair2.A);
                    tbY2.Text = Convert.ToString(pair2.B);
                }
                else MessageBox.Show("!!!Введите удобоваримые значения!!!");
            }
            else if (rbThreePairs.IsChecked == true)
            {
                if (Int32.TryParse(tbX1.Text, out int x1) == true && Int32.TryParse(tbX2.Text, out int x2) == true && Int32.TryParse(tbY1.Text, out int y1) == true && Int32.TryParse(tbY2.Text, out int y2) == true && Int32.TryParse(tbZ1.Text, out int z1) == true && Int32.TryParse(tbZ2.Text, out int z2) == true)
                {
                    Pair pair1 = new Pair(x1, x2);
                    Pair pair2 = new Pair(y1, y2);
                    Pair pair3 = new Pair(z1, z2);
                    Pair.AddOne(ref pair1);
                    Pair.AddOne(ref pair2);
                    Pair.AddOne(ref pair3);
                    tbX1.Text = Convert.ToString(pair1.A);
                    tbX2.Text = Convert.ToString(pair1.B);
                    tbY1.Text = Convert.ToString(pair2.A);
                    tbY2.Text = Convert.ToString(pair2.B);
                    tbZ1.Text = Convert.ToString(pair3.A);
                    tbZ2.Text = Convert.ToString(pair3.B);
                }
                else MessageBox.Show("!!!Введите удобоваримые значения!!!");
            }
        }

        private void OneMinus_Click(object sender, RoutedEventArgs e)
        {
            if (rbTwoPairs.IsChecked == true)
            {
                if (Int32.TryParse(tbX1.Text, out int x1) == true && Int32.TryParse(tbX2.Text, out int x2) == true && Int32.TryParse(tbY1.Text, out int y1) == true && Int32.TryParse(tbY2.Text, out int y2) == true)
                {
                    Pair pair1 = new Pair(x1, x2);
                    Pair pair2 = new Pair(y1, y2);
                    pair1--;
                    pair2--;
                    tbX1.Text = Convert.ToString(pair1.A);
                    tbX2.Text = Convert.ToString(pair1.B);
                    tbY1.Text = Convert.ToString(pair2.A);
                    tbY2.Text = Convert.ToString(pair2.B);
                }
                else MessageBox.Show("!!!Введите удобоваримые значения!!!");
            }
            else if (rbThreePairs.IsChecked == true)
            {
                if (Int32.TryParse(tbX1.Text, out int x1) == true && Int32.TryParse(tbX2.Text, out int x2) == true && Int32.TryParse(tbY1.Text, out int y1) == true && Int32.TryParse(tbY2.Text, out int y2) == true && Int32.TryParse(tbZ1.Text, out int z1) == true && Int32.TryParse(tbZ2.Text, out int z2) == true)
                {
                    Pair pair1 = new Pair(x1, x2);
                    Pair pair2 = new Pair(y1, y2);
                    Pair pair3 = new Pair(z1, z2);
                    pair1--;
                    pair2--;
                    pair3--;
                    tbX1.Text = Convert.ToString(pair1.A);
                    tbX2.Text = Convert.ToString(pair1.B);
                    tbY1.Text = Convert.ToString(pair2.A);
                    tbY2.Text = Convert.ToString(pair2.B);
                    tbZ1.Text = Convert.ToString(pair3.A);
                    tbZ2.Text = Convert.ToString(pair3.B);
                }
                else MessageBox.Show("!!!Введите удобоваримые значения!!!");
            }
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\rРабота с классами. Перегрузка методов.\nАртемкин М. ИСП-31 Практическая работа №4\n\n2. Создать класс Pair (пара чисел). Создать необходимые методы и свойства. Определить методы метод сложения полей и \r\nоперацию сложения пар (а, b) + (с, d) = (а + c, b + d). Создать перегруженные методы для увеличения полей на 1,\r\nсложения трех пар чисел.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rbTwoPairs_Checked(object sender, RoutedEventArgs e)
        {
            tbZ1.IsEnabled = false;
            tbZ2.IsEnabled = false;
        }

        private void rbThreePairs_Checked(object sender, RoutedEventArgs e)
        {
            tbZ1.IsEnabled = true;
            tbZ2.IsEnabled = true;
        }
    }
}