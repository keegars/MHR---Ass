namespace MHR___Ass.Data.Skills.SkillList
{
    public class BlastAttack : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases blast element attack power. (Elemental attack power has a maximum limit.)
1: Blast buildup +5% Bonus: +1
2: Blast buildup +10% Bonus: +2
3: Blast buildup +20% Bonus: +5";

        public BlastAttack(int value) : base(value)
        {
        }

        public BlastAttack() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new BlastAttack
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