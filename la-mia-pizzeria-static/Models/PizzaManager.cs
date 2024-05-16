namespace la_mia_pizzeria_static.Models
{
    public static class PizzaManager
    {
       public static List<Pizza> ListPizza = new List<Pizza>();
        public static Pizza CreatePizza(string name, string description, string image, decimal price)
        {
            Pizza pizza = new Pizza(name, description, image, price);
            return pizza;
        }
        public static void AddPizza(Pizza pizza)
        {
            ListPizza.Add(pizza);
        }
    }

}
