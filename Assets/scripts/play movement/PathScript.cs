using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathScript : MonoBehaviour
{
    Node[] PathNode;
    public GameObject Player;
    public float MoveSpeed;
    float Timer;
    static Vector3 CurrentPositionHolder;
    int CurrentNode;
    void Start()
    {
        PathNode = GetComponentsInChildren<Node>();
        CheckNode();

        foreach(Node n in PathNode)
        {
            Debug.Log(n.name);
        }
    }
    void CheckNode()
    {
        Timer = 0;
        CurrentPositionHolder = PathNode[CurrentNode].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime * MoveSpeed;
        if (Player.transform.position != CurrentPositionHolder)
        {
            Player.transform.position = Vector3.Lerp(Player.transform.position, CurrentPositionHolder, Timer);
        }
        else
        {
            if(CurrentNode < PathNode.Length - 1)
                {
                CurrentNode++;
                CheckNode();

            }
        }
        
    }
}
