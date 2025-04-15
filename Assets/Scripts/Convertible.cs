using UnityEngine;

public class Convertible : VehicleController //Inheritance
{

    protected override void Start() //Encapsulation and polymorphism

    {
        base.Start();
        Speed = 40f;

    }
}
