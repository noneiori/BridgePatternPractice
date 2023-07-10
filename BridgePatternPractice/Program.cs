// See https://aka.ms/new-console-template for more information

IImplementor dangerAnimalImplementor = new DangerAnimalImplementor();
IImplementor cuteAnimalImplementor = new CuteAnimalImplementor();

//產生三種動物
Animal lion = new DangerAnimal(dangerAnimalImplementor);
Animal python = new DangerAnimal(dangerAnimalImplementor);
Animal rabbit = new CuteAnimal(cuteAnimalImplementor);


Console.WriteLine("lion:");
lion.Feed();
lion.Touch();

Console.WriteLine("python:");
python.Feed();
python.Touch();

Console.WriteLine("rabbit:");
rabbit.Feed();
rabbit.Touch();
