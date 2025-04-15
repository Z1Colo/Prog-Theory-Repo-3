using UnityEngine;

public class Bus : VehicleController //Inheritance
{

    protected override void Start() //Encapsulation and Polymorphism
    {
        base.Start();
        Speed = 30f;
    }

}

