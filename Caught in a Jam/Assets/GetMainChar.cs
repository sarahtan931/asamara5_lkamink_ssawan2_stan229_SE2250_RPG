﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMainChar : MonoBehaviour
{

    public Sprite strawberry, peach, apple;
    private SpriteRenderer mySprite;
    private readonly string selectedCharacter = "SelectedCharacter";

    private void Awake()
    {
        mySprite = this.GetComponent<SpriteRenderer>();

    }
    // Start is called before the first frame update
    void Start()
    {
        int getCharacter;

        getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        switch (getCharacter)
        {
            case 2:
                mySprite.sprite = peach;
                break;
            case 3:
                mySprite.sprite = apple;
                break;
            case 1:
                mySprite.sprite = strawberry;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
