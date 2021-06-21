using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200076E RID: 1902
[Token(Token = "0x2000518")]
public class SoulBehavior : MonoBehaviour
{
	// Token: 0x060030FF RID: 12543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600292B")]
	[Address(RVA = "0x22573C0", Offset = "0x22574C1", VA = "0x22573C0")]
	private void Start()
	{
	}

	// Token: 0x06003100 RID: 12544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600292C")]
	[Address(RVA = "0x2257440", Offset = "0x2257541", VA = "0x2257440")]
	private void Update()
	{
	}

	// Token: 0x06003101 RID: 12545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600292D")]
	[Address(RVA = "0x22577F0", Offset = "0x22578F1", VA = "0x22577F0")]
	public SoulBehavior()
	{
	}

	// Token: 0x04007611 RID: 30225
	[Token(Token = "0x4006C26")]
	[FieldOffset(Offset = "0x18")]
	private float LifeTime;

	// Token: 0x04007612 RID: 30226
	[Token(Token = "0x4006C27")]
	[FieldOffset(Offset = "0x20")]
	public Collider TargetCollider;

	// Token: 0x04007613 RID: 30227
	[Token(Token = "0x4006C28")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 Velocity;
}
