using Problem2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Responsible for building a computer
    /// </summary>
    public class ComputerBuilder : IComputerBuilder<Computer>
    {
        /// <summary>
        /// Holds the Computer object that is being built
        /// </summary>
        private readonly Computer computer;

        /// <summary>
        /// Constructor that creates a new computer to be built
        /// </summary>
        public ComputerBuilder()
        {
            this.computer = new Computer();
        }

        /// <summary>
        /// This method adds a case to the computer object
        /// </summary>
        /// <param name="computerCase">Takes a Case object</param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder<Computer> AddCase(Case computerCase)
        {
            this.computer.Case = computerCase;
            return this;
        }

        /// <summary>
        /// This method adds a CPU Object to the Motherboard Object associated with the computer being built
        /// </summary>
        /// <param name="cpu">Takes a Cpu Object</param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder<Computer> AddCpuToMotherboard(Cpu cpu)
        {
            this.computer.MotherBoard.Cpu = cpu;
            return this;
        }

        /// <summary>
        /// This method adds a GraphicsCard Object to the Motherboard Object associated with the computer being built
        /// </summary>
        /// <param name="graphicsCard">Takes A GraphicsCard Object</param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder<Computer> AddGraphicsCardToMotherboard(GraphicsCard graphicsCard)
        {
            this.computer.MotherBoard.GraphicsCard = graphicsCard;
            return this;
        }

        /// <summary>
        /// This method adds a Memory Object to the Motherboard Object associated with the computer being built
        /// </summary>
        /// <param name="memory">Takes a Memory Object</param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder<Computer> AddMemoryToMotherboard(Memory memory)
        {
            this.computer.MotherBoard.Memory = memory;
            return this;
        }

        /// <summary>
        /// This method adds a HardDrive Object to the Computer that is being built
        /// </summary>
        /// <param name="hardDrive">Takes a HardDrive Object</param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder<Computer> AddHardDrive(HardDrive hardDrive)
        {
            this.computer.HardDrive = hardDrive;
            return this;
        }
       
        /// <summary>
        /// This method adds a Motherboard Object to the Computer that is being built
        /// </summary>
        /// <param name="motherBoard">Takes a Motherboard Object</param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder<Computer> AddMotherboard(Motherboard motherBoard)
        {
            this.computer.MotherBoard = motherBoard;
            return this;
        }

        /// <summary>
        /// This method is responsible for returning the completed Computer Object
        /// </summary>
        /// <returns>The completed computer</returns>
        public Computer Build()
        {
            return this.computer;
        }
    }
}
