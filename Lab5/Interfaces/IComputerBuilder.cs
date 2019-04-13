using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2.Interfaces
{
    /// <summary>
    /// This interface is responsible for the methods all builders that implement this interface must have
    /// </summary>
    /// <typeparam name="T">Must be a computer</typeparam>
    public interface IComputerBuilder<out T> where T : Computer
    {
        /// <summary>
        /// This method must be implemented to add a case to the computer
        /// </summary>
        /// <param name="computerCase">Takes a Case Object</param>
        /// <returns>The computer with the case added to the computer</returns>
        IComputerBuilder<T> AddCase(Case computerCase);
        
        /// <summary>
        /// This method must be implemented to add a motherboard to the computer
        /// </summary>
        /// <param name="motherBoard">Takes a Motherboard Object</param>
        /// <returns>The computer with the motherboard added to the computer</returns>
        IComputerBuilder<T> AddMotherboard(Motherboard motherBoard);
        
        /// <summary>
        /// This method must be implemented to add a CPU to the motherboard of the computer
        /// </summary>
        /// <param name="cpu">Takes a CPU object</param>
        /// <returns>The computer with a cpu added to the motherboard of the computer</returns>
        IComputerBuilder<T> AddCpuToMotherboard(Cpu cpu);
        
        /// <summary>
        /// This method must be implemented to add the graphics card to the motherboard of the computer
        /// </summary>
        /// <param name="graphicsCard">Takes a GraphicsCard Object</param>
        /// <returns>The computer with a graphics card added to the motherboard</returns>
        IComputerBuilder<T> AddGraphicsCardToMotherboard(GraphicsCard graphicsCard);
        
        /// <summary>
        /// This method must be implemented to add a hard drive to the computer
        /// </summary>
        /// <param name="hardDrive">Takes a HardDrive Object</param>
        /// <returns>The computer with a hard drive added</returns>
        IComputerBuilder<T> AddHardDrive(HardDrive hardDrive);
        
        /// <summary>
        /// This method must be implemented to add the memory to the motherboard of the computer
        /// </summary>
        /// <param name="memory">Takes a Memory object</param>
        /// <returns>The computer with memory added to the motherboard</returns>
        IComputerBuilder<T> AddMemoryToMotherboard(Memory memory);
        
        /// <summary>
        /// This method is responsible for "Building the computer"
        /// </summary>
        /// <returns>The completed Computer object</returns>
        T Build();
    }
}
