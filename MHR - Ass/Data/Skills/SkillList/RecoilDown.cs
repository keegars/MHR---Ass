
namespace MHR___Ass.Data.Skills.SkillList
{
    public class RecoilDown : Skill
    {
        public RecoilDown(int value) : base(value)
        {
        }

        public RecoilDown() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new RecoilDown
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
Reduces recoil when firing bowgun ammo.
1: Recoil -1
2: Recoil -2
3: Recoil -3";
    }
 }
            