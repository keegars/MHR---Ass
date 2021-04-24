namespace MHR___Ass.Data.Skills.SkillList
{
    public class Botanist : Skill
    {
        public override int MaxValue { get; set; } = 4;
        public override string Description { get; set; } = @"
Increases the quantity of herbs and other consumable items you gather.
1: One extra consumable herb item per gather.
2: One extra consumable herb, fruit, nut, or seed item per gather.
3: One extra consumable herb, fruit, nut, seed, or insect item per gather.
4: One extra consumable herb, fruit, nut, seed, insect, or mushroom item per gather.";

        public Botanist(int value) : base(value)
        {
        }

        public Botanist() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Botanist
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