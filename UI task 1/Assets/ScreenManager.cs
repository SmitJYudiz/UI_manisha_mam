using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public static ScreenManager Instance;
    public GameObject personDetailsScreen;
    public GameObject homeScreen;
    public GameObject registerScreen;

    private void Awake()
    {
        Instance = this;
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
