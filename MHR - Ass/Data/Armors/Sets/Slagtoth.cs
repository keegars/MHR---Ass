using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Slagtoth : ArmorSet
    {
        public Slagtoth()
        {
            Name = "Slagtoth";

            //Base values
            BaseDefense = 14;
            Fire.Value = -2;
            Water.Value = 2;
            Ice.Value = -1;
            Thunder.Value = 0;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new FreeMeal(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new FreeMeal(1));
        }
    }
}