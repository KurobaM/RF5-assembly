using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000551 RID: 1361
[Token(Token = "0x20003DB")]
public class IntaractionObject : MonoBehaviour, InteractionInterface, FocusInterface
{
	// Token: 0x060020F8 RID: 8440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BFD")]
	[Address(RVA = "0x2231E10", Offset = "0x2231F11", VA = "0x2231E10", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x1700055E RID: 1374
	// (get) Token: 0x060020F9 RID: 8441 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
	[Token(Token = "0x17000458")]
	public bool Focusable
	{
		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x2231E20", Offset = "0x2231F21", VA = "0x2231E20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700055F RID: 1375
	// (get) Token: 0x060020FA RID: 8442 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
	[Token(Token = "0x17000459")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x2231E30", Offset = "0x2231F31", VA = "0x2231E30", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x17000560 RID: 1376
	// (get) Token: 0x060020FB RID: 8443 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
	[Token(Token = "0x1700045A")]
	public int FocusPriority
	{
		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x2231E40", Offset = "0x2231F41", VA = "0x2231E40", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000561 RID: 1377
	// (get) Token: 0x060020FC RID: 8444 RVA: 0x0000D800 File Offset: 0x0000BA00
	[Token(Token = "0x1700045B")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001C01")]
		[Address(RVA = "0x2231E50", Offset = "0x2231F51", VA = "0x2231E50", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x060020FD RID: 8445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C02")]
	[Address(RVA = "0x2231E60", Offset = "0x2231F61", VA = "0x2231E60", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x060020FE RID: 8446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C03")]
	[Address(RVA = "0x2231E70", Offset = "0x2231F71", VA = "0x2231E70", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x060020FF RID: 8447 RVA: 0x0000D818 File Offset: 0x0000BA18
	[Token(Token = "0x6001C04")]
	[Address(RVA = "0x2231E80", Offset = "0x2231F81", VA = "0x2231E80", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C05")]
	[Address(RVA = "0x2231F40", Offset = "0x2232041", VA = "0x2231F40", Slot = "4")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C06")]
	[Address(RVA = "0x2231F60", Offset = "0x2232061", VA = "0x2231F60", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x0000D830 File Offset: 0x0000BA30
	[Token(Token = "0x6001C07")]
	[Address(RVA = "0x2231F10", Offset = "0x2232011", VA = "0x2231F10", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C08")]
	[Address(RVA = "0x2231FB0", Offset = "0x22320B1", VA = "0x2231FB0")]
	private void Start()
	{
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C09")]
	[Address(RVA = "0x2232110", Offset = "0x2232211", VA = "0x2232110", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x0000D848 File Offset: 0x0000BA48
	[Token(Token = "0x6001C0A")]
	[Address(RVA = "0x2232120", Offset = "0x2232221", VA = "0x2232120", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x06002106 RID: 8454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C0B")]
	[Address(RVA = "0x2232130", Offset = "0x2232231", VA = "0x2232130")]
	public IntaractionObject()
	{
	}

	// Token: 0x06002107 RID: 8455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C0C")]
	[Address(RVA = "0x22321E0", Offset = "0x22322E1", VA = "0x22321E0", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C0D")]
	[Address(RVA = "0x22321F0", Offset = "0x22322F1", VA = "0x22321F0", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x040067C6 RID: 26566
	[Token(Token = "0x40061AE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected string FoucsNameTextID;

	// Token: 0x040067C7 RID: 26567
	[Token(Token = "0x40061AF")]
	[FieldOffset(Offset = "0x20")]
	protected string FocusName;

	// Token: 0x040067C8 RID: 26568
	[Token(Token = "0x40061B0")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent DoInteractionEvent;
}
