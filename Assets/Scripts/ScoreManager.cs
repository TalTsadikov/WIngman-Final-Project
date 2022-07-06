using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int totalScore = 0;
    public static int levelScore = 0;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
