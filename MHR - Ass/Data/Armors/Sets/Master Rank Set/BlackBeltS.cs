using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BlackBeltS : ArmorSet
    {
        public BlackBeltS()
        {
            Name = "Black Belt S";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 86;
            Fire.Value = 1;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Earplugs(1))
                .AddSkill(new RecoveryUp(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Earplugs(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new RecoveryUp(1))
                .AddSkill(new Constitution(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Earplugs(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new FlinchFree(1))
                .AddSkill(new RecoveryUp(1));
        }
    }
}