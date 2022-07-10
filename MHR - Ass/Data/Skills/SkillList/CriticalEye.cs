namespace MHR___Ass.Data.Skills.SkillList
{
    public class CriticalEye : Skill
    {
        public override int MaxValue { get; set; } = 7;
        public override string Description { get; set; } = @"
Increases affinity.
1: Affinity +5%
2: Affinity +10%
3: Affinity +15%
4: Affinity +20%
5: Affinity +25%
6: Affinity +30%
7: Affinity +40%";

        public CriticalEye(int value) : base(value)
        {
        }

        public CriticalEye() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new CriticalEye
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