using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    Coroutine co;
    protected override void Init()
    {
        base.Init();

        SceneType = Define.Scene.Game;

        Managers.UI.ShowSceneUI<UI_Inven>();


        co = StartCoroutine("CoExplodeAfterSeconds", 4.0f);
        StartCoroutine("CoStopExplode", 2.0f);
        // StopCoroutine(co);
    }

    IEnumerator CoExplodeAfterSeconds(float seconds)
    {
        Debug.Log("CountDown Start");
        yield return new WaitForSeconds(seconds);
        Debug.Log("Boom!");
        co = null;
    }

    IEnumerator CoStopExplode(float seconds)
    {
        Debug.Log("Stop Enter");
        yield return new WaitForSeconds(seconds);
        Debug.Log("Stop Execute");
            if (co != null)
        {
            StopCoroutine(co);
            co = null;
        }
    }

    public override void Clear()
    {

    }
}
