namespace MHR___Ass.Data.Skills.SkillList
{
    public class CarvingMaster : Skill
    {
        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Let's you carve one additional time. (No effect when joining mid-quest.)";

        public CarvingMaster(int value) : base(value)
        {
        }

        public CarvingMaster() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new CarvingPro
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