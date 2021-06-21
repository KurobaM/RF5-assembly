using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004AB RID: 1195
[Token(Token = "0x2000377")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145E40", Offset = "0x145F41")]
[Serializable]
public class SubEventSaveData
{
	// Token: 0x06001D2B RID: 7467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600193C")]
	[Address(RVA = "0x1FAB3F0", Offset = "0x1FAB4F1", VA = "0x1FAB3F0")]
	public void Initialize()
	{
	}

	// Token: 0x06001D2C RID: 7468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600193D")]
	[Address(RVA = "0x1FAB400", Offset = "0x1FAB501", VA = "0x1FAB400")]
	public SubEventSaveData()
	{
	}

	// Token: 0x040062C6 RID: 25286
	[Token(Token = "0x4005DAF")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164A00", Offset = "0x164B01")]
	[SerializeField]
	public int ProgressingSubEventID;
}
