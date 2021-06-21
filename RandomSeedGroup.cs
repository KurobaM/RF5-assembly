using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001C")]
public class RandomSeedGroup : MonoBehaviour
{
	// Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1F3A980", Offset = "0x1F3AA81", VA = "0x1F3A980")]
	private void OnEnable()
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1F3ACD0", Offset = "0x1F3ADD1", VA = "0x1F3ACD0")]
	public RandomSeedGroup()
	{
	}

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] Particles;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x20")]
	private uint GlobalRandomSeed;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem PS;
}
