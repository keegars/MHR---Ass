namespace MHR___Ass.Data.Skills.SkillList
{
    public class Geologist : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases the number of times you can use a gathering point.
1: Allows you to gather one extra time from bonepiles.
2: Allows you to gather one extra time from gathering points.
3: Allows you to gather one extra time from mining outcrops.";

        public Geologist(int value) : base(value)
        {
        }

        public Geologist() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Geologist
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