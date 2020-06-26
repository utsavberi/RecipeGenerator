using System;
using System.ComponentModel;

namespace RecipeGenerator_Models
{
    public class RecipeInformation
    {
        [DisplayName("id")]
        public int Id { get; set; }

        [DisplayName("Title")]
        public string Title { get; set; }

        [DisplayName("Ingredients")]
        public string Ingredients { get; set; }

        [DisplayName("Method")]
        public string Method { get; set; }

        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }

        [DisplayName("Created On")]
        public string CreatedOn { get; set; }

        /*
         title, ingredients, method, imageUrl, createdOn
        */


    }
}
