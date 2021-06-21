using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000355 RID: 853
[Token(Token = "0x2000284")]
public class ConstFarm : ScriptableObject
{
	// Token: 0x17000406 RID: 1030
	// (get) Token: 0x06001663 RID: 5731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700039C")]
	public static ConstFarm Instance
	{
		[Token(Token = "0x60013D5")]
		[Address(RVA = "0x20E0D10", Offset = "0x20E0E11", VA = "0x20E0D10")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x20E0E20", Offset = "0x20E0F21", VA = "0x20E0E20")]
	public ConstFarm()
	{
	}

	// Token: 0x04000E4C RID: 3660
	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int MonsterHut_AppealLoveLevel;

	// Token: 0x04000E4D RID: 3661
	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int MonsterHut_FriendLoveLevel;

	// Token: 0x04000E4E RID: 3662
	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int MonsterHut_EscapeLoveLevel;

	// Token: 0x04000E4F RID: 3663
	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float MonsterHut_MinWaitTime;

	// Token: 0x04000E50 RID: 3664
	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float MonsterHut_MaxWaitTime;

	// Token: 0x04000E51 RID: 3665
	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float MonsterHut_WanderRange;

	// Token: 0x04000E52 RID: 3666
	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float MonsterHut_EscapeRange;

	// Token: 0x04000E53 RID: 3667
	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public float MonsterHut_AppealRange;

	// Token: 0x04000E54 RID: 3668
	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int MonsterHut_TiredHPPercent;

	// Token: 0x04000E55 RID: 3669
	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public int Esa_Power;

	// Token: 0x04000E56 RID: 3670
	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public int WorkCost_MaxHpRatio;

	// Token: 0x04000E57 RID: 3671
	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public int Farm_WorkCost;

	// Token: 0x04000E58 RID: 3672
	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public int Farm_WorkSeedCost;

	// Token: 0x04000E59 RID: 3673
	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public int NotTask_WanderRate;

	// Token: 0x04000E5A RID: 3674
	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public int NotTask_WaitRate;

	// Token: 0x04000E5B RID: 3675
	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	public float NotTask_MaxWaitTime;

	// Token: 0x04000E5C RID: 3676
	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public float NotTask_MinWaitTime;

	// Token: 0x04000E5D RID: 3677
	[Token(Token = "0x4000B3E")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public int MaxRandomCutWoolDropCount_Enemy;

	// Token: 0x04000E5E RID: 3678
	[Token(Token = "0x4000B3F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public int MaxRandomCutWoolDropCount_Friend;

	// Token: 0x04000E5F RID: 3679
	[Token(Token = "0x4000B40")]
	[FieldOffset(Offset = "0x0")]
	private static ConstFarm _Instance;
}
