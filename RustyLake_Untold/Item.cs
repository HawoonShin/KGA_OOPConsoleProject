using RustyLake_Untold.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold
{
    
   public  class Item
    {
        //public List<Item> inventory = new List<Item>();
        public string name { get; set; }
        public string description { get; set; }
        public int id { get; set; }

        public Item(Scene scene)
        {
            //this.game = scene.game;
            //this.scene = scene;

        }
    }
}
