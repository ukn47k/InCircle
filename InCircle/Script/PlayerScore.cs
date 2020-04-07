using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int Hit;
    public Text text;

    private void Update()
    {
        text.text = Hit + " Hit";
    }
}
