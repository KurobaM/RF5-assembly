using System;
using Il2CppDummyDll;
using SandBox;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020008B9 RID: 2233
[Token(Token = "0x20005C8")]
public class ActionScriptPlayable : PlayableAsset
{
	// Token: 0x06003B32 RID: 15154 RVA: 0x00014C10 File Offset: 0x00012E10
	[Token(Token = "0x6003197")]
	[Address(RVA = "0x1D45920", Offset = "0x1D45A21", VA = "0x1D45920", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003B33 RID: 15155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003198")]
	[Address(RVA = "0x1D45A00", Offset = "0x1D45B01", VA = "0x1D45A00")]
	public ActionScriptPlayable()
	{
	}

	// Token: 0x04007E16 RID: 32278
	[Token(Token = "0x40071D2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public TimelineToActionScriptExpoter.ActionScriptData ActionScriptData;
}
