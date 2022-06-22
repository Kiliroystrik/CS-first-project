using C__begginings;

var garage = new Garage();
var peugeot = new Car { Brand = "Peugeot", Color = Color.blue };
var ferrari = new Car { Brand = "Ferrari", Color = Color.red };
var camion = new Bus();
garage.Repare(camion);
garage.Repare(peugeot);
garage.MakeVehiculeCheck(ferrari);
garage.Paint(peugeot, Color.green);