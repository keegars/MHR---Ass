
namespace MHR___Ass.Data.Skills.SkillList
{
    public class GuardUp : Skill
    {
        public GuardUp(int value) : base(value)
        {
        }

        public GuardUp() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new GuardUp
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
Allows you to guard against ordinarily unblockable attacks.
1: Reduces damage taken by 30%.
2: Reduces damage taken by 50%.
3: Reduces damage taken by 80%.";
    }
 }
            