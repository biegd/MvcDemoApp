namespace MvcDemoApp.Model
{
    public class PersonModel
    {
        public string Name { get; set; }

        public string GetGreeting()
        {
            return $"Hallo, {Name}!";
        }
    }
}
