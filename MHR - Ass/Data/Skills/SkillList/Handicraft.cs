
namespace MHR___Ass.Data.Skills.SkillList
{
    public class Handicraft : Skill
    {
        public Handicraft(int value) : base(value)
        {
        }

        public Handicraft() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Handicraft
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Extends the weapon sharpness gauge. However, it will not increase the gauge past its maximum.
1: Weapon sharpness +10
2: Weapon sharpness +20
3: Weapon sharpness +30
4: Weapon sharpness +40
5: Weapon sharpness +50";
    }
 }
            