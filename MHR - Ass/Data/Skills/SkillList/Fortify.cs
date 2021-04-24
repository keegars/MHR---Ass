namespace MHR___Ass.Data.Skills.SkillList
{
    public class Fortify : Skill
    {
        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Increases your attack and defense when you fall in battle. (Disabled for some quests. Can stack twice.)
1: Increases attack by 10% and defense by 15% with each use.";

        public Fortify(int value) : base(value)
        {
        }

        public Fortify() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Fortify
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