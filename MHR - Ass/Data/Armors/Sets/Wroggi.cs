using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Wroggi : ArmorSet
    {
        public Wroggi()
        {
            Name = "Wroggi";
            

            //Base values
            BaseDefense = 16;
            Fire.Value = 2;
            Water.Value = -2;
            Ice.Value = -4;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new EvadeExtender(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new PoisonAttack(1));

            Arm = new ArmArmor(this)
                .AddSkill(new AmmoUp(1));

            Waist = new WaistArmor(this)
                .AddSkill(new PoisonAttack(1));

            Leg = new LegArmor(this)
                .AddSkill(new EvadeExtender(1));
        }
    }
}