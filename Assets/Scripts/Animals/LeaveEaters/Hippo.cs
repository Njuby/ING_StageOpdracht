using UnityEngine;
using UnityEngine.UI;

public class Hippo : LeaveEaters {

    public string name;
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;

    protected override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "splash";
    }

    protected override void EatLeaves()
    {
        Balloon.SetActive(true);
        text.text = "munch munch lovely";
    }
}

