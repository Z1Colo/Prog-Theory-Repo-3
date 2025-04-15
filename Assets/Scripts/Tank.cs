using UnityEngine;

public class Tank : VehicleController //Inheritance
{
    protected override void Start() //Encapsulation and Polymorphism
    {
        base.Start();
        Speed = 20f;
        
    }

}

