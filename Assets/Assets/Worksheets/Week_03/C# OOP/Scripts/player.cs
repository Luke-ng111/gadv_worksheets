using UnityEngine;

public class player : MonoBehaviour
{
    public class Player
    {
        private int health = 1000;

        

        public int GetHealth(int amount)
        {
            return health;
        }
        public void TakeDamage(int amount)
        {
            Debug.Log("damage taken");
            health -= amount;
            
        }
    }
}
