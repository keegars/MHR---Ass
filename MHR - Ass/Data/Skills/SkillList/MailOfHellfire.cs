namespace MHR___Ass.Data.Skills.SkillList
{
    public class MailOfHellfire : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Decreases defense but increases attack. Exact changes to stats depends on Switch Skill Swap Scroll that is being used.";

        public MailOfHellfire(int value) : base(value)
        {
        }

        public MailOfHellfire() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new MailOfHellfire
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