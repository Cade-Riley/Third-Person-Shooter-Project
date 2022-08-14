using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBasic : Target
{
    public override void OnHit()
    {

        transform.RotateAround(MainManager.Instance.player.transform.position, Vector3.up, Random.Range(-180, 180));
        transform.LookAt(MainManager.Instance.player.transform.position);
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + 180, 0);
        transform.Translate(Vector3.forward * Random.Range(-3,3));
    }
}
