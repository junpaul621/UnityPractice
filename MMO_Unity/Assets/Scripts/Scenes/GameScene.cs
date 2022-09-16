using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    // # Coroutine
    //1. 함수의 상태를 저장/복원 가능
    //  -> 엄청 오래 걸리는 작업을 잠시 끊거나
    //  -> 원하는 타이밍에 함수를 잠시 stop/복원하는 경우
    //2. return 우리가 원하는 타입 가능 클래스나 변수 등도 반환 가능
    //yield break; return에 해당
    //yield return new Test() { Id = 1};
    //시간 관리에 정말 편리하다

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
