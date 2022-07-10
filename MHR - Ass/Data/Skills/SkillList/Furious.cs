namespace MHR___Ass.Data.Skills.SkillList
{
    public class Furious : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Using the Red Scroll builds your fury while fighting monsters. Swapping to the Blue Scroll when your fury is full gives you infinite stamina temporarily.";

        public Furious(int value) : base(value)
        {
        }

        public Furious() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Furious
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