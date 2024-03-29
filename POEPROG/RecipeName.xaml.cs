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
    /// Interaction logic for RecipeName.xaml
    /// </summary>
    public partial class RecipeName : Window
    {
      
       
        public static List<string> RecipeNames = new List<string>();
        public RecipeName()
        {
            InitializeComponent();
           

        }

        private void saveRecipebutton_Click(object sender, RoutedEventArgs e)
        {
            //button for save Recipe
            captureProductName();
        }
        public void captureProductName()
        {

            /*1- Check if the  textbox in not empty and save the product name into a List if not empty
            display error message if the textbox is empty*/

            //get the values entered in the txtbox and save into the variable
            string recipeName = recipeNametextBox.Text;

            if (recipeName != "")
            {
               //Save the product name into the List
                RecipeNames.Add( recipeName); 
                RecipeNames.Sort(); 
                recipeNametextBox.Clear();
                MessageBox.Show("Recipe Name : " + recipeName + " was saved!");
            }
            else
            {
                //Show an error message to the user
                //MessageBox.Show("Product Name Must Not Be Blank");
                MessageBox.Show("Recipe Name Must Not Be empty",
                    "Null Entry",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void Menubutton_Click(object sender, RoutedEventArgs e)
        {
            //MENU BUTTON 
            MainWindow objMenu = new MainWindow();
            Close();
            objMenu.Show(); 
        
        }
    }
}
