namespace MHR___Ass.Data.Skills.SkillList
{
    public class Resuscitate : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases attack power when you are suffering from an abnormal status.
1: Attack +5 while active.
2: Attack +10 while active.
3: Attack +20 while active.";

        public Resuscitate(int value) : base(value)
        {
        }

        public Resuscitate() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Resuscitate
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