namespace Wild_Farm
{
    public class AnimalFactory
    {
        public static Animal GetAnimal(string[] animalData)
        {
            var type = animalData[0];
            var name = animalData[1];
            var weight = double.Parse(animalData[2]);
            var livingRegion = animalData[3];

            switch (type)
            {
                case "Mouse":
                    return new Mouse(name, type, weight, livingRegion);
                case "Zebra":
                    return new Zebra(name, type, weight, livingRegion);
                case "Tiger":
                    return new Tiger(name, type, weight, livingRegion);
                case "Cat":
                    var breed = animalData[4];
                    return new Cat(name, type, weight, livingRegion, breed);
                default:
                    return null;
            }
        }
    }
}