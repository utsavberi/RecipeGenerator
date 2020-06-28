using System;
using RecipeGenerator_Models;
using RecipeGenerator_DA;
using System.Data;

namespace RecipeGenerator_BL
{
    public class Recipe
    {
        public static RecipeInformation getFirstRecipe()
        {
            RecipeInformation recipeInformation = null;// new RecipeInformation();
            DataSet ds;

            //2rd Assignment
            //Get the demographics from database but get the connection string details from web.Config file
            ds = RecipeGenerator_DA.Recipe_DA.getFirstRecipe();

            if (ds.Tables.Count > 0)
            {
                var row = ds.Tables[0].Rows[0];
                recipeInformation = new RecipeInformation {
                    Id = Convert.ToInt32(row["id"]),
                    Title = Convert.ToString(row["title"]),
                    Ingredients = Convert.ToString(row["ingredients"]),
                    Method = Convert.ToString(row["Method"]),
                    ImageUrl = Convert.ToString(row["ImageUrl"]),
                    CreatedOn = Convert.ToString(row["title"])
                };
            }
            return recipeInformation;
        }

        public static int save(RecipeInformation recipeInformation)
        {
            return RecipeGenerator_DA.Recipe_DA.save(recipeInformation.Title, recipeInformation.Ingredients, recipeInformation.Method, recipeInformation.ImageUrl);
        }
    }
}
