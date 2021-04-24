using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Remobra : ArmorSet
    {
        public Remobra()
        {
            Name = "Remobra";

            //Base values
            BaseDefense = 18;
            Fire.Value = 1;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Windproof(2));

            Torso = new TorsoArmor(this)
                .AddSkill(new ItemProlonger(1));

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalElement(1))
                .AddSkill(new Windproof(1));

            Waist = new WaistArmor(this)
                .AddSkill(new CriticalElement(1));

            Leg = new LegArmor(this)
                .AddSkill(new DivineBlessing(1));
        }
    }
}