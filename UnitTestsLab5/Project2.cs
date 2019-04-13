using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;
using Problem2.Interfaces;
using System;

namespace UnitTestsLab5
{
    [TestClass]
    public class Project2
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBuilderWithCPUClockSpeedToLowThrowsExceptionPass()
        {
            // Arrange
            IComputerBuilder<Computer> builder = new ComputerBuilder();
            Cpu cpu = new Cpu(0.00,"Intel","LGA 1151",8,4);
            HardDrive hardDrive = new HardDrive(1000,"SSD",400,400);
            Motherboard motherBoard = new Motherboard(4,10.5,4,"ATX",10);
            Memory memory = new Memory(2666,2666,"DDR4",32);
            GraphicsCard graphicsCard = new GraphicsCard(2,2.9,6000,600);
            Case computerCase = new Case(100,100,100,6,4);
            
            // Act
            Computer testComputer = builder.AddCase(computerCase)
                                           .AddMotherboard(motherBoard)
                                           .AddCpuToMotherboard(cpu)
                                           .AddGraphicsCardToMotherboard(graphicsCard)
                                           .AddMemoryToMotherboard(memory)
                                           .AddHardDrive(hardDrive)                                          
                                           .Build();
        }
        [TestMethod]
        public void TestBuilderWithCorrectCPUClockSpeedPass()
        {
            // Arrange
            IComputerBuilder<Computer> builder = new ComputerBuilder();
            Cpu cpu = new Cpu(4.00, "Intel", "LGA 1151", 8, 4);
            HardDrive hardDrive = new HardDrive(1000, "SSD", 400, 400);
            Motherboard motherBoard = new Motherboard(4, 10.5, 4, "ATX", 10);
            Memory memory = new Memory(2666, 2666, "DDR4", 32);
            GraphicsCard graphicsCard = new GraphicsCard(2, 2.9, 6000, 600);
            Case computerCase = new Case(100, 100, 100, 6, 4);

            // Act
            Computer testComputer = builder.AddCase(computerCase)
                                           .AddMotherboard(motherBoard)
                                           .AddCpuToMotherboard(cpu)
                                           .AddGraphicsCardToMotherboard(graphicsCard)
                                           .AddMemoryToMotherboard(memory)
                                           .AddHardDrive(hardDrive)                                           
                                           .Build();
            // Assert
            Assert.AreEqual(cpu, testComputer.MotherBoard.Cpu);
            Assert.AreEqual(hardDrive, testComputer.HardDrive);
            Assert.AreEqual(motherBoard, testComputer.MotherBoard);
            Assert.AreEqual(memory, testComputer.MotherBoard.Memory);
            Assert.AreEqual(graphicsCard, testComputer.MotherBoard.GraphicsCard);
            Assert.AreEqual(computerCase, testComputer.Case);
        }
    }
}
