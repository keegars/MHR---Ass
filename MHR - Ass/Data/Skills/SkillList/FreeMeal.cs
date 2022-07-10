namespace MHR___Ass.Data.Skills.SkillList
{
    public class FreeMeal : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Gives you a predetermined chance of consuming a food or drink item for free.
1: Activates 10% of the time.
2: Activates 25% of the time.
3: Activates 45% of the time.";

        public FreeMeal(int value) : base(value)
        {
        }

        public FreeMeal() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new FreeMeal
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