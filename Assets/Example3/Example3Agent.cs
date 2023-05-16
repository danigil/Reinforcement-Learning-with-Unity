using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class Example3Agent : Agent
{
    [SerializeField]
    private Transform targetTransform;
    public float moveSpeed = 2f;

    public MeshRenderer floorMeshRenderer;

    public override void OnEpisodeBegin()
    {
        //floorMeshRenderer.material.color = Color.white;
        transform.GetComponentInParent<EnvController>().ResetEnv();
    }

    public override void OnActionReceived(ActionBuffers actions)
    {

        float moveX = actions.ContinuousActions[0];
        float moveZ = actions.ContinuousActions[1];

        transform.position += new Vector3(moveX, 0, moveZ) * Time.deltaTime * moveSpeed;

        if (this.transform.localPosition.y < 0)
        {
            floorMeshRenderer.material.color = Color.red;
            SetReward(-1);
            EndEpisode();
        }
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        continuousActions[0] = Input.GetAxisRaw("Horizontal");
        continuousActions[1] = Input.GetAxisRaw("Vertical");
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.position);
        sensor.AddObservation(targetTransform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Target")
        {
            floorMeshRenderer.material.color = Color.green;
            SetReward(1);
            EndEpisode();
        }
    }
}
