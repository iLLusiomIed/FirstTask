using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drawer : IShow
{
    private Text text;
    public Drawer(Text text)
    {
        this.text = text;
    }

    public void ShowInfo(string info)
    {
        text.text = info;
    }
}
