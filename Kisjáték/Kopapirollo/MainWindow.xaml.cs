
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
using System.IO;

namespace Kopapirollo
{
  
    public partial class MainWindow : Window
    {
        RockPaperScissor RockPaperScissor = new RockPaperScissor();
        public MainWindow()
        {
            InitializeComponent();
            MainGrid.DataContext = RockPaperScissor;
         

        }
        int kor;
        int korszama=1;
        int eredmeny1 = 0;
        int eredmeny2 = 0;
        int eredmeny3= 0;


        private void RockButton_Click(object sender, RoutedEventArgs e)
        {
            RockPaperScissor.HumanChoice = 3;
            RockPaperScissor.CChoose();
            RockPaperScissor.ChooseWinner();
            kor++;
        
        }

        private void PaperButton_Click(object sender, RoutedEventArgs e)
        {
            RockPaperScissor.HumanChoice = 1;
            RockPaperScissor.CChoose();
            RockPaperScissor.ChooseWinner();
            kor++;
        }

        private void ScissorButton_Click(object sender, RoutedEventArgs e)
        {
            RockPaperScissor.HumanChoice = 2;
            RockPaperScissor.CChoose();
            RockPaperScissor.ChooseWinner();
            kor++;
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            RockPaperScissor.ComputerWinsCount = 0;
            RockPaperScissor.TiesCount = 0;
            RockPaperScissor.HumanWinsCount = 0;
            RockPaperScissor.ComputerChoice = 0;
            RockPaperScissor.HumanChoice = 0;
            korszam.Content = "Kör: " + korszama + "/10";
            kor = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int kor1 = 0;
            kor1 = kor + 1;
            korszam.Content = "Kör: " + kor1+ "/10";
            eredmeny1= RockPaperScissor.ComputerWinsCount;
            eredmeny2 = RockPaperScissor.HumanWinsCount;
            eredmeny3 = RockPaperScissor.TiesCount;

            if (kor1 == 10)
            {
                MessageBox.Show("Vége a játéknak!\n Az eredményt a bin / debug mappába lehet megnézni txt fájként", "Kő || Papír || Olló");
                StreamWriter File = new StreamWriter("Eredmény.txt");
                File.Write("Eredmény: " );
                File.Write("Számítógép:  " + eredmeny1);
                File.Write("Játékos:  " + eredmeny2);
                File.Write("Döntetlen  " + eredmeny3);
                File.Close();

            }
            

        }
        
    }
    
    
  
}

