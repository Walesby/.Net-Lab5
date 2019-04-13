using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// This class represents the Factory responsible for creating the different toys
    /// </summary>
    public class ToyFactory
    {
        /// <summary>
        /// This generic method is responsible for creating the different types of toys that inherit from the Toy class
        /// </summary>
        /// <typeparam name="T">Anything that inherits from Toy</typeparam>
        /// <param name="cost">How much the toy will cost</param>
        /// <param name="description">What the toy does</param>
        /// <param name="name">Name of the toy</param>
        /// <param name="manufacturingCompany">What company made the toy</param>
        /// <param name="manufacturedYear">What year the toy was created</param>
        /// <param name="minimumAge">The minimum age you must be to play with the toy</param>
        /// <param name="maximumAge">The maximum age you can play with the toy</param>
        /// <param name="chokingHazard">If the toy contains anything that may be a choking hazard</param>
        /// <param name="weight">How much the toy weights</param>
        /// <returns></returns>
        public T CreateToy<T>(double cost, string description, string name, string manufacturingCompany,
            int manufacturedYear, int minimumAge, int maximumAge, bool chokingHazard, int weight) where T : Toy
        {
            // Gets what the type of toy that will be created
            var type = typeof(Toy).Assembly.DefinedTypes.FirstOrDefault(c => typeof(Toy).IsAssignableFrom(typeof(T)));
            // Get the constructor
            var constructor = type.GetConstructor(new Type[] { typeof(double), typeof(string), typeof(string), typeof(string) , typeof(int),
            typeof(int),typeof(int),typeof(int),typeof(bool),typeof(int)});
            // Returns the created Toy by invoking the constructor with all the information passed into the method
            return (T)constructor.Invoke(new object[] { cost,description,name,manufacturingCompany,
                    manufacturedYear,minimumAge,maximumAge,chokingHazard,weight});
        }
    }
}
