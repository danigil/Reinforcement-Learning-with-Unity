using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvController : MonoBehaviour
{
    GameObject Target, Agent, Floor;
    // Start is called before the first frame update
    void Awake()
    {
        Target = gameObject.transform.Find("Target").gameObject;
        Agent = gameObject.transform.Find("Agent").gameObject;
        Floor = gameObject.transform.Find("Floor").gameObject;


        ResetEnv();
    }

    public void ResetEnv()
    {
        Floor.transform.localPosition = gameObject.transform.localPosition;
        Agent.transform.localPosition = Floor.transform.localPosition + Vector3.up * 0.5f + Vector3.right * 2;
        Agent.transform.rotation = Quaternion.identity;

        float targetX = Random.Range(-0.25f, -3.25f);
        float targetY = Agent.transform.localPosition.y;
        float targetZ = Random.Range(-2.25f, 2.25f);
        Target.transform.localPosition = new Vector3(targetX, targetY, targetZ);
    }
}
