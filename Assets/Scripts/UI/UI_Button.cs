using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Button : UI_Base
{
    TextMeshProUGUI _text;

    enum Buttons
    {
        PointButton,
    }

    enum Texts
    {
        PointText,
        ScoreText,
    }

    enum GameObjects
    {
        TestObject,
    }

    enum Images
    {
        ItemIcon,
    }


    private void Start()
    {
        Bind<Button>(typeof(Buttons));
        //Bind<Text>(typeof(Texts));
        Bind<TextMeshProUGUI>(typeof(Texts));
        Bind<GameObject>(typeof(GameObjects));
        Bind<Image>(typeof(Images));

        // GetText((int)Texts.ScoreText).text = "BindTest";

        GetButton((int)Buttons.PointButton).gameObject.AddUIEvent(OnButtonClicked);

        GameObject go = GetImage((int)Images.ItemIcon).gameObject;
        AddUIEvent(go, (PointerEventData data) => { go.transform.position = data.position; }, Define.UIEvent.Drag);
    }

    int _score = 0;

    public void OnButtonClicked(PointerEventData data)
    {
        _score++;
        GetText((int)Texts.ScoreText).text = $"{_score} Points";
    }
}
