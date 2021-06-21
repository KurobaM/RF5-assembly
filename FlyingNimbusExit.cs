using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005C9 RID: 1481
[Token(Token = "0x2000429")]
public class FlyingNimbusExit : MonoBehaviour
{
	// Token: 0x0600245C RID: 9308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EA2")]
	[Address(RVA = "0x1ECB6F0", Offset = "0x1ECB7F1", VA = "0x1ECB6F0")]
	private void Start()
	{
	}

	// Token: 0x0600245D RID: 9309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EA3")]
	[Address(RVA = "0x1ECB7C0", Offset = "0x1ECB8C1", VA = "0x1ECB7C0")]
	private void OnStayEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x0600245E RID: 9310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EA4")]
	[Address(RVA = "0x1ECB970", Offset = "0x1ECBA71", VA = "0x1ECB970")]
	protected void CallScript(string script_name)
	{
	}

	// Token: 0x0600245F RID: 9311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EA5")]
	[Address(RVA = "0x1ECBA80", Offset = "0x1ECBB81", VA = "0x1ECBA80")]
	public FlyingNimbusExit()
	{
	}

	// Token: 0x04006BD0 RID: 27600
	[Token(Token = "0x4006520")]
	[FieldOffset(Offset = "0x18")]
	public int ExitNo;

	// Token: 0x04006BD1 RID: 27601
	[Token(Token = "0x4006521")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ReturnPos;

	// Token: 0x04006BD2 RID: 27602
	[Token(Token = "0x4006522")]
	[FieldOffset(Offset = "0x28")]
	protected SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher;
}
