namespace MHR___Ass.Data.Skills.SkillList
{
    public class Stormsoul : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Strengthens thunder and dragon power and improves skills of the same elements.

Lv 1 Thunder and dragon attack +5%
Lv 2 Thunder and dragon attack +10%
Lv 3 Thunder and dragon attack +15%
Lv 4 Also increases level of other skills by +1.
Lv 5 Also increases level of other skills by +1 (stacks with previous bonus).";

        public Stormsoul(int value) : base(value)
        {
        }

        public Stormsoul() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Stormsoul
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