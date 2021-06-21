using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020009E7 RID: 2535
[Token(Token = "0x20006A3")]
public class UITouchButton : MonoBehaviour
{
	// Token: 0x06004276 RID: 17014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003791")]
	[Address(RVA = "0x2123830", Offset = "0x2123931", VA = "0x2123830", Slot = "4")]
	protected virtual void OnTouch()
	{
	}

	// Token: 0x06004277 RID: 17015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003792")]
	[Address(RVA = "0x2123840", Offset = "0x2123941", VA = "0x2123840")]
	private void Touch()
	{
	}

	// Token: 0x06004278 RID: 17016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003793")]
	[Address(RVA = "0x2123980", Offset = "0x2123A81", VA = "0x2123980")]
	private void Start()
	{
	}

	// Token: 0x06004279 RID: 17017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003794")]
	[Address(RVA = "0x2123AD0", Offset = "0x2123BD1", VA = "0x2123AD0")]
	public UITouchButton()
	{
	}

	// Token: 0x0600427A RID: 17018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003795")]
	[Address(RVA = "0x2123AE0", Offset = "0x2123BE1", VA = "0x2123AE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A75D0", Offset = "0x1A76D1")]
	private void <Start>b__5_0(BaseEventData x)
	{
	}

	// Token: 0x0400A119 RID: 41241
	[Token(Token = "0x4007993")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool TouchSelector;

	// Token: 0x0400A11A RID: 41242
	[Token(Token = "0x4007994")]
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool SubmitOnTouch;

	// Token: 0x0400A11B RID: 41243
	[Token(Token = "0x4007995")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private INPUTLAYER inputLayer;
}
