using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200045C RID: 1116
[Token(Token = "0x2000359")]
public class OrderBoardController : MonoBehaviour, InteractionInterface, FocusInterface
{
	// Token: 0x06001B01 RID: 6913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600180B")]
	[Address(RVA = "0x20C7540", Offset = "0x20C7641", VA = "0x20C7540")]
	private void Awake()
	{
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600180C")]
	[Address(RVA = "0x20C7650", Offset = "0x20C7751", VA = "0x20C7650", Slot = "4")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06001B03 RID: 6915 RVA: 0x0000BD00 File Offset: 0x00009F00
	[Token(Token = "0x600180D")]
	[Address(RVA = "0x20C7BF0", Offset = "0x20C7CF1", VA = "0x20C7BF0", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06001B04 RID: 6916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600180E")]
	[Address(RVA = "0x20C7CB0", Offset = "0x20C7DB1", VA = "0x20C7CB0", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600180F")]
	[Address(RVA = "0x20C7D00", Offset = "0x20C7E01", VA = "0x20C7D00", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x17000471 RID: 1137
	// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0000BD18 File Offset: 0x00009F18
	[Token(Token = "0x170003FF")]
	public bool Focusable
	{
		[Token(Token = "0x6001810")]
		[Address(RVA = "0x20C7D10", Offset = "0x20C7E11", VA = "0x20C7D10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000472 RID: 1138
	// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0000BD30 File Offset: 0x00009F30
	[Token(Token = "0x17000400")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001811")]
		[Address(RVA = "0x20C7D80", Offset = "0x20C7E81", VA = "0x20C7D80", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x17000473 RID: 1139
	// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0000BD48 File Offset: 0x00009F48
	[Token(Token = "0x17000401")]
	public int FocusPriority
	{
		[Token(Token = "0x6001812")]
		[Address(RVA = "0x20C7D90", Offset = "0x20C7E91", VA = "0x20C7D90", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000474 RID: 1140
	// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0000BD60 File Offset: 0x00009F60
	[Token(Token = "0x17000402")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001813")]
		[Address(RVA = "0x20C7DA0", Offset = "0x20C7EA1", VA = "0x20C7DA0", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x06001B0A RID: 6922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001814")]
	[Address(RVA = "0x20C7DB0", Offset = "0x20C7EB1", VA = "0x20C7DB0", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001815")]
	[Address(RVA = "0x20C7DC0", Offset = "0x20C7EC1", VA = "0x20C7DC0", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x06001B0C RID: 6924 RVA: 0x0000BD78 File Offset: 0x00009F78
	[Token(Token = "0x6001816")]
	[Address(RVA = "0x20C7DD0", Offset = "0x20C7ED1", VA = "0x20C7DD0", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x06001B0D RID: 6925 RVA: 0x0000BD90 File Offset: 0x00009F90
	[Token(Token = "0x6001817")]
	[Address(RVA = "0x20C7800", Offset = "0x20C7901", VA = "0x20C7800")]
	private bool CheckStory()
	{
		return default(bool);
	}

	// Token: 0x06001B0E RID: 6926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001818")]
	[Address(RVA = "0x20C7E50", Offset = "0x20C7F51", VA = "0x20C7E50", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x06001B0F RID: 6927 RVA: 0x0000BDA8 File Offset: 0x00009FA8
	[Token(Token = "0x6001819")]
	[Address(RVA = "0x20C7E60", Offset = "0x20C7F61", VA = "0x20C7E60", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x06001B10 RID: 6928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600181A")]
	[Address(RVA = "0x20C7E70", Offset = "0x20C7F71", VA = "0x20C7E70")]
	public OrderBoardController()
	{
	}

	// Token: 0x06001B11 RID: 6929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600181B")]
	[Address(RVA = "0x20C7ED0", Offset = "0x20C7FD1", VA = "0x20C7ED0", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x06001B12 RID: 6930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600181C")]
	[Address(RVA = "0x20C7EE0", Offset = "0x20C7FE1", VA = "0x20C7EE0", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x04005DF9 RID: 24057
	[Token(Token = "0x4005A08")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PublicationPlace publicationPlace;

	// Token: 0x04005DFA RID: 24058
	[Token(Token = "0x4005A09")]
	[FieldOffset(Offset = "0x20")]
	private string focusName;
}
