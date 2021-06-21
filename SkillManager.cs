using System;
using Define;
using Il2CppDummyDll;

// Token: 0x0200089B RID: 2203
[Token(Token = "0x20005B2")]
public class SkillManager : SingletonMonoBehaviour<SkillManager>
{
	// Token: 0x1700080A RID: 2058
	// (get) Token: 0x060039E5 RID: 14821 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039E6 RID: 14822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700064F")]
	private SkillLevelUpEffectController EffectController
	{
		[Token(Token = "0x6003054")]
		[Address(RVA = "0x1DE85E0", Offset = "0x1DE86E1", VA = "0x1DE85E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5FD0", Offset = "0x1A60D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003055")]
		[Address(RVA = "0x1DE85F0", Offset = "0x1DE86F1", VA = "0x1DE85F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5FE0", Offset = "0x1A60E1")]
		set
		{
		}
	}

	// Token: 0x060039E7 RID: 14823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003056")]
	[Address(RVA = "0x1DE8600", Offset = "0x1DE8701", VA = "0x1DE8600")]
	private void Start()
	{
	}

	// Token: 0x060039E8 RID: 14824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003057")]
	[Address(RVA = "0x1DE8670", Offset = "0x1DE8771", VA = "0x1DE8670")]
	public static void DoActionRpExp(SkillActionID skillActionID, int level = 1)
	{
	}

	// Token: 0x060039E9 RID: 14825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003058")]
	[Address(RVA = "0x1DE8820", Offset = "0x1DE8921", VA = "0x1DE8820")]
	public static void DoActionExp(SkillActionID skillActionID)
	{
	}

	// Token: 0x060039EA RID: 14826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003059")]
	[Address(RVA = "0x1DE8720", Offset = "0x1DE8821", VA = "0x1DE8720")]
	public static void DoActionRp(SkillActionID skillUpAction, int level = 1)
	{
	}

	// Token: 0x060039EB RID: 14827 RVA: 0x00014028 File Offset: 0x00012228
	[Token(Token = "0x600305A")]
	[Address(RVA = "0x1DE8E00", Offset = "0x1DE8F01", VA = "0x1DE8E00")]
	public static int GetSkillLevel(SkillID skillID)
	{
		return 0;
	}

	// Token: 0x060039EC RID: 14828 RVA: 0x00014040 File Offset: 0x00012240
	[Token(Token = "0x600305B")]
	[Address(RVA = "0x1DE8E60", Offset = "0x1DE8F61", VA = "0x1DE8E60")]
	public static int GetExp(SkillID skillID)
	{
		return 0;
	}

	// Token: 0x060039ED RID: 14829 RVA: 0x00014058 File Offset: 0x00012258
	[Token(Token = "0x600305C")]
	[Address(RVA = "0x1DE8EC0", Offset = "0x1DE8FC1", VA = "0x1DE8EC0")]
	public static int GetNextLevelExp(SkillID skillID)
	{
		return 0;
	}

	// Token: 0x060039EE RID: 14830 RVA: 0x00014070 File Offset: 0x00012270
	[Token(Token = "0x600305D")]
	[Address(RVA = "0x1DE8FF0", Offset = "0x1DE90F1", VA = "0x1DE8FF0")]
	public static bool IsDeathCheck(SkillActionID skillActionID, int level = 1)
	{
		return default(bool);
	}

	// Token: 0x060039EF RID: 14831 RVA: 0x00014088 File Offset: 0x00012288
	[Token(Token = "0x600305E")]
	[Address(RVA = "0x1DE8A40", Offset = "0x1DE8B41", VA = "0x1DE8A40")]
	public static bool ExpUp(SkillID skillID, int exp)
	{
		return default(bool);
	}

	// Token: 0x060039F0 RID: 14832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600305F")]
	[Address(RVA = "0x1DE9300", Offset = "0x1DE9401", VA = "0x1DE9300")]
	public static void RandomSkillLvUp()
	{
	}

	// Token: 0x060039F1 RID: 14833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003060")]
	[Address(RVA = "0x1DE9120", Offset = "0x1DE9221", VA = "0x1DE9120")]
	private static void OrderFlagCheck(SkillID skillID, int level)
	{
	}

	// Token: 0x060039F2 RID: 14834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003061")]
	[Address(RVA = "0x1DE96D0", Offset = "0x1DE97D1", VA = "0x1DE96D0")]
	public SkillManager()
	{
	}

	// Token: 0x04007D72 RID: 32114
	[Token(Token = "0x4007164")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E420", Offset = "0x16E521")]
	private SkillLevelUpEffectController <EffectController>k__BackingField;
}
