namespace Packt.CS7
{
    public partial class Person
    {
        // -- Read-Only Properties -- //
        // Property defined using c# 1-5 syntax 
        public string Origin{ 
            get { return $"{Name} was born on {HomePlanet}"; }
        }
        // two properties defined using c# 6+ & lambda expression sysntax
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => (int)(System.DateTime.Today.Subtract(DateOfBirth).TotalDays / 365.25 );

        // -- Settable Properties -- //
        public string FavoriteIceCream { get; set; } // auto-syntax 

        // If more control needed, do this:
        private string favoritePrimaryColor;
        public string FavoritePrimaryColor{
            get { return favoritePrimaryColor; }
            set {
                switch (value.ToLower()){
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                    break;
                    default:
                        throw new System.ArgumentException($"{value} is not a primary color. Choose from: red, green, blue");
                }
            }
        }
        // indexers -- allow the calling code to use the array syntax to access a property -- Only use them if it makes sense to use the square bracket/array syntax //
        public Person this[int index]
        {
            get { return Children[index]; }
            set {  Children[index] = value; }
        }
    }
}