namespace MHR___Ass.Data.Skills.SkillList
{
    public class PoisonAttack : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases poison element attack power. (Elemental attack power has a maximum limit.)
1: Poison buildup +5% Bonus: +1
2: Poison buildup +10% Bonus: +2
3: Poison buildup +20% Bonus: +5";

        public PoisonAttack(int value) : base(value)
        {
        }

        public PoisonAttack() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new PoisonAttack
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