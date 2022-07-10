using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Orangaten : ArmorSet
    {
        public Orangaten()
        {
            Name = "Orangaten";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 104;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new BlastAttack(1))
                .AddSkill(new LatentPower(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSkill(new FireResistance(1))
                .AddSkill(new RecoverySpeed(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new LatentPower(3))
                .AddSkill(new QuickSheath(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new BlastAttack(2))
                .AddSkill(new Handicraft(2))
                .AddSkill(new SpreadUp(2))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSkill(new ProtectivePolish(1))
                .AddSkill(new SpreadUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}