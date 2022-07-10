using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class FeatherofMastery : ArmorSet
    {
        public FeatherofMastery()
        {
            Name = "Feather of Mastery";

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
                .AddSkill(new CarvingMaster(1));
        }
    }
}