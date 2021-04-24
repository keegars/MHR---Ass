
namespace MHR___Ass.Data.Skills.SkillList
{
    public class Resentment : Skill
    {
        public Resentment(int value) : base(value)
        {
        }

        public Resentment() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Resentment
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
Increases attack when you have recoverable damage (the red portion of your health gauge).
1: Attack +5 while active.
2: Attack +10 while active.
3: Attack +15 while active.
4: Attack +20 while active.
5: Attack +25 while active.";
    }
 }
            