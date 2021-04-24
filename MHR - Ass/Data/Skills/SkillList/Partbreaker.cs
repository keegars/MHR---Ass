
namespace MHR___Ass.Data.Skills.SkillList
{
    public class Partbreaker : Skill
    {
        public Partbreaker(int value) : base(value)
        {
        }

        public Partbreaker() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Partbreaker
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
Makes it easier to break or sever parts of large monsters.
1: Part damage +10%
2: Part damage +20%
3: Part damage +30%";
    }
 }
            