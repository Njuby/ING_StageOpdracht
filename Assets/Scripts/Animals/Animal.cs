using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Animal : MonoBehaviour {

    private void Start()
    {
        
    }

    protected abstract void SayHello();

    protected virtual void EatMeat()
    {

    }

    protected virtual void EatLeaves()
    {

    }

    protected virtual void PerformTrick()
    {

    }

    protected IEnumerator DoTrick()
    {
        for (int i = 0; i < 360; i++)
        {
            transform.localRotation = Quaternion.Euler(i, 0, 0);
            yield return new WaitForEndOfFrame();
        }
    }

}
