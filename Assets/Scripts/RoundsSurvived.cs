using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundsSurvived : MonoBehaviour
{
    public Text RoundText;

    void OnEnable()
    {
        RoundText.text = PlayerStats.Rounds.ToString();
    }
}
