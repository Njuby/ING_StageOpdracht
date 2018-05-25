using UnityEngine;
using UnityEngine.UI;


public class Zebra : Animal {
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;
    public string name;


    public override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "zebra zebra";
    }

    public override void EatLeaves()
    {
        Balloon.SetActive(true);
        text.text = "munch munch zank yee bra";
    }
}
