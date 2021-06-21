using System;
using System.Text;
using Il2CppDummyDll;
using nn.hid;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200060E RID: 1550
[Token(Token = "0x200045C")]
public class InputCursor : SingletonMonoBehaviour<InputCursor>
{
	// Token: 0x1700062C RID: 1580
	// (get) Token: 0x06002658 RID: 9816 RVA: 0x0000F210 File Offset: 0x0000D410
	// (set) Token: 0x06002659 RID: 9817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004EA")]
	public global::TouchState state
	{
		[Token(Token = "0x600205C")]
		[Address(RVA = "0x2230850", Offset = "0x2230951", VA = "0x2230850")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1AE0", Offset = "0x1A1BE1")]
		get
		{
			return global::TouchState.FREE;
		}
		[Token(Token = "0x600205D")]
		[Address(RVA = "0x2230860", Offset = "0x2230961", VA = "0x2230860")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1AF0", Offset = "0x1A1BF1")]
		private set
		{
		}
	}

	// Token: 0x1700062D RID: 1581
	// (get) Token: 0x0600265A RID: 9818 RVA: 0x0000F228 File Offset: 0x0000D428
	[Token(Token = "0x170004EB")]
	public bool IsTouching
	{
		[Token(Token = "0x600205E")]
		[Address(RVA = "0x2230870", Offset = "0x2230971", VA = "0x2230870")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600265B RID: 9819 RVA: 0x0000F240 File Offset: 0x0000D440
	[Token(Token = "0x600205F")]
	[Address(RVA = "0x2230880", Offset = "0x2230981", VA = "0x2230880")]
	public Vector3 GetTouchPos()
	{
		return default(Vector3);
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002060")]
	[Address(RVA = "0x22309A0", Offset = "0x2230AA1", VA = "0x22309A0")]
	private void UpdateState()
	{
	}

	// Token: 0x0600265D RID: 9821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002061")]
	[Address(RVA = "0x2230C30", Offset = "0x2230D31", VA = "0x2230C30", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002062")]
	[Address(RVA = "0x2230C80", Offset = "0x2230D81", VA = "0x2230C80")]
	private void Update()
	{
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002063")]
	[Address(RVA = "0x2230CB0", Offset = "0x2230DB1", VA = "0x2230CB0")]
	private void Start()
	{
	}

	// Token: 0x06002660 RID: 9824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002064")]
	[Address(RVA = "0x2230CE0", Offset = "0x2230DE1", VA = "0x2230CE0")]
	public InputCursor()
	{
	}

	// Token: 0x04006D89 RID: 28041
	[Token(Token = "0x4006689")]
	[FieldOffset(Offset = "0x18")]
	private Text textComponent;

	// Token: 0x04006D8A RID: 28042
	[Token(Token = "0x400668A")]
	[FieldOffset(Offset = "0x20")]
	private StringBuilder stringBuilder;

	// Token: 0x04006D8B RID: 28043
	[Token(Token = "0x400668B")]
	[FieldOffset(Offset = "0x28")]
	private TouchScreenState1 touchScreenState;

	// Token: 0x04006D8C RID: 28044
	[Token(Token = "0x400668C")]
	[FieldOffset(Offset = "0x60")]
	private float Moved;

	// Token: 0x04006D8D RID: 28045
	[Token(Token = "0x400668D")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 touchedPos;

	// Token: 0x04006D8E RID: 28046
	[Token(Token = "0x400668E")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1682F0", Offset = "0x1683F1")]
	private global::TouchState <state>k__BackingField;
}
