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

    protected override void Init()
    {
        base.Init();
        SceneType = Define.Scene.Game;

        Managers.UI.ShowSceneUI<UI_Inven>();

        Dictionary<int, Stat> dict = Managers.Data.StatDict;
    }

    public override void Clear()
    {
        
    }
   
}
