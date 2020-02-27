using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectScript : MonoBehaviour
{
    public int points = 0; //Punkty
    private GUIStyle guiStyle = new GUIStyle();

    void Update()
    {
        if (points >= 3)
        {
            ActiveDisableScript.disabled = true; //Aktywacja obiektu po zdobyciu 3 punktów
        }
    }

    private void OnGUI()
    {
        guiStyle.fontSize = 72;
        GUI.Label(new Rect(100, 100, 200, 100), "Score: " + points, guiStyle); //Wyświetlanie wyniku
    }
}