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

namespace RPM9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Коллекцмя
        /// </summary>
 
        public MainWindow()
        {
            InitializeComponent();
        }


        List <int> mas = new List<int>(); 

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }

        private void btnFull_Click(object sender, RoutedEventArgs e)
        {
            bool f1 = int.TryParse(tbCol.Text, out int col);
            if (f1 == true && col > 0)
            {
                mas.Clear();
                Random rnd = new Random();
                for (int i = 0; i < col; i++)
                {
                    int random = rnd.Next(-100, 100);
                    mas.Add(random);
                }
                lbList.ItemsSource = null;
                lbList.ItemsSource = mas;
            }
            else
            {
                MessageBox.Show("Проверьте правильность вводимых данных"); 
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            mas.Clear();
            lbList.ItemsSource = null;
            //lbList.Items.Clear();
            tbCol.Clear();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            int plus = 0;
            int minus = 0;
            for (int i = 0; i < mas.Count; i++)
            {
                if (mas[i]>0 && mas[i]!=0)
                {
                    plus += 1;
                }
                if (mas[i]<0 && mas[i]!=0)
                {
                    minus += 1;
                }
                tbPlus.Text = plus.ToString();
                tbMinus.Text = minus.ToString();
            }
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №9 - Коллекции. Обобщённые типы.\r\n5. Дан массив в диапазоне [-100;100] найти количество положительных и отрицательных.\r\nВыполнила:\r\nСтудентка гр.ИСП-31\r\nКирюшова.В");
        }
    }
}