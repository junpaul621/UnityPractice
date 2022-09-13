using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    // # Coroutine
    //1. �Լ��� ���¸� ����/���� ����
    //  -> ��û ���� �ɸ��� �۾��� ��� ���ų�
    //  -> ���ϴ� Ÿ�ֿ̹� �Լ��� ��� stop/�����ϴ� ���
    //2. return �츮�� ���ϴ� Ÿ�� ���� Ŭ������ ���� � ��ȯ ����
    //yield break; return�� �ش�
    //yield return new Test() { Id = 1};
    //�ð� ������ ���� ���ϴ�

    Coroutine co;
    protected override void Init()
    {
        base.Init();
        SceneType = Define.Scene.Game;

        Managers.UI.ShowSceneUI<UI_Inven>();

        co = StartCoroutine("ExplodeAfterSeconds", 4.0f);
        StartCoroutine("CoStopExplode", 2.0f);
    }

    IEnumerator CoStopExplode(float seconds)
    {
        Debug.Log("Stop Enter");
        yield return new WaitForSeconds(seconds);
        Debug.Log("Stop Execute!!");
        if (co != null)
        {
            StopCoroutine(co);
            co = null;
        }
    }

    IEnumerator ExplodeAfterSeconds(float seconds)
    {
        Debug.Log("Explode Enter");
        yield return new WaitForSeconds(seconds);
        Debug.Log("Explode Execute!!");
        co = null;
    }

    
    public override void Clear()
    {
        
    }
   
}
