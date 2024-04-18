using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayData 
{
    private int _level;
    public int Level => _level;

    public GameplayData() 
    {
        _level = 0;
    }

    public void IncreaseLevel()
    {
        _level++;
    }

}
