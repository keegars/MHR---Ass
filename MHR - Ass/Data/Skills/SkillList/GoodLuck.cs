namespace MHR___Ass.Data.Skills.SkillList
{
    public class GoodLuck : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Good chance of increased quest rewards. (No effect when joining mid-quest.)
1: Slightly increases luck.
2: Increases luck.
3: Greatly increases luck.";

        public GoodLuck(int value) : base(value)
        {
        }

        public GoodLuck() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new GoodLuck
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