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
                string sql = "Select id, title, ingredients, method, imageUrl from recipe order by id desc limit 1";
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

        public static int save(string title, string ingredients, string method, string imageUrl)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=recipe_generator;port=3306;password=password");
            DataSet dsRecipe = new DataSet();
            int retId = -1;
        
            string sql = "" +
                "insert into recipe(title, ingredients, method, imageUrl) values (@title, @ingredients, @method, @imageUrl);" +
                "Select LAST_INSERT_ID()";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@ingredients", ingredients);
            cmd.Parameters.AddWithValue("@method", method);
            cmd.Parameters.AddWithValue("@imageUrl", imageUrl);
            var t = cmd.ExecuteScalar();
            retId = Convert.ToInt32(t);
         
            return retId;
        }
    }
}
