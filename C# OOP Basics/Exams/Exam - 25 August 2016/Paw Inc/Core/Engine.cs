

using System;
using System.Linq;

namespace Paw_Inc.Core
{
    public class Engine
    {
        private CentresOperationsController processedData;
        public Engine()
        {
            this.processedData = new CentresOperationsController();
        }

        public void Run()
        {
            ReadData(this.processedData);
            PrintCentresData(this.processedData);
        }

        private void PrintCentresData(CentresOperationsController processedData)
        {
            Console.WriteLine("Paw Incorporative Regular Statistics");
            Console.WriteLine($"Adoption Centers: {processedData.AdoptionCentres.Count}");
            Console.WriteLine($"Cleansing Centers: {processedData.CleansingCentres.Count}");
            if (processedData.GetAllAdoptedAnimals().Count > 0)
            {
                Console.WriteLine($"Adopted Animals: {string.Join(", ", processedData.GetAllAdoptedAnimals())}");
            }
            else
            {
                Console.WriteLine("Adopted Animals: None");
            }
            if (processedData.GetAllCleansedAnimals().Count > 0)
            {
                Console.WriteLine($"Cleansed Animals: {string.Join(", ", processedData.GetAllCleansedAnimals())}");
            }
            else
            {
                Console.WriteLine("Cleansed Animals: None");
            }
            Console.WriteLine($"Animals Awaiting Adoption: {processedData.AnimalsWaitingForAdoption()}");
            Console.WriteLine($"Animals Awaiting Cleansing: {processedData.AnimalsWaitingForCleansing()}");
        }

        private static void ReadData(CentresOperationsController processedData)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Paw Paw Pawah"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var command = tokens[0];
                    tokens.RemoveAt(0);
                    var cmdArgs = tokens.ToArray();

                    switch (command)
                    {
                        case "RegisterCleansingCenter":
                            var cleansingCentreName = cmdArgs[0];
                            processedData.RegisterCleansingCenter(cleansingCentreName);
                            break;
                        case "RegisterAdoptionCenter":
                            var adoptionCentreName = cmdArgs[0];
                            processedData.RegisterAdoptionCenter(adoptionCentreName);
                            break;
                        case "RegisterCastrationCenter":
                            var castrationCenterName = cmdArgs[0];
                            processedData.RegisterCastrationCenter(castrationCenterName);
                            break;
                        case "RegisterDog":
                            processedData.RegisterDog(cmdArgs);
                            break;
                        case "RegisterCat":
                            processedData.RegisterCat(cmdArgs);
                            break;
                        case "SendForCleansing":
                            var adoptCentreName = cmdArgs[0];
                            var cleansCentreName = cmdArgs[1];
                            processedData.SendForCleansing(adoptCentreName, cleansCentreName);
                            break;
                        case "SendForCastration":
                            var adopCentreName = cmdArgs[0];
                            var castrationCentreName = cmdArgs[1];
                            processedData.SendForCastration(adopCentreName, castrationCentreName);
                            break;
                        case "Cleanse":
                            var cleanCentreName = cmdArgs[0];
                            processedData.Cleanse(cleanCentreName);
                            break;
                        case "Castrate":
                            var castrCenterName = cmdArgs[0];
                            processedData.Castrate(castrCenterName);
                            break;
                        case "Adopt":
                            var adCentreName = cmdArgs[0];
                            processedData.Adopt(adCentreName);
                            break;
                        case "CastrationStatistics":
                            Console.WriteLine("Paw Inc. Regular Castration Statistics");
                            Console.WriteLine($"Castration Centers: {processedData.CastrationCentres.Count()}");
                            if (processedData.GetAllCastratedAnimals().Count > 0)
                            {
                                Console.WriteLine($"Castrated Animals: {string.Join(", ", processedData.GetAllCastratedAnimals())}");
                            }
                            else
                            {
                                Console.WriteLine("Castrated Animals: None");
                            }
                            break;
                    }
                }
            }
        }
    }
}
