using System;
using Il2CppDummyDll;
using UnityEngine.Events;

// Token: 0x0200089C RID: 2204
[Token(Token = "0x20005B3")]
public class BossMonsterStatus : EnemyMonsterStatus
{
	// Token: 0x1700080B RID: 2059
	// (get) Token: 0x060039F3 RID: 14835 RVA: 0x000140A0 File Offset: 0x000122A0
	// (set) Token: 0x060039F4 RID: 14836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000650")]
	public bool IsMadness
	{
		[Token(Token = "0x6003062")]
		[Address(RVA = "0x21894F0", Offset = "0x21895F1", VA = "0x21894F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5FF0", Offset = "0x1A60F1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003063")]
		[Address(RVA = "0x2189500", Offset = "0x2189601", VA = "0x2189500")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6000", Offset = "0x1A6101")]
		set
		{
		}
	}

	// Token: 0x060039F5 RID: 14837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003064")]
	[Address(RVA = "0x2189510", Offset = "0x2189611", VA = "0x2189510")]
	public void SetMadness(bool isEnable)
	{
	}

	// Token: 0x060039F6 RID: 14838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003065")]
	[Address(RVA = "0x2189520", Offset = "0x2189621", VA = "0x2189520")]
	public BossMonsterStatus(int level, MonsterControllerBase owner, MonsterDataID id)
	{
	}

	// Token: 0x1700080C RID: 2060
	// (get) Token: 0x060039F7 RID: 14839 RVA: 0x000140B8 File Offset: 0x000122B8
	[Token(Token = "0x17000651")]
	protected override float PoisonDamagePercent
	{
		[Token(Token = "0x6003066")]
		[Address(RVA = "0x2189650", Offset = "0x2189751", VA = "0x2189650", Slot = "16")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700080D RID: 2061
	// (get) Token: 0x060039F8 RID: 14840 RVA: 0x000140D0 File Offset: 0x000122D0
	[Token(Token = "0x17000652")]
	protected override bool IsBoss
	{
		[Token(Token = "0x6003067")]
		[Address(RVA = "0x2189660", Offset = "0x2189761", VA = "0x2189660", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700080E RID: 2062
	// (get) Token: 0x060039F9 RID: 14841 RVA: 0x000140E8 File Offset: 0x000122E8
	// (set) Token: 0x060039FA RID: 14842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000653")]
	public bool IsHyperArmor
	{
		[Token(Token = "0x6003068")]
		[Address(RVA = "0x2189670", Offset = "0x2189771", VA = "0x2189670")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003069")]
		[Address(RVA = "0x2189680", Offset = "0x2189781", VA = "0x2189680")]
		private set
		{
		}
	}

	// Token: 0x060039FB RID: 14843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600306A")]
	[Address(RVA = "0x2189710", Offset = "0x2189811", VA = "0x2189710")]
	protected void Start()
	{
	}

	// Token: 0x060039FC RID: 14844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600306B")]
	[Address(RVA = "0x21897A0", Offset = "0x21898A1", VA = "0x21897A0", Slot = "15")]
	public override void UpdateStatus()
	{
	}

	// Token: 0x060039FD RID: 14845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600306C")]
	[Address(RVA = "0x21897D0", Offset = "0x21898D1", VA = "0x21897D0")]
	private void UpdateHyperArmor()
	{
	}

	// Token: 0x060039FE RID: 14846 RVA: 0x00014100 File Offset: 0x00012300
	[Token(Token = "0x600306D")]
	[Address(RVA = "0x2189890", Offset = "0x2189991", VA = "0x2189890", Slot = "11")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x060039FF RID: 14847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600306E")]
	[Address(RVA = "0x2189A30", Offset = "0x2189B31", VA = "0x2189A30", Slot = "20")]
	protected override void LevelUp()
	{
	}

	// Token: 0x06003A00 RID: 14848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600306F")]
	[Address(RVA = "0x218A070", Offset = "0x218A171", VA = "0x218A070", Slot = "21")]
	protected override void LevelDown()
	{
	}

	// Token: 0x04007D73 RID: 32115
	[Token(Token = "0x4007165")]
	[FieldOffset(Offset = "0x240")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E430", Offset = "0x16E531")]
	private bool <IsMadness>k__BackingField;

	// Token: 0x04007D74 RID: 32116
	[Token(Token = "0x4007166")]
	[FieldOffset(Offset = "0x241")]
	public bool IsActiveHyperArmor;

	// Token: 0x04007D75 RID: 32117
	[Token(Token = "0x4007167")]
	[FieldOffset(Offset = "0x244")]
	private int HyperArmorAccumulatedValue;

	// Token: 0x04007D76 RID: 32118
	[Token(Token = "0x4007168")]
	[FieldOffset(Offset = "0x248")]
	private int MaxHyperArmorAccumulatedValue;

	// Token: 0x04007D77 RID: 32119
	[Token(Token = "0x4007169")]
	[FieldOffset(Offset = "0x24C")]
	private float HyperArmorValuePerTime;

	// Token: 0x04007D78 RID: 32120
	[Token(Token = "0x400716A")]
	[FieldOffset(Offset = "0x250")]
	private float HyperArmorTimer;

	// Token: 0x04007D79 RID: 32121
	[Token(Token = "0x400716B")]
	[FieldOffset(Offset = "0x254")]
	private bool _IsHyperArmor;

	// Token: 0x04007D7A RID: 32122
	[Token(Token = "0x400716C")]
	[FieldOffset(Offset = "0x258")]
	public BossMonsterStatus.HyperArmorEvent OnChangeHyperArmor;

	// Token: 0x0200089D RID: 2205
	[Token(Token = "0x200126C")]
	public class HyperArmorEvent : UnityEvent<bool>
	{
		// Token: 0x06003A01 RID: 14849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007478")]
		[Address(RVA = "0x2189600", Offset = "0x2189701", VA = "0x2189600")]
		public HyperArmorEvent()
		{
		}
	}
}
