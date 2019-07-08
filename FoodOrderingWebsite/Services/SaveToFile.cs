using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using FoodOrderingWebsite.Models;

namespace FoodOrderingWebsite.Services
{
    public class SaveToFile : ISaveToFileService
    {
        const string ROOTPATH = @"../../../";
        public void AddToFIle(string name, Food foodData)
        {
            List<Food> previousList = GetFile(name);
            if (previousList!= null)
            {
                previousList.Add(foodData);
            }
            else
            {
                string filePath = Path.Combine(ROOTPATH, $"{name}.bin");
                Stream saveFileStream = File.Create(filePath);
                BinaryFormatter serializer = new BinaryFormatter();
                previousList.Add(foodData);
                serializer.Serialize(saveFileStream, previousList);
                saveFileStream.Close();
            }
            
        }

        public List<Food> GetFile(string name)
        {
            try
            {
                string filePath = Path.Combine(ROOTPATH, $"{name}.bin");
                Stream openFileStream = File.OpenRead(filePath);
                BinaryFormatter deserializer = new BinaryFormatter();

                List<Food> foods = (List<Food>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();
                return foods;
            }
            catch (Exception)
            {
                return null;                
            }
        }
    }
}
