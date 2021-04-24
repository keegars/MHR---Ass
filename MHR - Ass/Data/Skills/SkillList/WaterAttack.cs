namespace MHR___Ass.Data.Skills.SkillList
{
    public class WaterAttack : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Increases water element attack power. (Elemental attack power has a maximum limit.)
1: Water attack +2
2: Water attack +3
3: Water attack +5% Bonus: +4
4: Water attack +10% Bonus: +4
5: Water attack +20% Bonus: +4";

        public WaterAttack(int value) : base(value)
        {
        }

        public WaterAttack() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new WaterAttack
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