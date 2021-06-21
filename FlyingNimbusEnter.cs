using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005C8 RID: 1480
[Token(Token = "0x2000428")]
public class FlyingNimbusEnter : MonoBehaviour
{
	// Token: 0x06002458 RID: 9304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E9E")]
	[Address(RVA = "0x1ECB3A0", Offset = "0x1ECB4A1", VA = "0x1ECB3A0")]
	private void Start()
	{
	}

	// Token: 0x06002459 RID: 9305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E9F")]
	[Address(RVA = "0x1ECB4C0", Offset = "0x1ECB5C1", VA = "0x1ECB4C0")]
	private void OnStayEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x0600245A RID: 9306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EA0")]
	[Address(RVA = "0x1ECB5D0", Offset = "0x1ECB6D1", VA = "0x1ECB5D0")]
	private void OnExitEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x0600245B RID: 9307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EA1")]
	[Address(RVA = "0x1ECB6E0", Offset = "0x1ECB7E1", VA = "0x1ECB6E0")]
	public FlyingNimbusEnter()
	{
	}

	// Token: 0x04006BCE RID: 27598
	[Token(Token = "0x400651E")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HideInInspector", RVA = "0x166DF0", Offset = "0x166EF1")]
	public bool PlayerIn;

	// Token: 0x04006BCF RID: 27599
	[Token(Token = "0x400651F")]
	[FieldOffset(Offset = "0x20")]
	protected SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher;
}
