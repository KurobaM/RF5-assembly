using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009A RID: 154
[Token(Token = "0x2000077")]
public class RandomAroundTargetProjectileActionCommand : MonsterActionBaseCommandBase
{
	// Token: 0x1700007A RID: 122
	// (get) Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000077")]
	public string NextActionCode
	{
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1F3A2B0", Offset = "0x1F3A3B1", VA = "0x1F3A2B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x060002F9 RID: 761 RVA: 0x00002F28 File Offset: 0x00001128
	[Token(Token = "0x17000078")]
	public bool UseLockonTarget
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1F3A2D0", Offset = "0x1F3A3D1", VA = "0x1F3A2D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x060002FA RID: 762 RVA: 0x00002F40 File Offset: 0x00001140
	[Token(Token = "0x17000079")]
	public float CreateRange
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1F3A2F0", Offset = "0x1F3A3F1", VA = "0x1F3A2F0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x060002FB RID: 763 RVA: 0x00002F58 File Offset: 0x00001158
	[Token(Token = "0x1700007A")]
	public int CreateAngleUnit
	{
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1F3A310", Offset = "0x1F3A411", VA = "0x1F3A310")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x060002FC RID: 764 RVA: 0x00002F70 File Offset: 0x00001170
	[Token(Token = "0x1700007B")]
	public Vector3 Direction
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1F3A330", Offset = "0x1F3A431", VA = "0x1F3A330")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1F3A350", Offset = "0x1F3A451", VA = "0x1F3A350")]
	public RandomAroundTargetProjectileActionCommand(ActionCommandDataTable actionCommandData, MonsterActionScriptsControllerBase controller)
	{
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1F3A3B0", Offset = "0x1F3A4B1", VA = "0x1F3A3B0", Slot = "8")]
	public override void DoAction()
	{
	}
}
