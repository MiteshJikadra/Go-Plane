using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class SaveLoadManager : MonoBehaviour
{
    public static void saveData(HighScoreforSave saveScore)
    {
        //Debug.Log("Saving data");
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = new FileStream(Application.persistentDataPath + "/GoPlane.m", FileMode.Create);

        HighScoreforSave data = saveScore;

        bf.Serialize(file, data);
        file.Close();
    }

    public static HighScoreforSave LoadData()
    {
        if (File.Exists(Application.persistentDataPath + "/GoPlane.m"))
        {
            //Debug.Log("ll");
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = new FileStream(Application.persistentDataPath + "/GoPlane.m", FileMode.Open);

            HighScoreforSave data = bf.Deserialize(file) as HighScoreforSave;
            file.Close();
            return data;
        }
        else
        {
            //Debug.LogError("File does not exists");
            return null;
        }
    }

}

