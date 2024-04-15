//Wrapping Code!!

using class_4._2;

Pizza chiTown = new ChicagoStyle();
chiTown.SetSize("Large");
chiTown = new Cheese(chiTown);
chiTown = new Cheese(chiTown);
chiTown = new Sausage(chiTown);
Console.WriteLine($"{chiTown.GetDesciption()} costs {chiTown.Cost()}");


Pizza stuffedCrust = new Cheese(new Cheese(new Sausage(new StuffedCrust)));
stuffedCrust.SetSize("Medium");
Console.WriteLine($"{stuffedCrust.GetDesciption()} cost {stuffedCrust.Cost()}");