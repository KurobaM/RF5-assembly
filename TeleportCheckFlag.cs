using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200059D RID: 1437
[Token(Token = "0x20003FF")]
public class TeleportCheckFlag : MonoBehaviour
{
	// Token: 0x06002358 RID: 9048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D9E")]
	[Address(RVA = "0x1F699D0", Offset = "0x1F69AD1", VA = "0x1F699D0")]
	private void Awake()
	{
	}

	// Token: 0x06002359 RID: 9049 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
	[Token(Token = "0x6001D9F")]
	[Address(RVA = "0x1F69A80", Offset = "0x1F69B81", VA = "0x1F69A80")]
	private bool CanTeleport()
	{
		return default(bool);
	}

	// Token: 0x0600235A RID: 9050 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
	[Token(Token = "0x6001DA0")]
	[Address(RVA = "0x1F69B80", Offset = "0x1F69C81", VA = "0x1F69B80")]
	private bool CheckPartyActor(ActorID checkActorID)
	{
		return default(bool);
	}

	// Token: 0x0600235B RID: 9051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA1")]
	[Address(RVA = "0x1F69C20", Offset = "0x1F69D21", VA = "0x1F69C20")]
	public TeleportCheckFlag()
	{
	}

	// Token: 0x04006B17 RID: 27415
	[Token(Token = "0x400646E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected ActorID CheckActorID;

	// Token: 0x04006B18 RID: 27416
	[Token(Token = "0x400646F")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	protected bool CheckFlagState;

	// Token: 0x04006B19 RID: 27417
	[Token(Token = "0x4006470")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected GameFlagData GameFlagData;

	// Token: 0x04006B1A RID: 27418
	[Token(Token = "0x4006471")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected string EventScriptString;
}
