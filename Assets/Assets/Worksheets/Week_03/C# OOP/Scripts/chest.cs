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
