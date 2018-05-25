using UnityEngine;
using UnityEngine.UI;


public class Zebra : LeaveEaters {
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;
    public string name;


    protected override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "zebra zebra";
    }

    protected override void EatLeaves()
    {
        Balloon.SetActive(true);
        text.text = "munch munch zank yee bra";
    }
}
