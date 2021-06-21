using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000899 RID: 2201
[Token(Token = "0x20005B1")]
public class SkillLevelUpEffectController : MonoBehaviour
{
	// Token: 0x17000809 RID: 2057
	// (get) Token: 0x060039DE RID: 14814 RVA: 0x00013FF8 File Offset: 0x000121F8
	// (set) Token: 0x060039DF RID: 14815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700064E")]
	private float CoolTime
	{
		[Token(Token = "0x600304E")]
		[Address(RVA = "0x1DE7E10", Offset = "0x1DE7F11", VA = "0x1DE7E10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5FB0", Offset = "0x1A60B1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600304F")]
		[Address(RVA = "0x1DE7E20", Offset = "0x1DE7F21", VA = "0x1DE7E20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5FC0", Offset = "0x1A60C1")]
		set
		{
		}
	}

	// Token: 0x060039E0 RID: 14816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003050")]
	[Address(RVA = "0x1DE7E30", Offset = "0x1DE7F31", VA = "0x1DE7E30")]
	private void Update()
	{
	}

	// Token: 0x060039E1 RID: 14817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003051")]
	[Address(RVA = "0x1DE7F50", Offset = "0x1DE8051", VA = "0x1DE7F50")]
	private void PlayLevelup(SkillLevelUpEffectController.LevelUpInfo info)
	{
	}

	// Token: 0x060039E2 RID: 14818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003052")]
	[Address(RVA = "0x1DE82F0", Offset = "0x1DE83F1", VA = "0x1DE82F0")]
	public void OnLevelUp(SkillID skillID, int level)
	{
	}

	// Token: 0x060039E3 RID: 14819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003053")]
	[Address(RVA = "0x1DE83F0", Offset = "0x1DE84F1", VA = "0x1DE83F0")]
	public SkillLevelUpEffectController()
	{
	}

	// Token: 0x04007D6C RID: 32108
	[Token(Token = "0x4007161")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float DelayTime;

	// Token: 0x04007D6D RID: 32109
	[Token(Token = "0x4007162")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E410", Offset = "0x16E511")]
	private float <CoolTime>k__BackingField;

	// Token: 0x04007D6E RID: 32110
	[Token(Token = "0x4007163")]
	[FieldOffset(Offset = "0x20")]
	private LinkedList<SkillLevelUpEffectController.LevelUpInfo> InfoList;

	// Token: 0x0200089A RID: 2202
	[Token(Token = "0x200126B")]
	private struct LevelUpInfo : IEquatable<SkillLevelUpEffectController.LevelUpInfo>
	{
		// Token: 0x060039E4 RID: 14820 RVA: 0x00014010 File Offset: 0x00012210
		[Token(Token = "0x6007477")]
		[Address(RVA = "0x2DDC70", Offset = "0x2DDD71", VA = "0x2DDC70", Slot = "4")]
		public bool Equals(SkillLevelUpEffectController.LevelUpInfo other)
		{
			return default(bool);
		}

		// Token: 0x04007D6F RID: 32111
		[Token(Token = "0x4019870")]
		[FieldOffset(Offset = "0x0")]
		public SkillID SkillID;

		// Token: 0x04007D70 RID: 32112
		[Token(Token = "0x4019871")]
		[FieldOffset(Offset = "0x4")]
		public int Level;

		// Token: 0x04007D71 RID: 32113
		[Token(Token = "0x4019872")]
		[FieldOffset(Offset = "0x8")]
		public int Counter;
	}
}
