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
        Agent.transform.localPosition = Floor.transform.localPosition + Vector3.up * 0.5f;
        Target.transform.localPosition = Agent.transform.localPosition + Vector3.left * 2;
    }
}
