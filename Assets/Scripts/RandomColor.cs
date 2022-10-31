using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColor : IChangeColor
{
    private Image image;

    public RandomColor(Image image)
    {
        this.image = image;
    }
    public void SetColor()
    {
        image.color = new Color(Random.RandomRange(0f, 1f), Random.RandomRange(0f, 1f), Random.RandomRange(0f, 1f));
    }
}
