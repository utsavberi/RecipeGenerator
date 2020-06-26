using System;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace RecipeGenerator_DA
{
    public class Recipe_DA
    {
        public static DataSet getFirstRecipe() {
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=recipe_generator;port=3306;password=password");
            DataSet dsRecipe = new DataSet();

            try
            {
                string sql = "Select id, title, ingredients, method, imageUrl from recipe limit 1";
                MySqlDataAdapter daRecipe = new MySqlDataAdapter(sql, con);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daRecipe);

                daRecipe.Fill(dsRecipe, "Recipe");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while fetching data from db: "+ex);
            }

            return dsRecipe;
        }
    }
}
