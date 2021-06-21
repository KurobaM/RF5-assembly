using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003A7 RID: 935
[Token(Token = "0x20002CE")]
public class MonsterSetDataTable : ScriptableObject
{
	// Token: 0x06001734 RID: 5940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149F")]
	[Address(RVA = "0x1E71C70", Offset = "0x1E71D71", VA = "0x1E71C70")]
	public MonsterSetDataTable()
	{
	}

	// Token: 0x0400104E RID: 4174
	[Token(Token = "0x4000D00")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public GameObject MonsterPrefab;

	// Token: 0x0400104F RID: 4175
	[Token(Token = "0x4000D01")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public AnimationClip[] BodyAnimations;

	// Token: 0x04001050 RID: 4176
	[Token(Token = "0x4000D02")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public AnimationClip[] FaceAnimations;
}
