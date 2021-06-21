using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000874 RID: 2164
[Token(Token = "0x2000598")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x146820", Offset = "0x146921")]
[Serializable]
public class NpcPlaceTable : ScriptableObject
{
	// Token: 0x0600393B RID: 14651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FBF")]
	[Address(RVA = "0x1F53CA0", Offset = "0x1F53DA1", VA = "0x1F53CA0")]
	public NpcPlaceTable()
	{
	}

	// Token: 0x04007C89 RID: 31881
	[Token(Token = "0x400709C")]
	[FieldOffset(Offset = "0x18")]
	public List<NpcPlaceSchedule> NpcPlaceSchedules;
}
