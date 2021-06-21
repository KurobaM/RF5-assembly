using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005B6 RID: 1462
[Token(Token = "0x2000418")]
public class CalendarFurnitureController : MonoBehaviour, InteractionInterface, FocusInterface
{
	// Token: 0x060023C8 RID: 9160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E0E")]
	[Address(RVA = "0x1E749A0", Offset = "0x1E74AA1", VA = "0x1E749A0", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x170005D7 RID: 1495
	// (get) Token: 0x060023C9 RID: 9161 RVA: 0x0000E820 File Offset: 0x0000CA20
	[Token(Token = "0x170004A9")]
	public bool Focusable
	{
		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x1E74A90", Offset = "0x1E74B91", VA = "0x1E74A90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005D8 RID: 1496
	// (get) Token: 0x060023CA RID: 9162 RVA: 0x0000E838 File Offset: 0x0000CA38
	[Token(Token = "0x170004AA")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001E10")]
		[Address(RVA = "0x1E74AA0", Offset = "0x1E74BA1", VA = "0x1E74AA0", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x170005D9 RID: 1497
	// (get) Token: 0x060023CB RID: 9163 RVA: 0x0000E850 File Offset: 0x0000CA50
	[Token(Token = "0x170004AB")]
	public int FocusPriority
	{
		[Token(Token = "0x6001E11")]
		[Address(RVA = "0x1E74AB0", Offset = "0x1E74BB1", VA = "0x1E74AB0", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170005DA RID: 1498
	// (get) Token: 0x060023CC RID: 9164 RVA: 0x0000E868 File Offset: 0x0000CA68
	[Token(Token = "0x170004AC")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001E12")]
		[Address(RVA = "0x1E74AC0", Offset = "0x1E74BC1", VA = "0x1E74AC0", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E13")]
	[Address(RVA = "0x1E74AD0", Offset = "0x1E74BD1", VA = "0x1E74AD0", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x060023CE RID: 9166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E14")]
	[Address(RVA = "0x1E74AE0", Offset = "0x1E74BE1", VA = "0x1E74AE0", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x060023CF RID: 9167 RVA: 0x0000E880 File Offset: 0x0000CA80
	[Token(Token = "0x6001E15")]
	[Address(RVA = "0x1E74AF0", Offset = "0x1E74BF1", VA = "0x1E74AF0", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E16")]
	[Address(RVA = "0x1E74BB0", Offset = "0x1E74CB1", VA = "0x1E74BB0", Slot = "4")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x060023D1 RID: 9169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E17")]
	[Address(RVA = "0x1E74C50", Offset = "0x1E74D51", VA = "0x1E74C50", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x060023D2 RID: 9170 RVA: 0x0000E898 File Offset: 0x0000CA98
	[Token(Token = "0x6001E18")]
	[Address(RVA = "0x1E74B80", Offset = "0x1E74C81", VA = "0x1E74B80", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x060023D3 RID: 9171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E19")]
	[Address(RVA = "0x1E74CA0", Offset = "0x1E74DA1", VA = "0x1E74CA0", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x060023D4 RID: 9172 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
	[Token(Token = "0x6001E1A")]
	[Address(RVA = "0x1E74CB0", Offset = "0x1E74DB1", VA = "0x1E74CB0", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x060023D5 RID: 9173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E1B")]
	[Address(RVA = "0x1E74CC0", Offset = "0x1E74DC1", VA = "0x1E74CC0")]
	public CalendarFurnitureController()
	{
	}

	// Token: 0x060023D6 RID: 9174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E1C")]
	[Address(RVA = "0x1E74CD0", Offset = "0x1E74DD1", VA = "0x1E74CD0", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x060023D7 RID: 9175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E1D")]
	[Address(RVA = "0x1E74CE0", Offset = "0x1E74DE1", VA = "0x1E74CE0", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}
}
