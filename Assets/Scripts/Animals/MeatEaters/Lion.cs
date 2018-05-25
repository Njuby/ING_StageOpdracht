using UnityEngine;
using UnityEngine.UI;


public class Lion : MeatEaters {
    public string name;
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;

    protected override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "roooaoaaaaar";
    }

    protected override void EatMeat()
    {
        Balloon.SetActive(true);
        text.text = "nomnomnom thx mate";
    }
}

