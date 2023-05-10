using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Env2Controller : MonoBehaviour
{
    GameObject SmallTarget, BigTarget, Agent, Floor;
    // Start is called before the first frame update
    void Start()
    {
        SmallTarget = gameObject.transform.Find("Small Target").gameObject;
        BigTarget = gameObject.transform.Find("Big Target").gameObject;
        Agent = gameObject.transform.Find("Agent").gameObject;
        Floor = gameObject.transform.Find("Floor").gameObject;

        ResetEnv2();
    }

    void ResetEnv2()
    {
        Floor.transform.position = gameObject.transform.position;
        Agent.transform.position = Floor.transform.position + Vector3.up;
        SmallTarget.transform.position = Agent.transform.position + Vector3.left * 2;
        BigTarget.transform.position = Agent.transform.position + Vector3.right * 2.5f;
    }
}
