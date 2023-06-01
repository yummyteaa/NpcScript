using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье NPC
    public int heath = 5;
    //Уровень NPC
    public int level = 1;
    //Скорость NPC
    public float speed = 1.2f;
    Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        //Здоровье + уровень
        heath += level;
        //количество зворовья
        print (heath);
            }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
