using System;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x0200037E RID: 894
[Token(Token = "0x20002A8")]
[Serializable]
public class HumanData
{
	// Token: 0x060016DA RID: 5850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600144A")]
	[Address(RVA = "0x20A1AF0", Offset = "0x20A1BF1", VA = "0x20A1AF0")]
	public HumanData()
	{
	}

	// Token: 0x04000F59 RID: 3929
	[Token(Token = "0x4000C11")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public VariationNo Variation;

	// Token: 0x04000F5A RID: 3930
	[Token(Token = "0x4000C12")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public HairType Hair;

	// Token: 0x04000F5B RID: 3931
	[Token(Token = "0x4000C13")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string AssetName;

	// Token: 0x04000F5C RID: 3932
	[Token(Token = "0x4000C14")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string PrefabName;

	// Token: 0x04000F5D RID: 3933
	[Token(Token = "0x4000C15")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Loader.ID.Character DataId;
}
