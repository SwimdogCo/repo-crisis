using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystemManager : MonoBehaviour {
    public List<GameObject> WeaponsPrefabs;
    public GameObject RightHandWeaponPrefab;
    public GameObject LeftHandWeaponPrefab;

    private List<GameObject> weapons;
    private GameObject rightHandWeapon;
    private GameObject leftHandWeapon;

    // Use this for initialization
    void Start () {
        InitWeapons();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void InitWeapons()
    {
        weapons = new List<GameObject>();
        rightHandWeapon = new GameObject();
        leftHandWeapon = new GameObject();

        GameObject rightHand = GameObject.FindGameObjectWithTag("RightHand");
        rightHandWeapon = Instantiate(RightHandWeaponPrefab, RightHandWeaponPrefab.transform.position, RightHandWeaponPrefab.transform.rotation);
        rightHandWeapon.transform.parent = rightHand.transform;
        rightHandWeapon.transform.position = rightHand.transform.position;
        weapons.Add(Instantiate(WeaponsPrefabs[0], WeaponsPrefabs[0].transform.position, WeaponsPrefabs[0].transform.rotation));
        weapons[0].transform.parent = rightHandWeapon.transform;
        weapons[0].transform.position = rightHandWeapon.transform.position - weapons[0].transform.position;
    }
}
