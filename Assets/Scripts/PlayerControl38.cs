using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//бтблтотеки

public class PlayerControl38 : MonoBehaviour
//название класса    
{
    //lesson 39
    public int speed = 20;

    void Start()
    //метод исполн 1 раз
    {
        
    }

  
    void Update()
    //метод исполн много раз
    {
        // для перемещ меняем комп трансформ
        //Translate функция для передвижения
        //new Vector3 направл движения
        //lessson 38
        //transform.Translate(new Vector3(0,0,1));

        //lesson 39
        // Time.deltaTime - сколько время между 2 кадрами игры . проверяем без speed
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
