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

namespace Pracownicy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string Generuj(int chars, bool duze, bool cyfr, bool specjalne)
        {
            string znaki = "abcdefghijklmnopqrstuvwxyz";
            string duzeLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cyfry = "0123456789";
            string znakiSpecjalne = "!@#$%^&*()_+";

            string finalne = "";

            if (duze)
            {
                znaki += duzeLitery;
            }
            if (cyfr)
            {
                znaki += cyfry;
            }
            if (specjalne)
            {
                znaki += znakiSpecjalne;
            }
            Random random = new Random();

            for (int i = chars; i>0; i--)
            {
                finalne += znaki[random.Next(0, znaki.Length)];

            }
            return finalne;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!int.TryParse(Znaki.Text, out int znaki))
            {
                MessageBox.Show("Nieprawidłowa ilość znaków");
                return;
            }
            bool isDuze = (bool)duzeimale.IsChecked;
            bool isCyfry = (bool)cyfry.IsChecked;
            bool isSpecjalne = (bool)specjalne.IsChecked;
            MessageBox.Show(Generuj(znaki, isDuze, isCyfry, isSpecjalne));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Znaki.Text, out int znaki))
            {
                MessageBox.Show("Nieprawidłowa ilość znaków");
                return;
            }
            if(txtImie.Text == "" || txtNazwisko.Text == "" || stanowisko.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola");
                return;
            }
            bool isDuze = (bool)duzeimale.IsChecked;
            bool isCyfry = (bool)cyfry.IsChecked;
            bool isSpecjalne = (bool)specjalne.IsChecked;
            MessageBox.Show($"Dane pracownika: {txtImie.Text} {txtNazwisko.Text} {stanowisko.Text} Hasło: {Generuj(znaki, isDuze, isCyfry, isSpecjalne)}");
        }
    }
}