using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005C3 RID: 1475
[Token(Token = "0x2000425")]
public class FallRock : MonoBehaviour
{
	// Token: 0x06002431 RID: 9265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E77")]
	[Address(RVA = "0x21C93D0", Offset = "0x21C94D1", VA = "0x21C93D0")]
	private void Awake()
	{
	}

	// Token: 0x06002432 RID: 9266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E78")]
	[Address(RVA = "0x21C9460", Offset = "0x21C9561", VA = "0x21C9460")]
	private void Start()
	{
	}

	// Token: 0x06002433 RID: 9267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E79")]
	[Address(RVA = "0x21C9470", Offset = "0x21C9571", VA = "0x21C9470")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06002434 RID: 9268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E7A")]
	[Address(RVA = "0x21C95D0", Offset = "0x21C96D1", VA = "0x21C95D0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06002435 RID: 9269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E7B")]
	[Address(RVA = "0x21C98B0", Offset = "0x21C99B1", VA = "0x21C98B0")]
	private void Break()
	{
	}

	// Token: 0x06002436 RID: 9270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E7C")]
	[Address(RVA = "0x21C9BC0", Offset = "0x21C9CC1", VA = "0x21C9BC0")]
	public FallRock()
	{
	}

	// Token: 0x04006BA3 RID: 27555
	[Token(Token = "0x40064FA")]
	[FieldOffset(Offset = "0x18")]
	public float DamagePercent;

	// Token: 0x04006BA4 RID: 27556
	[Token(Token = "0x40064FB")]
	[FieldOffset(Offset = "0x1C")]
	public float FallAccelSpeed;

	// Token: 0x04006BA5 RID: 27557
	[Token(Token = "0x40064FC")]
	[FieldOffset(Offset = "0x20")]
	public float FallMaxSpeed;

	// Token: 0x04006BA6 RID: 27558
	[Token(Token = "0x40064FD")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float DelayTime;

	// Token: 0x04006BA7 RID: 27559
	[Token(Token = "0x40064FE")]
	[FieldOffset(Offset = "0x28")]
	private float CurrentSpeed;

	// Token: 0x04006BA8 RID: 27560
	[Token(Token = "0x40064FF")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody[] Rigidbodys;

	// Token: 0x04006BA9 RID: 27561
	[Token(Token = "0x4006500")]
	[FieldOffset(Offset = "0x38")]
	private MeshCollider[] MeshColliders;

	// Token: 0x04006BAA RID: 27562
	[Token(Token = "0x4006501")]
	[FieldOffset(Offset = "0x40")]
	private bool IsBreak;

	// Token: 0x04006BAB RID: 27563
	[Token(Token = "0x4006502")]
	[FieldOffset(Offset = "0x44")]
	public SoundID BreakSe;
}
