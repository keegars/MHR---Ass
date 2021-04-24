
namespace MHR___Ass.Data.Skills.SkillList
{
    public class Slugger : Skill
    {
        public Slugger(int value) : base(value)
        {
        }

        public Slugger() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Slugger
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
Makes it easier to stun monsters.
1: Stun power +20%
2: Stun power +30%
3: Stun power +40%";
    }
 }
            