using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class JaggiMask : ArmorSet
    {
        public JaggiMask()
        {
            Name = "Jaggi Mask";
            

            //Base values
            BaseDefense = 14;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AffinitySliding(1));
        }
    }
}