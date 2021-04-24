using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Jelly : ArmorSet
    {
        public Jelly()
        {
            Name = "Jelly";

            //Base values
            BaseDefense = 24;
            Fire.Value = 1;
            Water.Value = 3;
            Ice.Value = 2;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new DivineBlessing(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new BlastAttack(1));

            Arm = new ArmArmor(this)
                .AddSkill(new DivineBlessing(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Partbreaker(1));

            Leg = new LegArmor(this)
                .AddSkill(new BlastAttack(1));
        }
    }
}