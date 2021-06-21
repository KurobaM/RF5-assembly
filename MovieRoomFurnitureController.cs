using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005BA RID: 1466
[Token(Token = "0x200041C")]
public class MovieRoomFurnitureController : MonoBehaviour, InteractionInterface, FocusInterface
{
	// Token: 0x060023E5 RID: 9189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E2B")]
	[Address(RVA = "0x1E16FB0", Offset = "0x1E170B1", VA = "0x1E16FB0", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x170005DC RID: 1500
	// (get) Token: 0x060023E6 RID: 9190 RVA: 0x0000E910 File Offset: 0x0000CB10
	[Token(Token = "0x170004AE")]
	public bool Focusable
	{
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x1E170A0", Offset = "0x1E171A1", VA = "0x1E170A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005DD RID: 1501
	// (get) Token: 0x060023E7 RID: 9191 RVA: 0x0000E928 File Offset: 0x0000CB28
	[Token(Token = "0x170004AF")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0x1E170B0", Offset = "0x1E171B1", VA = "0x1E170B0", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x170005DE RID: 1502
	// (get) Token: 0x060023E8 RID: 9192 RVA: 0x0000E940 File Offset: 0x0000CB40
	[Token(Token = "0x170004B0")]
	public int FocusPriority
	{
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x1E170C0", Offset = "0x1E171C1", VA = "0x1E170C0", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170005DF RID: 1503
	// (get) Token: 0x060023E9 RID: 9193 RVA: 0x0000E958 File Offset: 0x0000CB58
	[Token(Token = "0x170004B1")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x1E170D0", Offset = "0x1E171D1", VA = "0x1E170D0", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x060023EA RID: 9194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E30")]
	[Address(RVA = "0x1E170E0", Offset = "0x1E171E1", VA = "0x1E170E0", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x060023EB RID: 9195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E31")]
	[Address(RVA = "0x1E170F0", Offset = "0x1E171F1", VA = "0x1E170F0", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x060023EC RID: 9196 RVA: 0x0000E970 File Offset: 0x0000CB70
	[Token(Token = "0x6001E32")]
	[Address(RVA = "0x1E17100", Offset = "0x1E17201", VA = "0x1E17100", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x060023ED RID: 9197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E33")]
	[Address(RVA = "0x1E171C0", Offset = "0x1E172C1", VA = "0x1E171C0", Slot = "4")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x060023EE RID: 9198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E34")]
	[Address(RVA = "0x1E17230", Offset = "0x1E17331", VA = "0x1E17230", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x060023EF RID: 9199 RVA: 0x0000E988 File Offset: 0x0000CB88
	[Token(Token = "0x6001E35")]
	[Address(RVA = "0x1E17190", Offset = "0x1E17291", VA = "0x1E17190", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x060023F0 RID: 9200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E36")]
	[Address(RVA = "0x1E17280", Offset = "0x1E17381", VA = "0x1E17280", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x060023F1 RID: 9201 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
	[Token(Token = "0x6001E37")]
	[Address(RVA = "0x1E17290", Offset = "0x1E17391", VA = "0x1E17290", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x060023F2 RID: 9202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E38")]
	[Address(RVA = "0x1E172A0", Offset = "0x1E173A1", VA = "0x1E172A0")]
	public MovieRoomFurnitureController()
	{
	}

	// Token: 0x060023F3 RID: 9203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E39")]
	[Address(RVA = "0x1E172B0", Offset = "0x1E173B1", VA = "0x1E172B0", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x060023F4 RID: 9204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E3A")]
	[Address(RVA = "0x1E172C0", Offset = "0x1E173C1", VA = "0x1E172C0", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}
}
