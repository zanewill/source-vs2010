using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ImageParser
{
    public class SerializableOperate
    {
        public static void ObjectSerializable(object obj, string filePath)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, obj);
            }
            catch (IOException ex)
            {
                Console.WriteLine("序列化是出错！");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        public static object ObjectUnSerializable(string filePath)
        {
            FileStream fs = null;
            object obj = null;
            try
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                obj = bf.Deserialize(fs);
            }
            catch (IOException ex)
            {
                Console.WriteLine("反序列化时出错！");
            }
            catch (Exception ex)
            { 
            
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
            return obj;
        }
    }
}

