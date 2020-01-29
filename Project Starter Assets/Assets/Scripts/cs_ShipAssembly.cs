using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cs_ShipAssembly : MonoBehaviour {

    //public GameObject[] shipSystem;
    //public Transform[] hardPoint;
    //private GameObject[] installSystem;
    //public GameObject shipClass;
    //public cs_ShipClass ref_cs_ShipClass;

    public int shipID;  // put 1 in this field

    public string shipClassID = "AntaresClass";

    public GameObject[] shipClass;

    public GameObject[] shipSystem;

    public GameObject baseShip;     // references the Player Character prefab

    void Awake ()
    {
        
	}

    void Start()
    {

        //GameObject shipClass = GameObject.FindWithTag("Antares");
        //ref_cs_ShipClass = shipClass.GetComponent<cs_ShipClass>();

        // baseShip gameobject, called Spaceship, is instantiated
        GameObject ship = Instantiate(baseShip, Vector3.zero, Quaternion.identity) as GameObject;     // Instantiates the baseShip prefab at the default position

        // based on the shipClassID, sprites and colliders are instantiated and parented to the baseShip gameobject
        GameObject instance = Instantiate(Resources.Load(shipClassID, typeof(GameObject))) as GameObject;

        // parents the newly instantiated shipClass prefab to the baseShip
        instance.transform.parent = ship.transform;

        // renames the prefab to get rid of the "(clone)"
        instance.name = "AntaresClass";

        // renames the newly instantiated baseShip prefab to include that number (example: Spaceship_00001)
        ship.name = "Spaceship_" + shipID.ToString("00000");

        // chosen ship systems are instantiated and parented to the ship's hardpoints

        
        // new process

        // hardPoint list's count is declared as being equal to cs_ShipClass.numberOfHardPoints
        // hardPoint list is populated with the position data from "cs_ShipClass"
        //for (int i = 0; i < ref_cs_ShipClass.numberOfHardPoints; i++)
        //{
            // A new gameobject called "HardPoint_" is created.  A "01" is added to the end.
            //GameObject hardPoint = new GameObject("HardPoint_" + (i + 1).ToString("00"));

            // HardPoint_01 is placed at a specified location.
            //hardPoint.transform.position = new Vector3(2, 4, 1);

            //GameObject installedSystem = Instantiate(Resources.Load("Prefabs/Ship Parts/" + ref_cs_ShipClass.shipSystem[i], typeof(GameObject))) as GameObject;
            //Debug.Log("HP_" + i);



        //}
        // shipSystem list's count is declared as being equal to cs_ShipClass.numberOfHardPoints
        // shipSystem list is populated with the prefabs from "cs_ShipClass"

        // a for loop does the following:
        //for (int i = 0; i < ref_cs_ShipClass.shipSystem.Count; i++)
        //{

        //}
        // The specified ship part for each shipSystem slot is created at the location of the hardpoint
        // The ship part is then parented to that transform

    }


}
