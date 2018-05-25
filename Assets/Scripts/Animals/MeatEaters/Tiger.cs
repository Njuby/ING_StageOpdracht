using UnityEngine;
using UnityEngine.UI;


public class Tiger : Animal {
    public string name;
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;


    public override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "rraaarww";
    }

    public override void EatMeat()
    {
        Balloon.SetActive(true);
        text.text = "nomnomnom thx wubalubadubdub";
    }

    public override void PerformTrick()
    {
        StartCoroutine(DoTrick());
    }

}
