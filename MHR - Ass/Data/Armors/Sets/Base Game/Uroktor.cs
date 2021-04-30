using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Uroktor : ArmorSet
    {
        public Uroktor()
        {
            Name = "Uroktor";

            //Base values
            BaseDefense = 18;
            Fire.Value = 4;
            Water.Value = -2;
            Ice.Value = -1;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Torso = new TorsoArmor(this)
                .AddSkill(new FireResistance(2));

            Waist = new WaistArmor(this)
                .AddSkill(new FireResistance(1));
        }
    }
}