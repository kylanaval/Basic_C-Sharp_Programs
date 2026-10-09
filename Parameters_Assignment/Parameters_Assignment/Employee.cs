
using System.Collections.Generic; // Allows us to use the generic List<T> collection.

namespace Generics_Assignment // Defines the namespace for this application.
{
    // Creates a generic Employee class.
    // T represents the data type that will be specified when an Employee object is created.
    public class Employee<T>
    {
        // Creates a property named Things that stores a list of items of type T.
        // The list can contain strings, integers, or other data types.
        public List<T> Things { get; set; }
    }
}