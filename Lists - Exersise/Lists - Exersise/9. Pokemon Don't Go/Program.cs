using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
//You will receive a sequence of integers, separated by spaces – the distances to the pokemon. Then you will begin 
//receiving integers, which will correspond to indexes in that sequence.
//When you receive an index, you must remove the element at that index from the sequence (as if you've captured 
//the pokemon)

//You must increase the value of all elements in the sequence, which are less or equal to the removed 
//element, with the value of the removed element.
//• You must decrease the value of all elements in the sequence, which are greater than the removed element,
//with the value of the removed element.

namespace _9._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> distancesToPokemon = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
          
            int sumOfRemovedElements = 0;
            while (distancesToPokemon.Count > 0)
            {
                int currentIndex = int.Parse(Console.ReadLine());
                int elementToOperate = default;
                if (currentIndex < 0)
                {
                    currentIndex = 0;
                     elementToOperate = distancesToPokemon[currentIndex];
                    sumOfRemovedElements += elementToOperate;

                    distancesToPokemon.RemoveAt(0);
                    distancesToPokemon.Insert(0, distancesToPokemon[distancesToPokemon.Count - 1]);
                }
                else if (currentIndex >= distancesToPokemon.Count)
                {
                    currentIndex = distancesToPokemon.Count - 1;
                    elementToOperate = distancesToPokemon[currentIndex];
                    sumOfRemovedElements += elementToOperate;
                    distancesToPokemon.RemoveAt(distancesToPokemon.Count - 1);
                    distancesToPokemon.Add(distancesToPokemon[0]);
                }
                else
                {
                    elementToOperate = distancesToPokemon[currentIndex];
                    sumOfRemovedElements += elementToOperate;
                    distancesToPokemon.RemoveAt(currentIndex);
                }
                
                
                
              
                for(int i = 0; i < distancesToPokemon.Count; i++)
                {
                    
                    
                    if (distancesToPokemon[i] <= elementToOperate)
                    {
                        distancesToPokemon[i] += elementToOperate;
                    }
                    else
                    {
                        distancesToPokemon[i]-=elementToOperate;
                    }

                }
            } Console.WriteLine(sumOfRemovedElements);
        }
    }
}
