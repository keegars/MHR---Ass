
namespace MHR___Ass.Data.Skills.SkillList
{
    public class CriticalElement : Skill
    {
        public CriticalElement(int value) : base(value)
        {
        }

        public CriticalElement() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new CriticalElement
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
Increases elemental damage (fire, water, thunder, ice, dragon) when landing critical hits.
1: Grants elemental damage +5% while active.
2: Grants elemental damage +10% while active.
3: Grants elemental damage +15% while active.";
    }
 }
            