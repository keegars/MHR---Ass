namespace MHR___Ass.Data.Skills.SkillList
{
    public class ChargeMaster : Skill
    {
        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
High chance of increased capture rewards. (No effect when joining mid-quest.)";

        public ChargeMaster(int value) : base(value)
        {
        }

        public ChargeMaster() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new ChargeMaster
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