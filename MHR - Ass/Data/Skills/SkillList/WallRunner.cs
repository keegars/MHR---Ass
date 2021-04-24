namespace MHR___Ass.Data.Skills.SkillList
{
    public class WallRunner : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Reduces stamina consumption when running on walls.
1: Reduces stamina consumption by 25% while wall running.
2: Reduces stamina consumption by 50% while wall running.
3: Wall running temporarily increases attack power.";

        public WallRunner(int value) : base(value)
        {
        }

        public WallRunner() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new WallRunner
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