namespace MHR___Ass.Data.Skills.SkillList
{
    public class ThunderAttack : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Increases thunder element attack power. (Elemental attack power has a maximum limit.)
1: Thunder attack +2
2: Thunder attack +3
3: Thunder attack +5% Bonus: +4
4: Thunder attack +10% Bonus: +4
5: Thunder attack +20% Bonus: +4";

        public ThunderAttack(int value) : base(value)
        {
        }

        public ThunderAttack() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new ThunderAttack
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }
    }
}