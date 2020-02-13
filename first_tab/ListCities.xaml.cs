using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
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

namespace App1
{
    /// <summary>
    /// Logique d'interaction pour ListCities.xaml
    /// </summary>
    public partial class ListCities : UserControl
    {

        public ListCities()
        {
            InitializeComponent();
        }


        /*public double CalculScore()
        {
            double score = 0;
            for (int j = 0; j < Cities.Count - 1; j++)
            {
                City villeDepart = Cities[j];
                City villeArrivee = Cities[j + 1];
                score += CalculDistance(villeDepart.X, villeDepart.Y, villeArrivee.X, villeArrivee.Y);
            }
            return score;
        }*/

        private double CalculDistance(double x1, double y1, double x2, double y2)
        {
            var difx = Math.Pow(x2 - x1, 2);
            var dify = Math.Pow(x2 - x1, 2);
            return Math.Sqrt(difx + dify);
        }
    }
}
