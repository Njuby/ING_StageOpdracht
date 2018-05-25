using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Animal : MonoBehaviour {


    public abstract void SayHello();

    public virtual void EatMeat()
    {

    }

    public virtual void EatLeaves()
    {

    }

    public virtual void PerformTrick()
    {

    }

    public IEnumerator DoTrick()
    {
        for (int i = 0; i < 360; i++)
        {
            transform.localRotation = Quaternion.Euler(i, 0, 0);
            yield return new WaitForEndOfFrame();
        }
    }

}
