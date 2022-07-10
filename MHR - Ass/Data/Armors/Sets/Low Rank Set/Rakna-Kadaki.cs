using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RaknaKadaki : ArmorSet
    {
        public RaknaKadaki()
        {
            Name = "Rakna-Kadaki";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 86;
            Fire.Value = 4;
            Water.Value = -2;
            Ice.Value = -3;
            Thunder.Value = -1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SpreadUp(1))
                .AddSkill(new ReloadSpeed(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new SpreadUp(1))
                .AddSkill(new ReloadSpeed(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Constitution(2))
                .AddSkill(new StaminaSurge(2))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SpreadUp(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Constitution(2))
                .AddSkill(new StaminaSurge(2))
                .AddSlot(new SmallSlot());
        }
    }
}