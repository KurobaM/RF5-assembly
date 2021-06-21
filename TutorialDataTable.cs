using System;
using Il2CppDummyDll;
using Tutorial;
using UnityEngine;

// Token: 0x020003CC RID: 972
[Token(Token = "0x20002EE")]
[Serializable]
public class TutorialDataTable
{
	// Token: 0x06001786 RID: 6022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014EA")]
	[Address(RVA = "0x1FFC7C0", Offset = "0x1FFC8C1", VA = "0x1FFC7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014EB")]
	[Address(RVA = "0x1FFCBB0", Offset = "0x1FFCCB1", VA = "0x1FFCBB0")]
	public TutorialDataTable()
	{
	}

	// Token: 0x040010DE RID: 4318
	[Token(Token = "0x4000D7A")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public TutorialCmd Cmd;

	// Token: 0x040010DF RID: 4319
	[Token(Token = "0x4000D7B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string Para0;

	// Token: 0x040010E0 RID: 4320
	[Token(Token = "0x4000D7C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float PosX;

	// Token: 0x040010E1 RID: 4321
	[Token(Token = "0x4000D7D")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float PosY;

	// Token: 0x040010E2 RID: 4322
	[Token(Token = "0x4000D7E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float PosZ;

	// Token: 0x040010E3 RID: 4323
	[Token(Token = "0x4000D7F")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int Pad;
}
