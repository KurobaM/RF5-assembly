using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x02000958 RID: 2392
[Token(Token = "0x2000646")]
[Serializable]
public class CutInTelopPlayAsset : PlayableAsset
{
	// Token: 0x06003F75 RID: 16245 RVA: 0x00015870 File Offset: 0x00013A70
	[Token(Token = "0x60034CC")]
	[Address(RVA = "0x20EEAD0", Offset = "0x20EEBD1", VA = "0x20EEAD0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003F76 RID: 16246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034CD")]
	[Address(RVA = "0x20EEBD0", Offset = "0x20EECD1", VA = "0x20EEBD0")]
	public CutInTelopPlayAsset()
	{
	}

	// Token: 0x040080ED RID: 33005
	[Token(Token = "0x400741E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string textId;

	// Token: 0x040080EE RID: 33006
	[Token(Token = "0x400741F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float stayTime;

	// Token: 0x040080EF RID: 33007
	[Token(Token = "0x4007420")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool playSE;
}
