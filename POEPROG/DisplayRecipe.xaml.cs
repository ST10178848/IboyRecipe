using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace POEPROG
{
    /// <summary>
    /// Interaction logic for DisplayRecipe.xaml
    /// </summary>
    public partial class DisplayRecipe : Window
    {
        public DisplayRecipe()
        {
            InitializeComponent();

            // Populating my combobox with ingredient name 
            foreach (string ingredient in CaptureRecipeDetails.IngredientName)
            {
                IngredientNamescomboBox.Items.Add(ingredient);
            }

            // Populating my combobox with food group 
            foreach (string food in CaptureRecipeDetails.FoodGroup)
            {
                FoodGroupcomboBox.Items.Add(food);
            }

            // Populating my combobox with max number of calories 
            foreach (double calories in CaptureRecipeDetails.Calories)
            {
                CaloriescomboBox.Items.Add(calories);
            }
        }

        private void Viewbutton_Click(object sender, RoutedEventArgs e)
        {
            RecipesDetailslistBox.Items.Clear();
            int prodCnt = 1; // For the purpose of displaying a numbered list

            // Add Labels
            RecipesDetailslistBox.Items.Add("======USER INPUT======");

            for (int i = 0; i < CaptureRecipeDetails.IngredientName.Count; i++)
            {
                if (FoodGroupcomboBox.SelectedItem == CaptureRecipeDetails.FoodGroup[i] ||
                    IngredientNamescomboBox.SelectedValue == CaptureRecipeDetails.IngredientName[i] ||
                    CaloriescomboBox.SelectedIndex == CaptureRecipeDetails.Calories[i])
                {
                    // Display recipe details
                    RecipesDetailslistBox.Items.Add("Recipe Name " + prodCnt + " : " + RecipeName.RecipeNames[i] +
                        "\n Ingredient Name : " + CaptureRecipeDetails.IngredientName[i] +
                        "\n Quantity : " + CaptureRecipeDetails.Quantites[i] +
                        "\n Unit Measurement : " + CaptureRecipeDetails.UnitMesurement[i] +
                        "\n Food Group : " + CaptureRecipeDetails.FoodGroup[i] +
                        "\n Calories : " + CaptureRecipeDetails.Calories[i] +
                        "\n---------------------------------------------------------");
                    prodCnt++;

                    // Display recipe steps
                    if (i < CaptureRecipeDetails.NumberOfSteps.Count && CaptureRecipeDetails.NumberOfSteps[i] > 0)
                    {
                        RecipesDetailslistBox.Items.Add("\n Number of Steps : " + CaptureRecipeDetails.NumberOfSteps[i]);

                        // Iterate over the steps for this recipe
                        for (int stepIndex = 0; stepIndex < CaptureRecipeDetails.NumberOfSteps[i]; stepIndex++)
                        {
                            int descriptionIndex = i * CaptureRecipeDetails.NumberOfSteps[i] + stepIndex;
                            if (descriptionIndex < CaptureRecipeDetails.Description.Count)
                            {
                                RecipesDetailslistBox.Items.Add(" Step " + (stepIndex + 1) + " : " + CaptureRecipeDetails.Description[descriptionIndex]);
                            }
                        }
                    }
                }
            }

            if (CaptureRecipeDetails.Calories.Sum() > 300)
            {
                RecipesDetailslistBox.Items.Add("Your Total Calories : " + CaptureRecipeDetails.Calories.Sum() + " High Calories is not Healthy" +
                    "\n---------------------------------------------------------");
                MessageBox.Show("Calories " + CaptureRecipeDetails.Calories.Sum() + " exceed 300, having high calories is not healthy.");
            }
            else
            {
                RecipesDetailslistBox.Items.Add("Total Calories : " + CaptureRecipeDetails.Calories.Sum() +
                    "\n---------------------------------------------------------");
            }
            RecipesDetailslistBox.Items.Add("========END OF REPORT========");
        }

        private void Menubutton_Click(object sender, RoutedEventArgs e)
        {
            // MENU BUTTON
            // Return to menu 
            MainWindow objMenu = new MainWindow();
            Close();
            objMenu.ShowDialog();
        }

        private void viewScalebutton_Click(object sender, RoutedEventArgs e)
        {
            RecipesDetailslistBox.Items.Clear();
            int prodCnt = 1; // For the purpose of displaying a numbered list

            // Add Labels
            RecipesDetailslistBox.Items.Add("======RECIPE WITH SCALE QUANTITIES======");

            for (int i = 0; i < CaptureRecipeDetails.IngredientName.Count; i++)
            {
                if (FoodGroupcomboBox.SelectedItem == CaptureRecipeDetails.FoodGroup[i] || IngredientNamescomboBox.SelectedValue == CaptureRecipeDetails.IngredientName[i]
                    || CaloriescomboBox.SelectedIndex == CaptureRecipeDetails.Calories[i])
                {
                    // Display recipe details
                    RecipesDetailslistBox.Items.Add("Recipe Name " + prodCnt + " : " + RecipeName.RecipeNames[i] +
                        "\n Ingredient Name : " + CaptureRecipeDetails.IngredientName[i] +
                        "\n Scaled Quantity : " + Scale.ScaleQuantity[i] +
                        "\n Unit Measurement : " + CaptureRecipeDetails.UnitMesurement[i] +
                        "\n Food Group : " + CaptureRecipeDetails.FoodGroup[i] +
                        "\n Calories : " + CaptureRecipeDetails.Calories[i] +
                        "\n---------------------------------------------------------");
                    prodCnt++;

                    // Display recipe steps
                    if (i < CaptureRecipeDetails.NumberOfSteps.Count && CaptureRecipeDetails.NumberOfSteps[i] > 0)
                    {
                        RecipesDetailslistBox.Items.Add("\n Number of Steps : " + CaptureRecipeDetails.NumberOfSteps[i]);

                        // Iterate over the steps for this recipe
                        for (int stepIndex = 0; stepIndex < CaptureRecipeDetails.NumberOfSteps[i]; stepIndex++)
                        {
                            int descriptionIndex = i * CaptureRecipeDetails.NumberOfSteps[i] + stepIndex;
                            if (descriptionIndex < CaptureRecipeDetails.Description.Count)
                            {
                                RecipesDetailslistBox.Items.Add(" Step " + (stepIndex + 1) + " : " + CaptureRecipeDetails.Description[descriptionIndex]);
                            }
                        }
                    }
                }
            }

            if (CaptureRecipeDetails.Calories.Sum() > 300)
            {
                RecipesDetailslistBox.Items.Add("Your Total Calories : " + CaptureRecipeDetails.Calories.Sum() + " High Calories is not Healthy" +
                    "\n---------------------------------------------------------");
                MessageBox.Show("Calories " + CaptureRecipeDetails.Calories.Sum() + " exceed 300, having high calories is not healthy.");
            }
            else
            {
                RecipesDetailslistBox.Items.Add("Total Calories : " + CaptureRecipeDetails.Calories.Sum() +
                    "\n---------------------------------------------------------");
            }
            RecipesDetailslistBox.Items.Add("========END OF REPORT========");
        }
    }
}
