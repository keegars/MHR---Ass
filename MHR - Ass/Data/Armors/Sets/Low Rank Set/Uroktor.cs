using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Uroktor : ArmorSet
    {
        public Uroktor()
        {
            Name = "Uroktor";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 68;
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