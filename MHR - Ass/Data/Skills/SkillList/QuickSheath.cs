
namespace MHR___Ass.Data.Skills.SkillList
{
    public class QuickSheath : Skill
    {
        public QuickSheath(int value) : base(value)
        {
        }

        public QuickSheath() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new QuickSheath
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Speeds up weapon sheathing.
1: Slightly increases sheathing speed.
2: Moderately increases sheathing speed.
3: Greatly increases sheathing speed.";
    }
 }
            