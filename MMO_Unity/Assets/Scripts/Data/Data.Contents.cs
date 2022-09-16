using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Stat

[Serializable]
public class Stat
{
    //serializedField 넣으면 public 없어도 가능, 변수의 이름과 형식이 파일과 일치해야함
    public int level;
    public int hp;
    public int attack;
}

[Serializable]
public class StatData : ILoader<int, Stat>
{
    public List<Stat> stats = new List<Stat>();

    public Dictionary<int, Stat> MakeDict()
    {
        Dictionary<int, Stat> dict = new Dictionary<int, Stat>();
        foreach (Stat stat in stats)
            dict.Add(stat.level, stat);
        return dict;
    }
}

#endregion