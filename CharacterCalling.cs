using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000426 RID: 1062
[Token(Token = "0x2000332")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145BD0", Offset = "0x145CD1")]
[Serializable]
public class CharacterCalling : ScriptableObject
{
	// Token: 0x060019C9 RID: 6601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016EF")]
	[Address(RVA = "0x1E8D6A0", Offset = "0x1E8D7A1", VA = "0x1E8D6A0")]
	public CharacterCalling()
	{
	}

	// Token: 0x04005CCC RID: 23756
	[Token(Token = "0x4005913")]
	[FieldOffset(Offset = "0x18")]
	public List<CharacterCallingData> datas;
}
