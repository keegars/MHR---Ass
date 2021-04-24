
namespace MHR___Ass.Data.Skills.SkillList
{
    public class SpreadUp : Skill
    {
        public SpreadUp(int value) : base(value)
        {
        }

        public SpreadUp() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new SpreadUp
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases the attack power of Spread Ammo and Spread- type arrows
1: Slightly increases the power of Spread Ammo, Shrapnel Ammo, and Spread-type arrows.
2: Increases the power of Spread Ammo, Shrapnel Ammo, and Spread-type arrows.
3: Greatly increases the power of Spread Ammo, Shrapnel Ammo, and Spread-type arrows.";
    }
 }
            