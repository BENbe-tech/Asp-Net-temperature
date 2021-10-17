using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace temperature.asmx
{
    /// <summary>
    /// Summary description for temperature
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class temperature : System.Web.Services.WebService
    {

    

        [WebMethod]
        public double CelciusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }

        [WebMethod]
        public double FahrenheitToCelcius(double d)
        {
            
            return (d - 32) * 5 / 9;
        }

    }
}
//double f, c;
//Console.WriteLine("Enter the value of Celsius:");
//c = Convert.ToDouble(Console.ReadLine());
//f = c * 9 / 5 + 32;
//Console.WriteLine(c + "°C in Fahrenheit is: " + f + "°F");
//Console.WriteLine("Enter the value of Fahrenheit:");
//f = Convert.ToDouble(Console.ReadLine());
//c = (f - 32) * 5 / 9;
//Console.WriteLine(f + "°F in Celsius is: " + c + "°C");
//Console.ReadLine();

//[WebMethod]
//public double temperaturedegree(double f)
//{

//    //enter the value of fahrenheit
//    double c, d;
//    d = convert.todouble(f);
//    c = (d - 32) * 5 / 9;
//    return c;

//}

//[webmethod]
//public double temperaurefahrenheit(double c)
//{
//    //enter the value of celsius
//    double f, d;
//    d = convert.todouble(c);
//    f = d * 9 / 5 + 32;

//    return f;

//}