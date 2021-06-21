using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004BF RID: 1215
[Token(Token = "0x2000384")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145ED0", Offset = "0x145FD1")]
[Serializable]
public class TutorialUnlockFlag : ScriptableObject
{
	// Token: 0x06001DD4 RID: 7636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C5")]
	[Address(RVA = "0x1FFCBD0", Offset = "0x1FFCCD1", VA = "0x1FFCBD0")]
	public void Init()
	{
	}

	// Token: 0x06001DD5 RID: 7637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C6")]
	[Address(RVA = "0x1FFCD40", Offset = "0x1FFCE41", VA = "0x1FFCD40")]
	public TutorialUnlockFlag()
	{
	}

	// Token: 0x0400641D RID: 25629
	[Token(Token = "0x4005EE1")]
	[FieldOffset(Offset = "0x18")]
	public List<TutorialUnlockFlagData> datas;

	// Token: 0x0400641E RID: 25630
	[Token(Token = "0x4005EE2")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public Dictionary<TutorialScriptType, TutorialUnlockFlagData> dic;
}
