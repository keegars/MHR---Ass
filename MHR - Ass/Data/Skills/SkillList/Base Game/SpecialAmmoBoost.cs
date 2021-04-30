namespace MHR___Ass.Data.Skills.SkillList
{
    public class SpecialAmmoBoost : Skill
    {
        public override int MaxValue { get; set; } = 2;
        public override string Description { get; set; } = @"
Increases the power of bowgun special ammo and Dragon Piercer.
1: Increases power of bowgun special ammo and Dragon Piercer by 10%.
2: Increases power of bowgun special ammo and Dragon Piercer by 20%.";

        public SpecialAmmoBoost(int value) : base(value)
        {
        }

        public SpecialAmmoBoost() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new SpecialAmmoBoost
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }
    }
}