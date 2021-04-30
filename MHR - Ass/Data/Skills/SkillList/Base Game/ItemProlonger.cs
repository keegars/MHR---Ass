namespace MHR___Ass.Data.Skills.SkillList
{
    public class ItemProlonger : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Extends the duration of some item effects.
1: Item effect duration +10%
2: Item effect duration +25%
3: Item effect duration +50%";

        public ItemProlonger(int value) : base(value)
        {
        }

        public ItemProlonger() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new ItemProlonger
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