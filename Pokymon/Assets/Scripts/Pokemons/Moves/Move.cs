using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    private MoveBase _base;
    public MoveBase Base
    {
        get => _base;
        set => _base = value;
    }
    private int _pp;
    public int Pp
    {
        get => _pp;
        set => _pp = value;
    }

    public Move(MoveBase mBase)
    {
        _base = mBase;
        Pp = mBase.Pp;
    }

}
