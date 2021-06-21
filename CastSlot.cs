using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000AF2 RID: 2802
[Token(Token = "0x2000751")]
public class CastSlot : UIButtonLinkerInScrollBox
{
	// Token: 0x060048A7 RID: 18599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CD2")]
	[Address(RVA = "0x1E7D300", Offset = "0x1E7D401", VA = "0x1E7D300", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x060048A8 RID: 18600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CD3")]
	[Address(RVA = "0x1E7D390", Offset = "0x1E7D491", VA = "0x1E7D390", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060048A9 RID: 18601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CD4")]
	[Address(RVA = "0x1E7D4B0", Offset = "0x1E7D5B1", VA = "0x1E7D4B0")]
	private new void OnTouch()
	{
	}

	// Token: 0x060048AA RID: 18602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CD5")]
	[Address(RVA = "0x1E7D4D0", Offset = "0x1E7D5D1", VA = "0x1E7D4D0", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x060048AB RID: 18603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CD6")]
	[Address(RVA = "0x1E7D530", Offset = "0x1E7D631", VA = "0x1E7D530", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x060048AC RID: 18604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CD7")]
	[Address(RVA = "0x1E7D590", Offset = "0x1E7D691", VA = "0x1E7D590")]
	public void Setup(int _index)
	{
	}

	// Token: 0x060048AD RID: 18605 RVA: 0x00017940 File Offset: 0x00015B40
	[Token(Token = "0x6003CD8")]
	[Address(RVA = "0x1E7D890", Offset = "0x1E7D991", VA = "0x1E7D890", Slot = "12")]
	protected override bool CanUpdateCursor()
	{
		return default(bool);
	}

	// Token: 0x060048AE RID: 18606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CD9")]
	[Address(RVA = "0x1E7D8A0", Offset = "0x1E7D9A1", VA = "0x1E7D8A0", Slot = "13")]
	protected override void InitInputLayer()
	{
	}

	// Token: 0x060048AF RID: 18607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CDA")]
	[Address(RVA = "0x1E7D8B0", Offset = "0x1E7D9B1", VA = "0x1E7D8B0", Slot = "14")]
	protected override void ClearInputLayer()
	{
	}

	// Token: 0x060048B0 RID: 18608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CDB")]
	[Address(RVA = "0x1E7D8C0", Offset = "0x1E7D9C1", VA = "0x1E7D8C0")]
	public CastSlot()
	{
	}

	// Token: 0x060048B1 RID: 18609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CDC")]
	[Address(RVA = "0x1E7D930", Offset = "0x1E7DA31", VA = "0x1E7D930")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8500", Offset = "0x1A8601")]
	private void <Awake>b__6_0(BaseEventData _data)
	{
	}

	// Token: 0x0400A89D RID: 43165
	[Token(Token = "0x4007F22")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Sprite[] onOffSprite;

	// Token: 0x0400A89E RID: 43166
	[Token(Token = "0x4007F23")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image castTextBorder;

	// Token: 0x0400A89F RID: 43167
	[Token(Token = "0x4007F24")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text castText;

	// Token: 0x0400A8A0 RID: 43168
	[Token(Token = "0x4007F25")]
	[FieldOffset(Offset = "0x88")]
	private VoiceComment voiceComment;

	// Token: 0x02000AF3 RID: 2803
	[Token(Token = "0x2001323")]
	public enum OnOff
	{
		// Token: 0x0400A8A2 RID: 43170
		[Token(Token = "0x401B5DF")]
		On,
		// Token: 0x0400A8A3 RID: 43171
		[Token(Token = "0x401B5E0")]
		Off,
		// Token: 0x0400A8A4 RID: 43172
		[Token(Token = "0x401B5E1")]
		Max
	}
}
