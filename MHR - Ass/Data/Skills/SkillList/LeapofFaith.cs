
namespace MHR___Ass.Data.Skills.SkillList
{
    public class LeapofFaith : Skill
    {
        public LeapofFaith(int value) : base(value)
        {
        }

        public LeapofFaith() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new LeapofFaith
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Allows you to do a dive-evade when facing towards large monsters, and extends the dive-evade distance.
1: Enables skill use.";
    }
 }
            