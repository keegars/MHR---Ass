namespace MHR___Ass.Data.Skills.SkillList
{
    public class CarvingPro : Skill
    {
        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Prevents knockback from attacks while carving.
1: Activates skill effect.";

        public CarvingPro(int value) : base(value)
        {
        }

        public CarvingPro() : base()
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