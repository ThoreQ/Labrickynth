using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDisableScript : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToAble;
    public static bool disabled = false;
    public static bool abled = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (disabled)
        {
            objectToDisable.SetActive(true);
            objectToAble.SetActive(false);
        }
        else
        {
            objectToDisable.SetActive(false);
            objectToAble.SetActive(true);
        }
    }
}
