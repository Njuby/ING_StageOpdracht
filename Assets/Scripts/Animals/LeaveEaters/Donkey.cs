using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Donkey : Animal
{
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;
    // public string name;


    public override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "donkey donkey";
    }

    public override void EatLeaves()
    {
        Balloon.SetActive(true);
        text.text = "nom nom nom ";
    }
}
