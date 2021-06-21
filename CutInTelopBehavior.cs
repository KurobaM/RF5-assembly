using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

// Token: 0x02000956 RID: 2390
[Token(Token = "0x2000644")]
[Serializable]
public class CutInTelopBehavior : PlayableBehaviour
{
	// Token: 0x06003F6D RID: 16237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034C4")]
	[Address(RVA = "0x20EE3D0", Offset = "0x20EE4D1", VA = "0x20EE3D0", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003F6E RID: 16238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034C5")]
	[Address(RVA = "0x20EE3E0", Offset = "0x20EE4E1", VA = "0x20EE3E0", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003F6F RID: 16239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034C6")]
	[Address(RVA = "0x20EE550", Offset = "0x20EE651", VA = "0x20EE550")]
	public CutInTelopBehavior()
	{
	}

	// Token: 0x040080DF RID: 32991
	[Token(Token = "0x4007410")]
	[FieldOffset(Offset = "0x10")]
	public string textId;

	// Token: 0x040080E0 RID: 32992
	[Token(Token = "0x4007411")]
	[FieldOffset(Offset = "0x18")]
	public float stayTime;

	// Token: 0x040080E1 RID: 32993
	[Token(Token = "0x4007412")]
	[FieldOffset(Offset = "0x1C")]
	public bool PlaySE;
}
