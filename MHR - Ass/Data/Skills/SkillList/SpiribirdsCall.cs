namespace MHR___Ass.Data.Skills.SkillList
{
    public class SpiribirdsCall : Skill
    {
        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Receive the effects of a random Spiribird at fixed intervals. (Certain quests only)";

        public SpiribirdsCall(int value) : base(value)
        {
        }

        public SpiribirdsCall() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new SpiribirdsCall
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