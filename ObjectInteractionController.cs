using System;
using Define;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200045A RID: 1114
[Token(Token = "0x2000357")]
public class ObjectInteractionController : MonoBehaviour, InteractionInterface, FocusInterface
{
	// Token: 0x06001AEC RID: 6892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F6")]
	[Address(RVA = "0x1F55E90", Offset = "0x1F55F91", VA = "0x1F55E90")]
	private void Start()
	{
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F7")]
	[Address(RVA = "0x1F55F30", Offset = "0x1F56031", VA = "0x1F55F30")]
	private void LoadAsset()
	{
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F8")]
	[Address(RVA = "0x1F560E0", Offset = "0x1F561E1", VA = "0x1F560E0")]
	public void SetNameID(string nameID)
	{
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F9")]
	[Address(RVA = "0x1F561B0", Offset = "0x1F562B1", VA = "0x1F561B0", Slot = "4")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x0000BC40 File Offset: 0x00009E40
	[Token(Token = "0x60017FA")]
	[Address(RVA = "0x1F563C0", Offset = "0x1F564C1", VA = "0x1F563C0", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017FB")]
	[Address(RVA = "0x1F565B0", Offset = "0x1F566B1", VA = "0x1F565B0", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017FC")]
	[Address(RVA = "0x1F56600", Offset = "0x1F56701", VA = "0x1F56600", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x0000BC58 File Offset: 0x00009E58
	[Token(Token = "0x60017FD")]
	[Address(RVA = "0x1F56630", Offset = "0x1F56731", VA = "0x1F56630")]
	public ObjectType GetObjectType()
	{
		return ObjectType.Object;
	}

	// Token: 0x1700046D RID: 1133
	// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x0000BC70 File Offset: 0x00009E70
	[Token(Token = "0x170003FB")]
	public bool Focusable
	{
		[Token(Token = "0x60017FE")]
		[Address(RVA = "0x1F56660", Offset = "0x1F56761", VA = "0x1F56660", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700046E RID: 1134
	// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x0000BC88 File Offset: 0x00009E88
	[Token(Token = "0x170003FC")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x60017FF")]
		[Address(RVA = "0x1F56860", Offset = "0x1F56961", VA = "0x1F56860", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x1700046F RID: 1135
	// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0000BCA0 File Offset: 0x00009EA0
	[Token(Token = "0x170003FD")]
	public int FocusPriority
	{
		[Token(Token = "0x6001800")]
		[Address(RVA = "0x1F56870", Offset = "0x1F56971", VA = "0x1F56870", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000470 RID: 1136
	// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x0000BCB8 File Offset: 0x00009EB8
	[Token(Token = "0x170003FE")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001801")]
		[Address(RVA = "0x1F56880", Offset = "0x1F56981", VA = "0x1F56880", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001802")]
	[Address(RVA = "0x1F56890", Offset = "0x1F56991", VA = "0x1F56890", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001803")]
	[Address(RVA = "0x1F568A0", Offset = "0x1F569A1", VA = "0x1F568A0", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x0000BCD0 File Offset: 0x00009ED0
	[Token(Token = "0x6001804")]
	[Address(RVA = "0x1F568B0", Offset = "0x1F569B1", VA = "0x1F568B0", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001805")]
	[Address(RVA = "0x1F568C0", Offset = "0x1F569C1", VA = "0x1F568C0", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x0000BCE8 File Offset: 0x00009EE8
	[Token(Token = "0x6001806")]
	[Address(RVA = "0x1F56A40", Offset = "0x1F56B41", VA = "0x1F56A40", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001807")]
	[Address(RVA = "0x1F56B60", Offset = "0x1F56C61", VA = "0x1F56B60")]
	public ObjectInteractionController()
	{
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001808")]
	[Address(RVA = "0x1F56B70", Offset = "0x1F56C71", VA = "0x1F56B70", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001809")]
	[Address(RVA = "0x1F56B80", Offset = "0x1F56C81", VA = "0x1F56B80", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x04005DED RID: 24045
	[Token(Token = "0x40059FC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string InteractionID;

	// Token: 0x04005DEE RID: 24046
	[Token(Token = "0x40059FD")]
	[FieldOffset(Offset = "0x20")]
	private FocusObjectDataTable Data;

	// Token: 0x04005DEF RID: 24047
	[Token(Token = "0x40059FE")]
	[FieldOffset(Offset = "0x38")]
	private string focusName;

	// Token: 0x04005DF0 RID: 24048
	[Token(Token = "0x40059FF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float InteractionAngle;

	// Token: 0x04005DF1 RID: 24049
	[Token(Token = "0x4005A00")]
	[FieldOffset(Offset = "0x44")]
	private ObjectType ObjectType;

	// Token: 0x04005DF2 RID: 24050
	[Token(Token = "0x4005A01")]
	[FieldOffset(Offset = "0x48")]
	private GameFlagData GameFlag;

	// Token: 0x04005DF3 RID: 24051
	[Token(Token = "0x4005A02")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private int _focusPriority;
}
