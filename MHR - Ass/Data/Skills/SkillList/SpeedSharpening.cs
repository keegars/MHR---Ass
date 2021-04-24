namespace MHR___Ass.Data.Skills.SkillList
{
    public class SpeedSharpening : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Speeds up weapon sharpening when using a whetstone.
1: Removes one cycle from the sharpening process.
2: Removes two cycles from the sharpening process.
3: Removes three cycles from the sharpening process.";

        public SpeedSharpening(int value) : base(value)
        {
        }

        public SpeedSharpening() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new SpeedSharpening
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