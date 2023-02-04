using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LR11
{
    enum SearchKey
    {
        Unknown,
        Fio,
        Birth,
        Street,
        House
    }

    class Utils
    {
        public static SearchKey GetSearchKeyByText(string text)
        {
            if (text.Equals("ФИО"))
            {
                return SearchKey.Fio;
            }
            else if (text.Equals("Дата рождения"))
            {
                return SearchKey.Birth;
            }
            else if (text.Equals("Улица"))
            {
                return SearchKey.Street;
            }
            else if (text.Equals("Дом"))
            {
                return SearchKey.House;
            }
            return SearchKey.Unknown;
        }

        public static string GetTextBoxNameBySearchKey(SearchKey searchKey)
        {
            switch(searchKey)
            {
                case SearchKey.Fio:
                    return "fioTextBoox";

                case SearchKey.Birth:
                    return "birthTextBox";

                case SearchKey.Street:
                    return "streetTextBox";

                case SearchKey.House:
                    return "houseTextBox";

                case SearchKey.Unknown:
                default:
                    return "";
            }
        }

        public static void SerializeObject<ObjectType>(ObjectType obj, string filePath)
        {
            var formatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                formatter.Serialize(fileStream, obj);
            }
        }

        public static List<ObjectType> SearchInTheSerializedFile<ObjectType>(ObjectType person, string filePath)
        {
            List<ObjectType> objectList = new List<ObjectType>();
            try
            {
                var formatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    while (fileStream.Position < fileStream.Length)
                    {
                        var readedObject = (ObjectType)formatter.Deserialize(fileStream);
                        if(person.Equals(readedObject))
                        {
                            objectList.Add(readedObject);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                return objectList;
            }
            return objectList;
        }
    }
}
