using Humanizer;
using MHR___Ass.Data.Decorations;

namespace MHR___Ass.Data.Skills
{
    public abstract class Skill
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public abstract int MaxValue { get; set; }
        public abstract string Description { get; set; }

        public Skill()
        {
            Name = GetType().Name.Humanize(LetterCasing.Title);
            Value = 0;
        }

        public Skill(int value)
        {
            Name = GetType().Name.Humanize(LetterCasing.Title);
            Value = value < 0 ? 0 : value > MaxValue ? MaxValue : value;
        }

        public abstract Skill Clone(int value);
    }

    public class SkillDecoCombo
    {
        public Skill Skill { get; set; }
        public Decoration Decoration { get; set; }
    }
}