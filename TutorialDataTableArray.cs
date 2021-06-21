using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003CD RID: 973
[Token(Token = "0x20002EF")]
[Serializable]
public class TutorialDataTableArray : ScriptableObject
{
	// Token: 0x06001788 RID: 6024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014EC")]
	[Address(RVA = "0x1FFCBC0", Offset = "0x1FFCCC1", VA = "0x1FFCBC0")]
	public TutorialDataTableArray()
	{
	}

	// Token: 0x040010E4 RID: 4324
	[Token(Token = "0x4000D80")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public TutorialDataTable[] DataTables;
}
