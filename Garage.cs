namespace C__begginings
{
    public class Garage
    {
        public void MakeVehiculeCheck(Car car)
        {
            Console.WriteLine("Réalisation de l'entretient de la voiture de marque " + car.Color);
            car.DateEntretien = DateTime.Now;
        }
        public void Paint(Car car, Color newColor)
        {
            Console.WriteLine("Changement de la peinture du véhicule. Couleur originale = " + car.Color + ". Nouvelle couleur = " + newColor);
            car.Color = newColor;
        }
        public void Repare(Vehicule vehicule)
        {
            Console.WriteLine("Réparation d'un véhicule");
            vehicule.Repare = true;
        }
    }
}