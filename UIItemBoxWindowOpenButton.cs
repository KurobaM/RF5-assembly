using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000A6E RID: 2670
[Token(Token = "0x2000702")]
public class UIItemBoxWindowOpenButton : MonoBehaviour
{
	// Token: 0x060045AE RID: 17838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A51")]
	[Address(RVA = "0x2013BC0", Offset = "0x2013CC1", VA = "0x2013BC0")]
	private void DoWork()
	{
	}

	// Token: 0x060045AF RID: 17839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A52")]
	[Address(RVA = "0x2011F40", Offset = "0x2012041", VA = "0x2011F40")]
	public void DoOpen()
	{
	}

	// Token: 0x060045B0 RID: 17840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A53")]
	[Address(RVA = "0x2012020", Offset = "0x2012121", VA = "0x2012020")]
	public void DoClose()
	{
	}

	// Token: 0x060045B1 RID: 17841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003A54")]
	[Address(RVA = "0x2013C00", Offset = "0x2013D01", VA = "0x2013C00")]
	private UIItemBoxMenu CheckUIItemBoxMenu(Transform objTransform)
	{
		return null;
	}

	// Token: 0x060045B2 RID: 17842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A55")]
	[Address(RVA = "0x2013D10", Offset = "0x2013E11", VA = "0x2013D10")]
	private void Awake()
	{
	}

	// Token: 0x060045B3 RID: 17843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A56")]
	[Address(RVA = "0x2013F60", Offset = "0x2014061", VA = "0x2013F60")]
	public UIItemBoxWindowOpenButton()
	{
	}

	// Token: 0x060045B4 RID: 17844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A57")]
	[Address(RVA = "0x2013F70", Offset = "0x2014071", VA = "0x2013F70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7C30", Offset = "0x1A7D31")]
	private void <Awake>b__9_0(BaseEventData x)
	{
	}

	// Token: 0x0400A485 RID: 42117
	[Token(Token = "0x4007C67")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIItemBoxMenu UIItemBoxMenu;

	// Token: 0x0400A486 RID: 42118
	[Token(Token = "0x4007C68")]
	[FieldOffset(Offset = "0x20")]
	public StorageType StorageType;

	// Token: 0x0400A487 RID: 42119
	[Token(Token = "0x4007C69")]
	[FieldOffset(Offset = "0x28")]
	private Image Image;

	// Token: 0x0400A488 RID: 42120
	[Token(Token = "0x4007C6A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite OnSprite;

	// Token: 0x0400A489 RID: 42121
	[Token(Token = "0x4007C6B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite OffSprite;
}
