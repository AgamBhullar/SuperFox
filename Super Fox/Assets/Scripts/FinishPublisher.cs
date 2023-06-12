using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPublisher : MonoBehaviour
{
    private Action<bool> updateFinish;

    public void InitializeFinish(Action<bool> updateFinish)
    {
        this.updateFinish = updateFinish;
    }

    public void UpdateFinish(bool bossDead)
    {
        this.updateFinish(bossDead);
    }
}