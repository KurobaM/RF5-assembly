using System;
using Il2CppDummyDll;
using Loader.ID;

// Token: 0x0200036B RID: 875
[Token(Token = "0x2000298")]
[Serializable]
public class EquipAttach
{
	// Token: 0x060016AF RID: 5807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001420")]
	[Address(RVA = "0x22B6AB0", Offset = "0x22B6BB1", VA = "0x22B6AB0")]
	public EquipAttach()
	{
	}

	// Token: 0x04000EDF RID: 3807
	[Token(Token = "0x4000BB1")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	// Token: 0x04000EE0 RID: 3808
	[Token(Token = "0x4000BB2")]
	[FieldOffset(Offset = "0x18")]
	public string modelName;

	// Token: 0x04000EE1 RID: 3809
	[Token(Token = "0x4000BB3")]
	[FieldOffset(Offset = "0x20")]
	public Prefab prefabId;

	// Token: 0x04000EE2 RID: 3810
	[Token(Token = "0x4000BB4")]
	[FieldOffset(Offset = "0x24")]
	public HumanAttachIDEnum attachId;
}
