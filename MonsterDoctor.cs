using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020007DF RID: 2015
[Token(Token = "0x2000538")]
public class MonsterDoctor : SingletonMonoBehaviour<MonsterDoctor>
{
	// Token: 0x17000741 RID: 1857
	// (get) Token: 0x060034AE RID: 13486 RVA: 0x00011EE0 File Offset: 0x000100E0
	// (set) Token: 0x060034AF RID: 13487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005AA")]
	public int SelectedPet
	{
		[Token(Token = "0x6002BD0")]
		[Address(RVA = "0x1E5E9C0", Offset = "0x1E5EAC1", VA = "0x1E5E9C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5390", Offset = "0x1A5491")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002BD1")]
		[Address(RVA = "0x1E5E9D0", Offset = "0x1E5EAD1", VA = "0x1E5E9D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A53A0", Offset = "0x1A54A1")]
		set
		{
		}
	}

	// Token: 0x060034B0 RID: 13488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BD2")]
	[Address(RVA = "0x1E5E9E0", Offset = "0x1E5EAE1", VA = "0x1E5E9E0")]
	private void Start()
	{
	}

	// Token: 0x060034B1 RID: 13489 RVA: 0x00011EF8 File Offset: 0x000100F8
	[Token(Token = "0x6002BD3")]
	[Address(RVA = "0x1E5EE10", Offset = "0x1E5EF11", VA = "0x1E5EE10")]
	public int GetMonsterPetAmount()
	{
		return 0;
	}

	// Token: 0x060034B2 RID: 13490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002BD4")]
	[Address(RVA = "0x1E5F060", Offset = "0x1E5F161", VA = "0x1E5F060")]
	public List<string> GetMonsterPetName()
	{
		return null;
	}

	// Token: 0x060034B3 RID: 13491 RVA: 0x00011F10 File Offset: 0x00010110
	[Token(Token = "0x6002BD5")]
	[Address(RVA = "0x1E5F1A0", Offset = "0x1E5F2A1", VA = "0x1E5F1A0")]
	public int GetMonsterPetBonus()
	{
		return 0;
	}

	// Token: 0x060034B4 RID: 13492 RVA: 0x00011F28 File Offset: 0x00010128
	[Token(Token = "0x6002BD6")]
	[Address(RVA = "0x1E5F350", Offset = "0x1E5F451", VA = "0x1E5F350")]
	public int GetMonsterPetLevel()
	{
		return 0;
	}

	// Token: 0x060034B5 RID: 13493 RVA: 0x00011F40 File Offset: 0x00010140
	[Token(Token = "0x6002BD7")]
	[Address(RVA = "0x1E5F400", Offset = "0x1E5F501", VA = "0x1E5F400")]
	public int GetMonsterPetLove()
	{
		return 0;
	}

	// Token: 0x060034B6 RID: 13494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002BD8")]
	[Address(RVA = "0x1E5F4D0", Offset = "0x1E5F5D1", VA = "0x1E5F4D0")]
	public List<string> GetAttributeResistance()
	{
		return null;
	}

	// Token: 0x060034B7 RID: 13495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002BD9")]
	[Address(RVA = "0x1E5F7B0", Offset = "0x1E5F8B1", VA = "0x1E5F7B0")]
	public List<string> GetBadStatusAttack()
	{
		return null;
	}

	// Token: 0x060034B8 RID: 13496 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002BDA")]
	[Address(RVA = "0x1E5FA90", Offset = "0x1E5FB91", VA = "0x1E5FA90")]
	public List<string> GetBadStatusDefence()
	{
		return null;
	}

	// Token: 0x060034B9 RID: 13497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002BDB")]
	[Address(RVA = "0x1E5FD70", Offset = "0x1E5FE71", VA = "0x1E5FD70")]
	public List<string> GetSpecialStatus()
	{
		return null;
	}

	// Token: 0x060034BA RID: 13498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BDC")]
	[Address(RVA = "0x1E5EFF0", Offset = "0x1E5F0F1", VA = "0x1E5EFF0")]
	private void Clear()
	{
	}

	// Token: 0x060034BB RID: 13499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BDD")]
	[Address(RVA = "0x1E60000", Offset = "0x1E60101", VA = "0x1E60000")]
	public MonsterDoctor()
	{
	}

	// Token: 0x04007864 RID: 30820
	[Token(Token = "0x4006D51")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169EF0", Offset = "0x169FF1")]
	private int <SelectedPet>k__BackingField;

	// Token: 0x04007865 RID: 30821
	[Token(Token = "0x4006D52")]
	[FieldOffset(Offset = "0x20")]
	private List<PartyMonster> monsterPets;

	// Token: 0x04007866 RID: 30822
	[Token(Token = "0x4006D53")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<MonsterDoctor.EvaluationType, string> evaluationText;

	// Token: 0x020007E0 RID: 2016
	[Token(Token = "0x200122C")]
	public enum EvaluationType
	{
		// Token: 0x04007868 RID: 30824
		[Token(Token = "0x4019779")]
		DefNormal,
		// Token: 0x04007869 RID: 30825
		[Token(Token = "0x401977A")]
		DefStrong,
		// Token: 0x0400786A RID: 30826
		[Token(Token = "0x401977B")]
		DefWeak,
		// Token: 0x0400786B RID: 30827
		[Token(Token = "0x401977C")]
		AtkNormal,
		// Token: 0x0400786C RID: 30828
		[Token(Token = "0x401977D")]
		AtkGootAt,
		// Token: 0x0400786D RID: 30829
		[Token(Token = "0x401977E")]
		AtkNotGoodAt
	}
}
