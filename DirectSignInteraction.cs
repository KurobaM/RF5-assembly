using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A5B RID: 2651
[Token(Token = "0x20006F6")]
public class DirectSignInteraction : MonoBehaviour, InteractionInterface, FocusInterface
{
	// Token: 0x17000960 RID: 2400
	// (get) Token: 0x06004542 RID: 17730 RVA: 0x00016F68 File Offset: 0x00015168
	[Token(Token = "0x17000788")]
	public bool Focusable
	{
		[Token(Token = "0x60039F8")]
		[Address(RVA = "0x1DFC2E0", Offset = "0x1DFC3E1", VA = "0x1DFC2E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000961 RID: 2401
	// (get) Token: 0x06004543 RID: 17731 RVA: 0x00016F80 File Offset: 0x00015180
	[Token(Token = "0x17000789")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x60039F9")]
		[Address(RVA = "0x1DFC480", Offset = "0x1DFC581", VA = "0x1DFC480", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x17000962 RID: 2402
	// (get) Token: 0x06004544 RID: 17732 RVA: 0x00016F98 File Offset: 0x00015198
	[Token(Token = "0x1700078A")]
	public int FocusPriority
	{
		[Token(Token = "0x60039FA")]
		[Address(RVA = "0x1DFC490", Offset = "0x1DFC591", VA = "0x1DFC490", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000963 RID: 2403
	// (get) Token: 0x06004545 RID: 17733 RVA: 0x00016FB0 File Offset: 0x000151B0
	[Token(Token = "0x1700078B")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x60039FB")]
		[Address(RVA = "0x1DFC4A0", Offset = "0x1DFC5A1", VA = "0x1DFC4A0", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x06004546 RID: 17734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039FC")]
	[Address(RVA = "0x1DFC4B0", Offset = "0x1DFC5B1", VA = "0x1DFC4B0", Slot = "4")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06004547 RID: 17735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60039FD")]
	[Address(RVA = "0x1DFC5D0", Offset = "0x1DFC6D1", VA = "0x1DFC5D0", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x06004548 RID: 17736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60039FE")]
	[Address(RVA = "0x1DFC6C0", Offset = "0x1DFC7C1", VA = "0x1DFC6C0", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06004549 RID: 17737 RVA: 0x00016FC8 File Offset: 0x000151C8
	[Token(Token = "0x60039FF")]
	[Address(RVA = "0x1DFC710", Offset = "0x1DFC811", VA = "0x1DFC710", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x0600454A RID: 17738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A00")]
	[Address(RVA = "0x1DFC720", Offset = "0x1DFC821", VA = "0x1DFC720", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x0600454B RID: 17739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A01")]
	[Address(RVA = "0x1DFC730", Offset = "0x1DFC831", VA = "0x1DFC730", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x0600454C RID: 17740 RVA: 0x00016FE0 File Offset: 0x000151E0
	[Token(Token = "0x6003A02")]
	[Address(RVA = "0x1DFC740", Offset = "0x1DFC841", VA = "0x1DFC740", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x0600454D RID: 17741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A03")]
	[Address(RVA = "0x1DFC850", Offset = "0x1DFC951", VA = "0x1DFC850", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x0600454E RID: 17742 RVA: 0x00016FF8 File Offset: 0x000151F8
	[Token(Token = "0x6003A04")]
	[Address(RVA = "0x1DFC860", Offset = "0x1DFC961", VA = "0x1DFC860", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x0600454F RID: 17743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A05")]
	[Address(RVA = "0x1DFC870", Offset = "0x1DFC971", VA = "0x1DFC870")]
	public DirectSignInteraction()
	{
	}

	// Token: 0x06004550 RID: 17744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003A06")]
	[Address(RVA = "0x1DFC890", Offset = "0x1DFC991", VA = "0x1DFC890", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x06004551 RID: 17745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003A07")]
	[Address(RVA = "0x1DFC8A0", Offset = "0x1DFC9A1", VA = "0x1DFC8A0", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x0400A429 RID: 42025
	[Token(Token = "0x4007C1E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int SignNo;

	// Token: 0x0400A42A RID: 42026
	[Token(Token = "0x4007C1F")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float InteractionAngle;
}
