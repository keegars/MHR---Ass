
namespace MHR___Ass.Data.Skills.SkillList
{
    public class IceResistance : Skill
    {
        public IceResistance(int value) : base(value)
        {
        }

        public IceResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new IceResistance
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
Increases ice resistance. Also improves defense at higher levels.
1: Ice resistance +6
2: Ice resistance +12
3: Ice resistance +20 Defense +10";
    }
 }
            