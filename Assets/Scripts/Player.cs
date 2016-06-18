﻿using UnityEngine;
using proto.packet;
using proto.payload;
//using System.Collections;


public class Player : MonoBehaviour {

    private int m_level = 1;
    private Vector3 m_Move;
    private SpriteRenderer m_spriteRender;
    private Transform m_transform;
    public float _speed = 0.05f;

    void Test() {
    }
       // Use this for initialization
    void Start ()  {
        m_spriteRender = GetComponent<SpriteRenderer> ();
        m_transform = GetComponent<Transform> ();
        Debug.Log ("sprite render");
    }

    // Update is called once per frame
    void Update () {
        if(Input.GetKeyDown("space")){
            LevelUp ();
        }

        if (Input.GetKey ("w")) {
            m_Move = Vector3.up * _speed;
            Move ();
        } else if (Input.GetKey ("s")) {
            m_Move = Vector3.down * _speed;
            Move ();
        } else if (Input.GetKey ("a")) {
            m_Move = Vector3.left * _speed;
            Move ();
        }
        else if (Input.GetKey ("d")) {
            m_Move = Vector3.right * _speed;
            Move ();
        }

    }

    void LevelUp() {
        m_level += 1;
        var name_1 = string.Format ("Tank_{0:D2}", m_level);
        Debug.Log ("name:" + name_1);
        var levelSprite = Resources.Load (name_1, typeof(Sprite)) as Sprite;
        m_spriteRender.sprite = levelSprite;
    }

    void Move() {
        m_transform.position += m_Move;
    }

}
