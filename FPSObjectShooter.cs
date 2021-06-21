using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B90 RID: 2960
[Token(Token = "0x20007AE")]
public class FPSObjectShooter : MonoBehaviour
{
	// Token: 0x06004BFF RID: 19455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FB2")]
	[Address(RVA = "0x21BFF10", Offset = "0x21C0011", VA = "0x21BFF10")]
	private void Start()
	{
	}

	// Token: 0x06004C00 RID: 19456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FB3")]
	[Address(RVA = "0x21BFF40", Offset = "0x21C0041", VA = "0x21BFF40")]
	private void Update()
	{
	}

	// Token: 0x06004C01 RID: 19457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FB4")]
	[Address(RVA = "0x21C02B0", Offset = "0x21C03B1", VA = "0x21C02B0")]
	public FPSObjectShooter()
	{
	}

	// Token: 0x0400AD02 RID: 44290
	[Token(Token = "0x4008280")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Element;

	// Token: 0x0400AD03 RID: 44291
	[Token(Token = "0x4008281")]
	[FieldOffset(Offset = "0x20")]
	public float InitialSpeed;

	// Token: 0x0400AD04 RID: 44292
	[Token(Token = "0x4008282")]
	[FieldOffset(Offset = "0x24")]
	public float MouseSpeed;

	// Token: 0x0400AD05 RID: 44293
	[Token(Token = "0x4008283")]
	[FieldOffset(Offset = "0x28")]
	public float Scale;

	// Token: 0x0400AD06 RID: 44294
	[Token(Token = "0x4008284")]
	[FieldOffset(Offset = "0x2C")]
	public float Mass;

	// Token: 0x0400AD07 RID: 44295
	[Token(Token = "0x4008285")]
	[FieldOffset(Offset = "0x30")]
	public float Life;

	// Token: 0x0400AD08 RID: 44296
	[Token(Token = "0x4008286")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 m_v3MousePosition;
}
