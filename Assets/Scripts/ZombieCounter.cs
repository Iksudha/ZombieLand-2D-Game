using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieCounter : MonoBehaviour
{
    
    Text text;
    public static int zombieAmount;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = zombieAmount.ToString();
    }
}
