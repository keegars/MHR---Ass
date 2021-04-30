using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Kushala : ArmorSet
    {
        public Kushala()
        {
            Name = "Kushala";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 74;
            Fire.Value = -1;
            Water.Value = 2;
            Ice.Value = 3;
            Thunder.Value = -2;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSlot(new SmallSlot())
                .AddSkill(new Handicraft(2))
                .AddSkill(new NormalRapidUp(2));

            Torso = new TorsoArmor(this)
               .AddSlot(new MediumSlot())
               .AddSkill(new KushalaBlessing(1))
               .AddSkill(new RecoverySpeed(1))
               .AddSkill(new Diversion(1));

            Arm = new ArmArmor(this)
               .AddSlot(new SmallSlot())
               .AddSkill(new KushalaBlessing(1))
               .AddSkill(new RecoverySpeed(1))
               .AddSkill(new Agitator(2));

            Waist = new WaistArmor(this)
               .AddSlot(new SmallSlot())
               .AddSkill(new KushalaBlessing(1))
               .AddSkill(new RecoverySpeed(1))
               .AddSkill(new Handicraft(1))
               .AddSkill(new PierceUp(1));

            Leg = new LegArmor(this)
               .AddSlot(new SmallSlot())
               .AddSkill(new KushalaBlessing(1))
               .AddSkill(new Handicraft(1))
               .AddSkill(new PierceUp(1));
        }
    }
}