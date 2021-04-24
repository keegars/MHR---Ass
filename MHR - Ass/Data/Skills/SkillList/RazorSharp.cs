
namespace MHR___Ass.Data.Skills.SkillList
{
    public class RazorSharp : Skill
    {
        public RazorSharp(int value) : base(value)
        {
        }

        public RazorSharp() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new RazorSharp
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
Prevents your weapon from losing sharpness.
1: Activates 10% of the time.
2: Activates 25% of the time.
3: Activates 50% of the time.";
    }
 }
            