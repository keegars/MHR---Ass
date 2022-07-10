using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class SkullX : ArmorSet
    {
        public SkullX()
        {
            Name = "Skull X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 112;
            Fire.Value = -3;
            Water.Value = -3;
            Ice.Value = -3;
            Thunder.Value = -3;
            Dragon.Value = 4;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Fortify(1))
                .AddSkill(new Handicraft(1))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}