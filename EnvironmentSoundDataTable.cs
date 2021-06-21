using System;
using DataTable;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200036A RID: 874
[Token(Token = "0x2000297")]
[Serializable]
public class EnvironmentSoundDataTable
{
	// Token: 0x060016AB RID: 5803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600141C")]
	[Address(RVA = "0x22B4920", Offset = "0x22B4A21", VA = "0x22B4920")]
	public static EnvironmentSoundDataTable[] GetDataTables(EnvironmentSoundType type)
	{
		return null;
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600141D")]
	[Address(RVA = "0x22B4AA0", Offset = "0x22B4BA1", VA = "0x22B4AA0")]
	public static EnvironmentSoundDataTable[] GetDataTables(FieldSceneId id)
	{
		return null;
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141E")]
	[Address(RVA = "0x22B4C20", Offset = "0x22B4D21", VA = "0x22B4C20")]
	public EnvironmentSoundDataTable()
	{
	}

	// Token: 0x04000ECB RID: 3787
	[Token(Token = "0x4000B9D")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public EnvironmentSoundType EnvironmentSoundType;

	// Token: 0x04000ECC RID: 3788
	[Token(Token = "0x4000B9E")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public FieldSceneId FieldSceneId;

	// Token: 0x04000ECD RID: 3789
	[Token(Token = "0x4000B9F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public SoundID SoundID;

	// Token: 0x04000ECE RID: 3790
	[Token(Token = "0x4000BA0")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public bool IsSpring;

	// Token: 0x04000ECF RID: 3791
	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x1D")]
	[SerializeField]
	public bool IsSummer;

	// Token: 0x04000ED0 RID: 3792
	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x1E")]
	[SerializeField]
	public bool IsAutumn;

	// Token: 0x04000ED1 RID: 3793
	[Token(Token = "0x4000BA3")]
	[FieldOffset(Offset = "0x1F")]
	[SerializeField]
	public bool IsWinter;

	// Token: 0x04000ED2 RID: 3794
	[Token(Token = "0x4000BA4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public bool IsSunny;

	// Token: 0x04000ED3 RID: 3795
	[Token(Token = "0x4000BA5")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	public bool IsCloud;

	// Token: 0x04000ED4 RID: 3796
	[Token(Token = "0x4000BA6")]
	[FieldOffset(Offset = "0x22")]
	[SerializeField]
	public bool IsRain;

	// Token: 0x04000ED5 RID: 3797
	[Token(Token = "0x4000BA7")]
	[FieldOffset(Offset = "0x23")]
	[SerializeField]
	public bool IsSnow;

	// Token: 0x04000ED6 RID: 3798
	[Token(Token = "0x4000BA8")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public bool IsTyphoon;

	// Token: 0x04000ED7 RID: 3799
	[Token(Token = "0x4000BA9")]
	[FieldOffset(Offset = "0x25")]
	[SerializeField]
	public bool IsSnowstorm;

	// Token: 0x04000ED8 RID: 3800
	[Token(Token = "0x4000BAA")]
	[FieldOffset(Offset = "0x26")]
	[SerializeField]
	public bool IsRoony;

	// Token: 0x04000ED9 RID: 3801
	[Token(Token = "0x4000BAB")]
	[FieldOffset(Offset = "0x27")]
	[SerializeField]
	public bool IsMeteorShower;

	// Token: 0x04000EDA RID: 3802
	[Token(Token = "0x4000BAC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int StartHour;

	// Token: 0x04000EDB RID: 3803
	[Token(Token = "0x4000BAD")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int EndHour;

	// Token: 0x04000EDC RID: 3804
	[Token(Token = "0x4000BAE")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int Interval;

	// Token: 0x04000EDD RID: 3805
	[Token(Token = "0x4000BAF")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int IntervalMax;

	// Token: 0x04000EDE RID: 3806
	[Token(Token = "0x4000BB0")]
	[FieldOffset(Offset = "0x0")]
	private static EnvironmentSoundDataTableArray _EnvironmentSoundDataTableArray;
}
