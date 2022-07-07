using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public SerializableDictionary<string, bool> coinsCollected; 

    public GameData()
    {
        coinsCollected = new SerializableDictionary<string, bool>();
    }
}
