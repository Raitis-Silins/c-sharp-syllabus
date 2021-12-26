namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "funny snorting noise ";
        }

        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }

        public override string Eat(Food type)
        {
            if (type is Vegetable)
            {
                FoodEaten += type.Quantity;
                return $"{AnimalType} [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
            }

            return $"{AnimalType} are not eating that type of food!";
        }
    }
}