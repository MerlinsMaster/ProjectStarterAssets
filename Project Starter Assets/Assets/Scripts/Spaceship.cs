using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{

    private void Start()
    {
        AudioManager.instance.PlaySound("laser", this.transform);
    }

}
