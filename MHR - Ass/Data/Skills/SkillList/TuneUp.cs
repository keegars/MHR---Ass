namespace MHR___Ass.Data.Skills.SkillList
{
    public class TuneUp : Skill
    {
        public override int MaxValue { get; set; } = 2;
        public override string Description { get; set; } = @"
Increases the stats of custom mods attached to bowguns.";

        public TuneUp(int value) : base(value)
        {
        }

        public TuneUp() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new TuneUp
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