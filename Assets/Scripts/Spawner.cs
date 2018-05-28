using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra, donkey, elephant;
        private void Awake()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            henk.name = "1";
            henk.helloMessage = "roooaoaaaaar";
            henk.feedMeatMessage = "nomnomnom thx mate";
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            elsa.name = "2";
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            dora.name = "3";
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            wally.name = "4";
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            marty.name = "5";  
            Donkey sam = Instantiate(donkey, transform).GetComponent<Donkey>();
            sam.name = "6";
            Elephant bernard = Instantiate(elephant, transform).GetComponent<Elephant>();
            bernard.name = "7";


        }
    }

}
