using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200047B RID: 1147
[Token(Token = "0x2000374")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145E30", Offset = "0x145F31")]
[Serializable]
public class SeriousEventScripts : ScriptableObject
{
	// Token: 0x06001BD3 RID: 7123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D2")]
	[Address(RVA = "0x1E317C0", Offset = "0x1E318C1", VA = "0x1E317C0")]
	public SeriousEventScripts()
	{
	}

	// Token: 0x0400618F RID: 24975
	[Token(Token = "0x4005D89")]
	[FieldOffset(Offset = "0x18")]
	public List<SeriousEventScriptsData> datas;
}
