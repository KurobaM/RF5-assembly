using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000372 RID: 882
[Token(Token = "0x200029E")]
[Serializable]
public class FishingConstDataTableArray : ScriptableObject
{
	// Token: 0x060016BE RID: 5822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600142F")]
	[Address(RVA = "0x1EC7CD0", Offset = "0x1EC7DD1", VA = "0x1EC7CD0")]
	public FishingConstDataTableArray()
	{
	}

	// Token: 0x04000F1D RID: 3869
	[Token(Token = "0x4000BE5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public FishingConstDataTable[] DataTables;
}
