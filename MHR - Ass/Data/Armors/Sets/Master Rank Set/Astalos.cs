using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Astalos : ArmorSet
    {
        public Astalos()
        {
            Name = "Astalos";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 130;
            Fire.Value = 0;
            Water.Value = -2;
            Ice.Value = -2;
            Thunder.Value = 3;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ChainCrit(1))
                .AddSkill(new StunResistance(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new ChainCrit(1))
                .AddSkill(new StaminaSurge(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ChainCrit(1))
                .AddSkill(new StaminaSurge(1))
                .AddSkill(new StunResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new PowerProlonger(3))
                .AddSkill(new SpeedSharpening(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new RazorSharp(3))
                .AddSkill(new SpareShot(3))
                .AddSkill(new ThunderAttack(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}