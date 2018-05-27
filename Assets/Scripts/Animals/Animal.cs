using System.Collections;
using UnityEngine;
using Zoo;


    public abstract class Animal : MonoBehaviour
    {

    public string name,
        helloMessage,
        feedMeatMessage;

        //Each animal MUST have a message to say
        public abstract void SayHello();

        //Each of the following is optional and does NOTHING by DEFAULT
        public virtual void EatMeat()
        {

        }

        public virtual void EatLeaves()
        {

        }

        public virtual void PerformTrick()
        {

        }

        //Basic Trick. Can be overwritten
        public virtual IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }

