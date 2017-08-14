namespace Wild_Farm
{
    public class FoodFactory
    {
        public static Food GetFood(string[] foodData)
        {
            var type = foodData[0];
            var quantity = int.Parse(foodData[1]);

            if (type.Equals("Meat"))
            {
                return new Meat(quantity);
            }
            else
            {
                return new Vegetable(quantity);
            }
        }
    }
}