
namespace MHR___Ass.Data.Skills.SkillList
{
    public class Mushroomancer : Skill
    {
        public Mushroomancer(int value) : base(value)
        {
        }

        public Mushroomancer() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Mushroomancer
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
Lets you digest mushrooms that would otherwise be inedible and gain their advantageous effects.
1: Lets you digest blue mushrooms and toadstools.
2: Additionally lets you digest nitroshrooms and parashrooms.
3: Additionally lets you digest mandragoras and exciteshrooms.";
    }
 }
            