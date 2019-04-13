using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;

namespace UnitTestsLab5
{
    [TestClass]
    public class Project1
    {        
        [TestMethod]
        public void CreateStuffedAnimal()
        {
            ToyFactory factory = new ToyFactory();
            ToyStuffedAnimal stuffedAnimal = factory.CreateToy<ToyStuffedAnimal>(25,"Spider stuffed animal","Spidy","Spider guys", 2019, 1, 100, false, 3);
            stuffedAnimal.LayThere();
            stuffedAnimal.LookCute();
        }
        [TestMethod]
        public void CreateRainbowStacker()
        {
            ToyFactory factory = new ToyFactory();
            ToyRainbowStacker rainbowStacker = factory.CreateToy<ToyRainbowStacker>(10, "Colour stacker", "Stack me", "Rainbow babies", 2019, 1, 4, false, 1);
            rainbowStacker.KnockMeOver();
            rainbowStacker.Stack();
        }
        [TestMethod]
        public void CreateToyDollHouse()
        {
            ToyFactory factory = new ToyFactory();
            ToyDollhouse dollhouse = factory.CreateToy<ToyDollhouse>(150, "Gothic Dollhouse", "Goth Mansion", "Spooky girls", 2019, 12, 100, true, 30);
            dollhouse.OpenHouse();
            dollhouse.CloseHouse();
        }
        [TestMethod]
        public void CreateToyCar()
        {
            ToyFactory factory = new ToyFactory();
            ToyCar car = factory.CreateToy<ToyCar>(40, "Porshe", "My first porshe", "Porse", 2019, 15, 100, false, 10);
            car.MoveForward();
            car.MoveBackwards();
        }

    }
}
