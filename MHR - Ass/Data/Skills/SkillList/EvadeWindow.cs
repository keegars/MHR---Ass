
namespace MHR___Ass.Data.Skills.SkillList
{
    public class EvadeWindow : Skill
    {
        public EvadeWindow(int value) : base(value)
        {
        }

        public EvadeWindow() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new EvadeWindow
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
Extends the invulnerability period when evading.
1: Very slightly increases invulnerability window.
2: Slightly increases invulnerability window.
3: Increases invulnerability window.
4: Greatly increases invulnerability window.
5: Massively increases invulnerability window.";
    }
 }
            