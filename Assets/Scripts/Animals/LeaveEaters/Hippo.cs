using UnityEngine;
using UnityEngine.UI;


public class Hippo : Animal {

    public string name;
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;

    public override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "splash";
    }

    public override void EatLeaves()
    {
        Balloon.SetActive(true);
        text.text = "munch munch lovely";
    }
}

