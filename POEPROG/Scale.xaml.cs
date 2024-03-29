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
using System.Windows.Shapes;

namespace POEPROG
{
    /// <summary>
    /// Interaction logic for Scale.xaml
    /// </summary>
    public partial class Scale : Window
    {
        public static List<double> ScaleQuantity = new List<double>();
        public Scale()
        {
            InitializeComponent();
            //SCALE OPTIONS 
            ScalecomboBox.Items.Add("Scale by 0.5(Half) ");
            ScalecomboBox.Items.Add("Scale by Factor 2(double)");
            ScalecomboBox.Items.Add("Scale by Factor 3(tripple)");
        }

        private void ScalecomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void scalebutton_Click(object sender, RoutedEventArgs e)
        {
            //SCALE BUTTON
            double x;

            //Condition for SCALE 
            if (ScalecomboBox.SelectedIndex == 0)
            {
                for (int i = 0; i < CaptureRecipeDetails.Quantites.Count; i++)
                {
                    x = CaptureRecipeDetails.Quantites[i] * 0.5;
                    ScaleQuantity.Add(x);
                    scalelistBox.Items.Add("=====SCALE FACTOR BY HALF=====");
                    scalelistBox.Items.Add("Scale " + CaptureRecipeDetails.Quantites[i] + " " + "Scaled to : " + x);
                    scalelistBox.Items.Add("=====END REPORT=====");
                }
            }
            else if (ScalecomboBox.SelectedIndex == 1)
            {
                for (int i = 0; i < CaptureRecipeDetails.Quantites.Count; i++)
                {


                    x = CaptureRecipeDetails.Quantites[i] * 2;
                    ScaleQuantity.Add(x);
                    scalelistBox.Items.Add("=====SCALE FACTOR BY DOUBLE=====");
                    scalelistBox.Items.Add("Scale " + CaptureRecipeDetails.Quantites[i] + " " + "Scaled to : " +x);
                    scalelistBox.Items.Add("=====END OF REPORT=====");
                }
            }
            else if (ScalecomboBox.SelectedIndex == 2)
            {
                for (int i = 0; i < CaptureRecipeDetails.Quantites.Count; i++)
                {


                    x = CaptureRecipeDetails.Quantites[i] * 3;
                    ScaleQuantity.Add(x);
                    scalelistBox.Items.Add("=====SCALE FACTOR BY TRIPPLE=====");
                    scalelistBox.Items.Add("Scale " + CaptureRecipeDetails.Quantites[i] + " " + "Scaled to : " + x);
                    scalelistBox.Items.Add("=====END OF REPORT=====");
                }
            }
        }

        private void Menubutton_Click(object sender, RoutedEventArgs e)
        {
            //RETURN TO MENU 
            MainWindow objMenu = new MainWindow();
            Close();
            objMenu.ShowDialog();
        }
    }
}
