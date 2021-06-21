using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200044D RID: 1101
[Token(Token = "0x200034D")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145D40", Offset = "0x145E41")]
[Serializable]
public class FesNpcScoreTable : ScriptableObject
{
	// Token: 0x06001AA2 RID: 6818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x21B3510", Offset = "0x21B3611", VA = "0x21B3510")]
	public FesNpcScoreTable()
	{
	}

	// Token: 0x04005D9C RID: 23964
	[Token(Token = "0x40059D6")]
	[FieldOffset(Offset = "0x18")]
	public List<FesNpcScoreData> datas;
}
