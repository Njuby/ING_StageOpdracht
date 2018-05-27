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
            henk.name = "henk";
            henk.helloMessage = "roooaoaaaaar";
            henk.feedMeatMessage = "nomnomnom thx mate";
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            elsa.name = "elsa";
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            dora.name = "dora";
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            wally.name = "wally";
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            marty.name = "marty";  
            Donkey sam = Instantiate(donkey, transform).GetComponent<Donkey>();
            sam.name = "sam";
            Elephant bernard = Instantiate(elephant, transform).GetComponent<Elephant>();
            bernard.name = "bernard";


        }
    }

}
