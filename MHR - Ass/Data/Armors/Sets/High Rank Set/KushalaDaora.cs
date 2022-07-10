using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class KushalaDaora : ArmorSet
    {
        public KushalaDaora()
        {
            Name = "Kushala Daora";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 94;
            Fire.Value = -1;
            Water.Value = 2;
            Ice.Value = 3;
            Thunder.Value = -2;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Handicraft(2))
                .AddSkill(new NormalRapidUp(2))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new KushalaBlessing(1))
                .AddSkill(new RecoverySpeed(1))
                .AddSkill(new Diversion(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new KushalaBlessing(1))
                .AddSkill(new RecoverySpeed(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new KushalaBlessing(1))
                .AddSkill(new RecoverySpeed(1))
                .AddSkill(new Handicraft(1))
                .AddSkill(new PierceUp(1))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new KushalaBlessing(1))
                .AddSkill(new Handicraft(1))
                .AddSkill(new PierceUp(1))
                .AddSlot(new SmallSlot());
        }
    }
}