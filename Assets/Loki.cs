using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loki : MonoBehaviour {
    static public Loki S;
    [Header("Set in Inspector")]

    public float speed = 30;
    public float rollMult = -45;
    public float PitchMult = 30;
    public float gameRestartDelay = 2f;
    public float JumpSpeed = 8f;
    public float gravity = 30f;
    public GameObject projectilePrefab;
    public float projectileSpeed = 40;
    [Header("Set dynamically")]
    [SerializeField]
    public float _sheildLevel = 1;

    private GameObject lastTriggerGo = null;

    void Awake()
    {
        if (S == null)
        {
            S = this;
        }
        else
        {
            Debug.LogError("Hero.Awake() - attapted to assign second Hero.S!");
        }
    }


    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.position = pos;

      

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pos.y = JumpSpeed;
        }
        pos.y -= gravity * Time.deltaTime;
    }

}

