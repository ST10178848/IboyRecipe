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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public Delete()
        {
            InitializeComponent();
            foreach (string recipes in RecipeName.RecipeNames)
            {
                RecipescomboBox.Items.Add(recipes);
            }
        }

        private void Deletebutton_Click(object sender, RoutedEventArgs e)
        {
            //BUTTON FOR DELETE 

            for (int i = 0; i < RecipeName.RecipeNames.Count; i++) { 


                RecipescomboBox.Items.Add(RecipeName.RecipeNames[i]);

            
                       
                        if (RecipeName.RecipeNames[i] !="" && CaptureRecipeDetails.IngredientName[i] !="")
                        {
                            RecipeName.RecipeNames.Clear();
                            CaptureRecipeDetails.IngredientName.Clear();
                            CaptureRecipeDetails.FoodGroup.Clear();
                            CaptureRecipeDetails.NumberOfSteps.Clear();
                            CaptureRecipeDetails.Quantites.Clear();
                            CaptureRecipeDetails.UnitMesurement.Clear();
                            CaptureRecipeDetails.Calories.Clear();
                            CaptureRecipeDetails.Description.Clear();
                            Scale.ScaleQuantity.Clear();
                            MessageBox.Show("Recipe details deleted !", "Recipe Deleted", MessageBoxButton.OK);
                        } else
                        {
                            MessageBox.Show("No details were Found in one of the List");
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
