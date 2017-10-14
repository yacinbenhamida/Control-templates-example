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

namespace TD_N2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
           
        }
        Competiteur cmp = new Competiteur();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try{
            lstComp.DataContext = CompetiteurCRUD.ListerCompt();
            cmp = CompetiteurCRUD.getCompetiteur();
            stInfo.DataContext = cmp;
            }catch(Exception ex){MessageBox.Show(ex.Message);}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try 
           {
                CompetiteurCRUD.AjouterCompetiteur(cmp);
                lstComp.DataContext = CompetiteurCRUD.ListerCompt();
            }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
