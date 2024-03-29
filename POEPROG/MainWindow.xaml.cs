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

namespace POEPROG
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

        private void recipebutton_Click(object sender, RoutedEventArgs e)
        {
            //METHOD FOR CAPTURING RECIPE NAME 
            RecipeName objRecipeName = new RecipeName();
            Close();
            objRecipeName.ShowDialog();
            
           
        }

        private void recipedetailsbutton_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON FOR CAPTURE RECIPE DETAILS 

            CaptureRecipeDetails objCaptureRecipeDetails = new CaptureRecipeDetails();  
            Close();
            objCaptureRecipeDetails.ShowDialog();   
        }

        private void Displaybutton_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON FOR DISPLAY 

            DisplayRecipe objdisplayRecipe = new DisplayRecipe();   
            Close();
            objdisplayRecipe.ShowDialog();  
        }

        private void scalebutton_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON FOR SCALE 
            Scale objscale = new Scale();   
            Close();
            objscale.ShowDialog();
        }

        private void clearbutton_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON FOR DELETE/CLEAR
            Delete objDelete = new Delete();    
            Close();
            objDelete.ShowDialog();
        }

        private void Exitbutton_Click(object sender, RoutedEventArgs e)
        {
            //Button for EXIT 
            MessageBox.Show("Thank you for using iboy Application" +
                "\n Send us a feedback on " +
                "\nST10178848@rccconnect.edu.za or deandie17@gmail.com",
                "Iboy Application",MessageBoxButton.OK);
            Close();
        }
    }
}
