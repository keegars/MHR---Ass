
namespace MHR___Ass.Data.Skills.SkillList
{
    public class MasterMounter : Skill
    {
        public MasterMounter(int value) : base(value)
        {
        }

        public MasterMounter() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new MasterMounter
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
Improves your Wyvern Riding skills.
1: Makes filling the Riding Gauge easier and increases ease of parrying.";
    }
 }
            