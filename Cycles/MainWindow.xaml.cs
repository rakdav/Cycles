using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cycles
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = int.Parse(cN.Text);
                float A = float.Parse(cA.Text);
                string res = "";
                for(int i=1;i<=N;i++)
                {
                    res += i + " " + A + " " + (i * i - A * A) + "\n";
                }
                chisla.Text = res;
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = int.Parse(cN.Text);
                double S = 0;
                double P = 1;
                for (int j = 1; j <= k; j++)
                {
                    if (j != 3&&j!=4)
                    {
                        P *= (double)((j - 4) * j) / (j - 3);
                    }
                }
                for (int i = 1; i <= k + 1; i++)
                {
                    if (i != 1)
                    {
                        S += Math.Pow(i + 5, 1 / 3) / i - 1;
                    }
                }
                chisla.Text = (P * S).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                int m = int.Parse(cN.Text);
                int n= int.Parse(cA.Text);
                int s = 0;
                int i = m;
                while(i<=n)
                {
                    if (i % 2 == 0) s += i * i;
                    i++;
                }
                chisla.Text = s.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(cN.Text);
                int m = int.Parse(cA.Text);
                int i = 0;
                while(i<=n)
                {
                    if(i>m)
                    {
                        chisla.Text = (i * i).ToString();
                        break;
                    }
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(cN.Text);
                string res = "";
                while(n>=16)
                {
                    int m = n % 16;
                    switch (m)
                    {
                        case 10: res += "A"; break;
                        case 11: res += "B"; break;
                        case 12: res += "C"; break;
                        case 13: res += "D"; break;
                        case 14: res += "E"; break;
                        case 15: res += "F"; break;
                        default: res += m.ToString(); break;
                    }                 
                    n /= 16;
                    if (n < 16)
                    {
                        switch (n)
                        {
                            case 10: res += "A"; break;
                            case 11: res += "B"; break;
                            case 12: res += "C"; break;
                            case 13: res += "D"; break;
                            case 14: res += "E"; break;
                            case 15: res += "F"; break;
                            default: res += n.ToString(); break;
                        }
                    }
                }
                string result = "";
                for (int i = res.Length-1; i >= 0; i--) result += res[i];
                chisla.Text = result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(cN.Text);
                double x= double.Parse(cA.Text);
                int i = 1;
                double S = 0;
                int h = 1;
                while (i <= n)
                {
                    S += Math.Sin(h * Math.Pow(x, h));
                    h += 2;
                    i++;
                }
                chisla.Text = S.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
