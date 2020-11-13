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
    }

    public void AlterExperience(int amount) {
      Experience += amount;
      items.Add(new Item("Iron Sword", "weapon", 1)); // toy example to test it out
      items.Add(new Item("Iron Armor", "armor", 1)); // toy example to test it out
    }

    public void ScaleLevelExperience(int amount) {
     RequiredLevelExperience += amount;
    }
  }
}
