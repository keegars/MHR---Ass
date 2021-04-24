
namespace MHR___Ass.Data.Skills.SkillList
{
    public class Artillery : Skill
    {
        public Artillery(int value) : base(value)
        {
        }

        public Artillery() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Artillery
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
Strengthens explosive attacks like shells, Wyvern's Fire, charge blade phial attacks, and Sticky Ammo.
1: Increases power of each attack by 10% and reduces Wyvern's Fire cooldown by 15%.
2: Increases power of each attack by 20% and reduces Wyvern's Fire cooldown by 30%.
3: Increases power of each attack by 30% and reduces Wyvern's Fire cooldown by 50%.";
    }
 }
            