using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Droth : ArmorSet
    {
        public Droth()
        {
            Name = "Droth";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 66;
            Fire.Value = -2;
            Water.Value = 4;
            Ice.Value = 0;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Torso = new TorsoArmor(this)
                .AddSkill(new WaterResistance(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Diversion(1));

            Leg = new LegArmor(this)
                .AddSkill(new WaterResistance(2));
        }
    }
}