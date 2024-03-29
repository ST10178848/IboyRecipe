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
    /// Interaction logic for CaptureRecipeDetails.xaml
    /// </summary>
    public partial class CaptureRecipeDetails : Window
    {

        public static  List<string> IngredientName = new List<string>();
        public static  List<double> Quantites = new List<double>();
        public static  List<string> UnitMesurement = new List<string>();
        public static  List<string> FoodGroup = new List<string>();
        public static  List<double> Calories = new List<double>();
        public static  List<int> NumberOfSteps = new List<int>();
        public static List<string> Description = new List<string>();

        public  int numberOfsteps=1;
        public CaptureRecipeDetails()
        {
            InitializeComponent();
            //loop through the array/list and display all contents of the list into the lixtbox

            RecipeName.RecipeNames.Sort();
            foreach (string recipeN in RecipeName.RecipeNames)
            {
               
                recipecomboBox.Items.Add(recipeN);
                recipecomboBox.SelectedIndex = 0;
              
            }

            //Adding manually to my list =Food Description 

            FoodDescriptionlistBox.Items.Add("=====FOOD DESCRIPTION=====");
            FoodDescriptionlistBox.Items.Add("Fat : Cointains 8.8 calories  per gram");
            FoodDescriptionlistBox.Items.Add("Protein : Contains 4.1 calories per gram");
            FoodDescriptionlistBox.Items.Add("Dairy : Contains 40 calories per gram");
            FoodDescriptionlistBox.Items.Add("Starchy Food : Contains 4.1 calories per gram ");
            FoodDescriptionlistBox.Items.Add("Fruit and Vegetable : Contains 8 per gram");
            FoodDescriptionlistBox.Items.Add("====END OF FOOD DESCRIPTION====");
        }

        private void Savebutton_Click(object sender, RoutedEventArgs e)
        {
            //SAVE BUTTON
            //get the values entered in the txtbox and save into the variable
            string ingredient = IngredienttextBox.Text;
            string unitMeasurement = UnitMeasurementtextBox.Text;
            // double quantity =Convert.ToDouble(quantitytxb.AcceptsReturn);
            // double calories =Convert.ToDouble(caloriestxb.AcceptsReturn);
            string quantity = QuantitytextBox.Text;
            string FoodGroups = RadioButton.GroupNameProperty.Name;
            string calories = CaloriestextBox.Text; 
            string NumberOfStepss = NumberOfStepstextBox.Text;
           


            double x;
            //USE WHile


            if (ingredient != "" && unitMeasurement != "" && quantity != "" && calories != "" )
            {

                if (Convert.ToDouble(calories) > 300)
                {
                    MessageBox.Show("Calories exceed 300 !");
                }
                else if (Convert.ToDouble(calories) < 300)
                {

                    IngredientName.Add(ingredient);
                    IngredienttextBox.Clear();

                    UnitMesurement.Add(unitMeasurement);
                    UnitMeasurementtextBox.Clear();

                    Quantites.Add(Convert.ToDouble(quantity));
                    QuantitytextBox.Clear();

                    Calories.Add(Convert.ToDouble(calories));
                    CaloriestextBox.Clear();

                    //FoodGroup.Add(RadioButton.GroupNameProp);
                    if (FatradioButton.IsChecked==true)
                    {
                        FoodGroups = FatradioButton.Content.ToString();
                      
                        FoodGroup.Add(FoodGroups);
                    }else if (DairyradioButton.IsChecked==true)
                    {
                        FoodGroups = DairyradioButton.Content.ToString();
                        
                        FoodGroup.Add(FoodGroups);
                    }
                    else if (StarchyradioButton.IsChecked==true) 
                    {
                        FoodGroups = StarchyradioButton.Content.ToString();
                     
                        FoodGroup.Add(FoodGroups);
                    } else if (ProteinradioButton.IsChecked==true)
                    {
                        FoodGroups = ProteinradioButton.Content.ToString();
                       
                        FoodGroup.Add(FoodGroups);
                    } else if(FruitradioButton.IsChecked==true)
                    {
                        FoodGroups = FruitradioButton.Content.ToString();
                       
                        FoodGroup.Add(FoodGroups);
                    }

                    NumberOfSteps.Add(Convert.ToInt32(NumberOfStepss));
                    NumberOfStepstextBox.Clear();


                    MessageBox.Show("Recipe Details saved!");


                }

            }
            else
            {
                MessageBox.Show("Fill in missing field");
            }

        }

        private void ReturnMenubutton_Click(object sender, RoutedEventArgs e)
        {
            //RETURN TO MENU 
            MainWindow objMenu = new MainWindow();
            Close();
            objMenu.ShowDialog();
        }

        private void stepsbutton_Click(object sender, RoutedEventArgs e)
        {

            captureDescription();


        }
        public void captureDescription()
        {

            /*1- Check if the  textbox in not empty and save the product name into a List if not empty
            display error message if the textbox is empty*/

            //get the values entered in the txtbox and save into the variable
            string descr = DescriptiontextBox1.Text;

            if (descr != "")
            {
                //Save the product name into the List
                Description.Add(descr);
                DescriptiontextBox1.Clear();
                MessageBox.Show("Description was saved!" );
            }
            else
            {
                //Show an error message to the user
                //MessageBox.Show("Product Name Must Not Be Blank");
                MessageBox.Show("DescriptionMust Not Be empty",
                    "Null Entry",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }


    }
}
