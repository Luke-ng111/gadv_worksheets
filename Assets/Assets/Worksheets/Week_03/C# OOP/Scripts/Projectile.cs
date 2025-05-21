using UnityEngine;
using UnityEngine.Rendering;

public class Projectile
{
    private float speed;

    public Projectile(float initialspeed) { speed = initialspeed; }
    public void fire()
    {
        if (speed > 0)
        {
            Debug.Log("firing projectile at speed: " + speed);
        }

        else
        {
            Debug.Log("Cannot fire: speed too low");
            autofire();
        }
    }

    public void autofire()
    {
        speed = 100;
        Debug.Log("Speed was zero. AutoFire set speed to 100 and launched!");
    }

}
