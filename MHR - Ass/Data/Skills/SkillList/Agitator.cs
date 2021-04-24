namespace MHR___Ass.Data.Skills.SkillList
{
    public class Agitator : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Increases attack power and affinity when large monsters become enraged.
1: Attack +4 and affinity +3% while active.
2: Attack +8 and affinity +5% while active.
3: Attack +12 and affinity +7% while active.
4: Attack +16 and affinity +10% while active.
5: Attack +20 and affinity +15% while active.";

        public Agitator(int value) : base(value)
        {
        }

        public Agitator() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Agitator
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