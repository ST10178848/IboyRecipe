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
    /// Interaction logic for description.xaml
    /// </summary>
    public partial class description : Window
    {
       
        public description()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, RoutedEventArgs e)
        {

            //save button
        

        }

        private void Menubutton_Click(object sender, RoutedEventArgs e)
        {
            //MENU BUTTON
            CaptureRecipeDetails obj = new CaptureRecipeDetails();
            Close();
            obj.ShowDialog();
        }
       
    }
}
