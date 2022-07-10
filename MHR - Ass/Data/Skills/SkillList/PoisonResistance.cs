namespace MHR___Ass.Data.Skills.SkillList
{
    public class PoisonResistance : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Reduces damage while poisoned.
1: Reduces the number of times you take poison damage.
2: Greatly reduces the number of times you take poison damage.
3: Prevents poison and reduces venom.";

        public PoisonResistance(int value) : base(value)
        {
        }

        public PoisonResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new PoisonResistance
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