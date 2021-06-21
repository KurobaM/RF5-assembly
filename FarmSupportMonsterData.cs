using System;
using BinaryStream;
using Define;
using Il2CppDummyDll;
using SaveData;
using UnityEngine;

// Token: 0x020007AD RID: 1965
[Token(Token = "0x2000528")]
[Serializable]
public class FarmSupportMonsterData : SaveDataValueBase
{
	// Token: 0x1700070A RID: 1802
	// (get) Token: 0x060032B1 RID: 12977 RVA: 0x00011718 File Offset: 0x0000F918
	[Token(Token = "0x17000584")]
	public bool Used
	{
		[Token(Token = "0x6002A38")]
		[Address(RVA = "0x21AF280", Offset = "0x21AF381", VA = "0x21AF280")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060032B2 RID: 12978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A39")]
	[Address(RVA = "0x21AF290", Offset = "0x21AF391", VA = "0x21AF290")]
	public FarmSupportMonsterData()
	{
	}

	// Token: 0x060032B3 RID: 12979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A3A")]
	[Address(RVA = "0x21AF2C0", Offset = "0x21AF3C1", VA = "0x21AF2C0")]
	public void Set(uint friendMonsterDataID, FarmSupportState farmSupportState, int workTime, int cellIndex, Vector3 position, Quaternion rotation)
	{
	}

	// Token: 0x060032B4 RID: 12980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A3B")]
	[Address(RVA = "0x21AF2F0", Offset = "0x21AF3F1", VA = "0x21AF2F0", Slot = "4")]
	public override void Initialize()
	{
	}

	// Token: 0x060032B5 RID: 12981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A3C")]
	[Address(RVA = "0x21AF3C0", Offset = "0x21AF4C1", VA = "0x21AF3C0", Slot = "5")]
	public override void BeforeSave()
	{
	}

	// Token: 0x060032B6 RID: 12982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A3D")]
	[Address(RVA = "0x21AF3D0", Offset = "0x21AF4D1", VA = "0x21AF3D0", Slot = "6")]
	public override void AfterLoad()
	{
	}

	// Token: 0x060032B7 RID: 12983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A3E")]
	[Address(RVA = "0x21AF3E0", Offset = "0x21AF4E1", VA = "0x21AF3E0", Slot = "7")]
	public override void Writer(BinaryWriter writer)
	{
	}

	// Token: 0x060032B8 RID: 12984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A3F")]
	[Address(RVA = "0x21AF4C0", Offset = "0x21AF5C1", VA = "0x21AF4C0")]
	public void Reader0000(BinaryReader reader)
	{
	}

	// Token: 0x04007748 RID: 30536
	[Token(Token = "0x4006CA7")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public uint FriendMonsterDataID;

	// Token: 0x04007749 RID: 30537
	[Token(Token = "0x4006CA8")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public FarmSupportState State;

	// Token: 0x0400774A RID: 30538
	[Token(Token = "0x4006CA9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int WorkTime;

	// Token: 0x0400774B RID: 30539
	[Token(Token = "0x4006CAA")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int CellIndex;

	// Token: 0x0400774C RID: 30540
	[Token(Token = "0x4006CAB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Vector3 Position;

	// Token: 0x0400774D RID: 30541
	[Token(Token = "0x4006CAC")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public Quaternion Rotation;
}
