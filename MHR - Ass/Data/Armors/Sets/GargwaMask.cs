using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GargwaMask : ArmorSet
    {
        public GargwaMask()
        {
            Name = "Gargwa Mask";
            

            //Base values
            BaseDefense = 14;
            Fire.Value = -3;
            Water.Value = -2;
            Ice.Value = 1;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new LeapofFaith(1));
        }
    }
}