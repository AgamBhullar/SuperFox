using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StompManager : MonoBehaviour
{
    private Action jump;

    public void InitializeJump(Action jump)
    {
        this.jump = jump;
    }

    public void ExecuteStomp()
    {
        this.jump();
    }
}