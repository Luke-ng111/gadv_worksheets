using System;
using UnityEngine;

public class chest : MonoBehaviour
{
    public class TreasureChest
    {
        public virtual void Unlock()
        {
            Console.WriteLine("You try to unlock the chest...");
        }

        public virtual void Unlock(bool hasToken)
        {
            if (hasToken)
            {
                Console.WriteLine("You unlock the chest with a key and a special token — bonus treasure inside!");
            }
            else
            {
                Unlock(); // Call the base Unlock method
            }
        }

        public void Shake()
        {
            Console.WriteLine("You hear something rattle inside the chest.");
        }
    }

    public class AncientChest : TreasureChest
    {
        public override void Unlock()
        {
            Console.WriteLine("You unlock the ancient chest with an ancient key.");
        }

        public override void Unlock(bool hasToken)
        {
            if (hasToken)
            {
                Console.WriteLine("You unlock the ancient chest with an ancient key and a sacred token — rare artifact discovered!");
            }
            else
            {
                Unlock();
            }
        }
    }

    public class MagicChest : TreasureChest
    {
        public override void Unlock()
        {
            Console.WriteLine("You cast a spell to unlock the magic chest.");
        }


    }

    class Program
    {
        static void Main()
        {
            TreasureChest chest1 = new AncientChest();
            TreasureChest chest2 = new MagicChest();

            chest1.Unlock();
            chest1.Shake();

            chest2.Unlock();
            chest2.Shake();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
