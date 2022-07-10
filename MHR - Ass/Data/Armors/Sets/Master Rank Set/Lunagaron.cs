using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Lunagaron : ArmorSet
    {
        public Lunagaron()
        {
            Name = "Lunagaron";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 130;
            Fire.Value = -4;
            Water.Value = 2;
            Ice.Value = 4;
            Thunder.Value = -1;
            Dragon.Value = -1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSkill(new WirebugWhisperer(2))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Agitator(2))
                .AddSkill(new Redirection(2))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Agitator(3))
                .AddSkill(new WirebugWhisperer(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new LatentPower(2))
                .AddSkill(new WirebugWhisperer(2))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new LatentPower(3))
                .AddSkill(new Redirection(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}