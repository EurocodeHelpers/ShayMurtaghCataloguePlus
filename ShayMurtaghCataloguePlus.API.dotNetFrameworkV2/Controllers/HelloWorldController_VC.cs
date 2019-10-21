using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShayMurtaghCataloguePlus.API.dotNetFrameworkV2.Controllers
{
    public class HelloWorldController_VC : Controller
    {
        //VC TYPE - CONTROLLER RETURNS THE VIEW AS WELL IN RAW HTML - NEXT WE WILL USE VIEWS
        
        
        // /HelloWorld/Index => returns "Hello World! as html 
        // /HelloWorld/ => returns "Hello World! as html (default is index)
        public string Index()
        {
            return "Hello World!";
        }

        // /HelloWorld/Hidden => returns "This is a hidden page..." as html.
        //Remember format is /{controller}/{action}/{id}
        public string Hidden()
        {
            return "This is a hidden page...";
        }
        // /HelloWorld/Welcome/?name=Peter&age=31
        // returns "Hello Peter, your age is 31."
        // /HelloWorld/Welcome/?name=Peter
        // returns "Hello Peter, your age is 10"
        public string Welcome(string name, int age = 10)
        {
            return HttpUtility.HtmlEncode($"Hello {name}! Your age is {age}");
        }

        //https://localhost:44306/HelloWorld/FavoriteNumber/3
        //Returns "Your favorite number is 3"
        //This is the more common option rather than passing them in as query strings like for the Welcome action
        public string FavoriteNumber(int id)
        {
            return HttpUtility.HtmlEncode($"Your favorite number is {id}");
        }

        /*
         * Add a custom route in RouteConfig.cs          * 
         * routes.MapRoute(name: "FavoriteFoodAndDrink", url: "{controller}/{action}/{food}/{drink}");
         * 
         */

        //https://localhost:44306/HelloWorld/FavoriteFoodAndDrink/FishAndChips/Coke
        //Returns "Your Favorite food is FishAndChips and your favorite drink is coke as HTML
        public string FavoriteFoodAndDrink(string food, string drink)
        {
            return $"Your favorite food is {food} and your favorite drink is {drink}.";
        }








    }
}