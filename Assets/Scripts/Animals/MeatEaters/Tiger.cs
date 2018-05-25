using UnityEngine;
using UnityEngine.UI;


public class Tiger : MeatEaters {
    public string name;
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;


    protected override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "rraaarww";
    }

    protected override void EatMeat()
    {
        Balloon.SetActive(true);
        text.text = "nomnomnom thx wubalubadubdub";
    }

    protected override void PerformTrick()
    {
        StartCoroutine(DoTrick());
    }

}
