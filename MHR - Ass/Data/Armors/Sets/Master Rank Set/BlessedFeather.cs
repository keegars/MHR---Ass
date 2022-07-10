using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BlessedFeather : ArmorSet
    {
        public BlessedFeather()
        {
            Name = "Blessed Feather";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 134;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new GoodLuck(3))
                .AddSlot(new MediumSlot());
        }
    }
}