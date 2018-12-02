using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colony : MonoBehaviour
{

    public GameObject[] Units;
    public int UnitNum;
    private int unitCounter, frame;
    Vector3 Pos;
    void Awake()
    {
        Pos = this.gameObject.transform.position;
        unitCounter = 0;
    }
    void FixedUpdate()
    {
        if (unitCounter < 20 && frame == 0) Spawner();
        if (frame == 60)
            frame = 0;
        else frame++;
    }
    IEnumerator SpawnUnits()
    {
        yield return new WaitForSeconds(0);
        GameObject Unit = Units[0];
        Quaternion SpawnRotation = Quaternion.Euler(new Vector3(0, 180, 0));
        Vector3 SpawnPosition = new Vector3(Pos.x + Random.Range(3,-3), Pos.y + Random.Range(3,-3));
        Instantiate(Unit, SpawnPosition, SpawnRotation);
    }

    void Spawner()
    {
          StartCoroutine(SpawnUnits());
         unitCounter++;
    }
    
}