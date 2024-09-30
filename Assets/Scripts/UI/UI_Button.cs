using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _text;

    int _score = 0;

    public void OnButtonClicked()
    {
        _score++;
        _text.text = $"{_score} points";
    }
}
