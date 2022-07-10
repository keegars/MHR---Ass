using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class DeathStench : ArmorSet
    {
        public DeathStench()
        {
            Name = "Death Stench";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 68;
            Fire.Value = 3;
            Water.Value = 1;
            Ice.Value = -1;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new DragonResistance(2));

            Torso = new TorsoArmor(this)
                .AddSkill(new RapidMorph(1));

            Arm = new ArmArmor(this)
                .AddSkill(new MaximumMight(1));

            Waist = new WaistArmor(this)
                .AddSkill(new DragonResistance(1));

            Leg = new LegArmor(this)
                .AddSkill(new RapidMorph(1));
        }
    }
}