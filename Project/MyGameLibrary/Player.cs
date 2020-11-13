using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
    public int Experience;
    public int RequiredLevelExperience;
    public List<Item> items = new List<Item>();
    public Item equippedWep = null;
    public Item equippedArmor = null;
    public int armor = 0;

    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
      Experience = 0;
      RequiredLevelExperience = 50;
      items.Add(new Item("Health Potion", "Util", 2));
      items.Add(new Item("Health Potion", "Util", 2));
    }

    public void AlterExperience(int amount) {
      Experience += amount;
      items.Add(new Item("Health Potion", "Util", 2));
    }

    public void ScaleLevelExperience(int amount) {
     RequiredLevelExperience += amount;
    }

    public void HealPlayerWithItem() {
      // If the player is NOT at max health, heal
      if (!(Health == MaxHealth))
      {
        // Check the user's inventory for a healing item, starting at index 0 of our inventory list
        foreach (Item item in items)
        {
          // Use the first one found and remove it from the player's inventory; break out of the loop
          if (item.Type == "Util")
          {
            AlterHealth(item.Value);
            items.Remove(item);
          }
          break;
        }
      }
        
    }
  }
}
