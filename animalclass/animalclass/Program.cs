namespace animalclass
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Animal Animal1 = new Animal();
                Animal1.Mode_Of_Feeding= "Omnivorous";
                Animal1.Movement = true;
                Animal1.Respiration = "lungs";
                Animal1.Habitat = "terrestrial";
                Animal1.AnimalClass = "Mammal";
                Animal1.Colony = true;

                Animal Animal2 = new Animal();
                Animal2.Mode_Of_Feeding = "Carnivorous";
                Animal2.Movement = true;
                Animal2.Respiration = "Lungs";
                Animal2.Habitat = "Terrestrial";
                Animal2.AnimalClass = "Mammal";
                Animal2.Colony = true;

                Animal Animal3 = new Animal();
                Animal3.Mode_Of_Feeding = "Sucking";
                Animal3.Movement = true;
                Animal3.Respiration = "Lungs";
                Animal3.Habitat = "hive";
                Animal3.AnimalClass = "insecta";
                Animal3.Colony = true;

                Animal Animal4 = new Animal();
                Animal4.Mode_Of_Feeding = "carnivorous";
                Animal4.Movement = true;
                Animal4.Respiration = "lungs";
                Animal4.Habitat = "False";
                Animal4.AnimalClass = "Mammal";
                Animal4.Colony = true;

                Animal Animal5 = new Animal();
                Animal5.Mode_Of_Feeding = "carnivorous";
                Animal5.Movement = true;
                Animal5.Respiration = "lungs";
                Animal5.Habitat = "Tereestrial";
                Animal5.AnimalClass = "viviparous";
                Animal5.Colony = true;

                Animal Animal6 = new Animal();
                Animal6.Mode_Of_Feeding = "omnivours";
                Animal6.Movement = true;
                Animal6.Respiration = "lungs";
                Animal6.Habitat = "Terrestrial";
                Animal6.AnimalClass = "Mammal";
                Animal6.Colony = true;

                Animal animal7 = new Animal ("Carnivour", true, "Terrestrial", true, "Lungs", "Mammal");*/

            /*Console.WriteLine(animal7.Habitat);*/

            /*List<Animal> Animals = new List<Animal>();

            Animals.Add(Animal1);
            Animals.Add(Animal2);
            Animals.Add(Animal3);
            Animals.Add(Animal4);
            Animals.Add(Animal5);
            Animals.Add(Animal6);
            Animals.Add(animal7);

            foreach (var Animal in Animals)
            {
                Console.WriteLine($"Habitat: {Animal.Habitat}, " + 
                    $"Mode_of_Feeding: {Animal.Mode_Of_Feeding}, " +
                    $"Movement: {Animal.Movement}, " +
                    $"Colony: {Animal.Colony}, " +
                    $"Respiration: {Animal.Respiration}");
                Console.WriteLine(""); }*/
        

            List<Animal> read = new List<Animal>
               {
                     new Animal  ("Carnivour", true, "Terrestrial", true, "Lungs", "Mammal"),
                     new Animal ("Herbivour", true, "Terrestrial", false, "Lungs", "Mammal"),
                     new Animal ("Carnivour", true, "Terrestrial", true, "Lungs", "Mammal"),
               };


                foreach(var check in read )
                    {
                    Console.WriteLine(check.AnimalClass);
                    }

         }
       
    }
    
        

}

