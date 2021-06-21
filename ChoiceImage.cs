using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000A9F RID: 2719
[Token(Token = "0x2000721")]
public class ChoiceImage : MonoBehaviour
{
	// Token: 0x17000978 RID: 2424
	// (get) Token: 0x060046B5 RID: 18101 RVA: 0x00017328 File Offset: 0x00015528
	// (set) Token: 0x060046B6 RID: 18102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700079A")]
	public bool IsSelected
	{
		[Token(Token = "0x6003B39")]
		[Address(RVA = "0x1EA14C0", Offset = "0x1EA15C1", VA = "0x1EA14C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7F00", Offset = "0x1A8001")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x1EA14D0", Offset = "0x1EA15D1", VA = "0x1EA14D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7F10", Offset = "0x1A8011")]
		private set
		{
		}
	}

	// Token: 0x17000979 RID: 2425
	// (get) Token: 0x060046B7 RID: 18103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700079B")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x1EA14E0", Offset = "0x1EA15E1", VA = "0x1EA14E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060046B8 RID: 18104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B3C")]
	[Address(RVA = "0x1EA1540", Offset = "0x1EA1641", VA = "0x1EA1540")]
	private void Awake()
	{
	}

	// Token: 0x060046B9 RID: 18105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B3D")]
	[Address(RVA = "0x1EA1660", Offset = "0x1EA1761", VA = "0x1EA1660")]
	public void SetEvent(UnityAction _action)
	{
	}

	// Token: 0x060046BA RID: 18106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B3E")]
	[Address(RVA = "0x1EA1670", Offset = "0x1EA1771", VA = "0x1EA1670")]
	private void OnTouch()
	{
	}

	// Token: 0x060046BB RID: 18107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B3F")]
	[Address(RVA = "0x1EA1690", Offset = "0x1EA1791", VA = "0x1EA1690")]
	public void SetOnSelect(bool select)
	{
	}

	// Token: 0x060046BC RID: 18108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B40")]
	[Address(RVA = "0x1EA17F0", Offset = "0x1EA18F1", VA = "0x1EA17F0")]
	public void Finish()
	{
	}

	// Token: 0x060046BD RID: 18109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B41")]
	[Address(RVA = "0x1EA1800", Offset = "0x1EA1901", VA = "0x1EA1800")]
	public void SetDetail(string text, [Optional] string text2)
	{
	}

	// Token: 0x060046BE RID: 18110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B42")]
	[Address(RVA = "0x1EA1940", Offset = "0x1EA1A41", VA = "0x1EA1940")]
	public ChoiceImage()
	{
	}

	// Token: 0x060046BF RID: 18111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B43")]
	[Address(RVA = "0x1EA1950", Offset = "0x1EA1A51", VA = "0x1EA1950")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7F20", Offset = "0x1A8021")]
	private void <Awake>b__13_0(BaseEventData _data)
	{
	}

	// Token: 0x0400A5A3 RID: 42403
	[Token(Token = "0x4007D24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text contentText;

	// Token: 0x0400A5A4 RID: 42404
	[Token(Token = "0x4007D25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text ptText;

	// Token: 0x0400A5A5 RID: 42405
	[Token(Token = "0x4007D26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image selectedImage;

	// Token: 0x0400A5A6 RID: 42406
	[Token(Token = "0x4007D27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text selectedContentText;

	// Token: 0x0400A5A7 RID: 42407
	[Token(Token = "0x4007D28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text selectedPtText;

	// Token: 0x0400A5A8 RID: 42408
	[Token(Token = "0x4007D29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image finishImage;

	// Token: 0x0400A5A9 RID: 42409
	[Token(Token = "0x4007D2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1733A0", Offset = "0x1734A1")]
	private bool <IsSelected>k__BackingField;

	// Token: 0x0400A5AA RID: 42410
	[Token(Token = "0x4007D2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private UnityAction touchAction;
}
