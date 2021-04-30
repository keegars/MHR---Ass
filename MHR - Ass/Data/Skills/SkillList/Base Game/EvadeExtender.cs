namespace MHR___Ass.Data.Skills.SkillList
{
    public class EvadeExtender : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases evade distance.
1: Slightly extends evasion distance.
2: Extends evasion distance.
3: Greatly extends evasion distance.";

        public EvadeExtender(int value) : base(value)
        {
        }

        public EvadeExtender() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new EvadeExtender
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