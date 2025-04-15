using UnityEngine;

public class VehicleInputManager : MonoBehaviour
{
    public VehicleController convertible;
    public VehicleController tank;
    public VehicleController bus;

    private VehicleController currentVehicle;

    void Start()
    {
        currentVehicle = convertible; // default starting vehicle
    }

    void Update()
    {
        // Switch vehicles
        if (Input.GetKeyDown(KeyCode.Z)) currentVehicle = convertible;
        if (Input.GetKeyDown(KeyCode.X)) currentVehicle = tank;
        if (Input.GetKeyDown(KeyCode.C)) currentVehicle = bus;

        // Movement
        currentVehicle?.Move(); //Abstraction

        // Honk
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentVehicle?.Honk(); //Abstraction
        }
    }
}

