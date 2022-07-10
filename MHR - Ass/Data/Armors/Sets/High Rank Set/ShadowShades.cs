using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class ShadowShades : ArmorSet
    {
        public ShadowShades()
        {
            Name = "Shadow Shades";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 76;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new StunResistance(1))
                .AddSkill(new GoodLuck(1));
        }
    }
}