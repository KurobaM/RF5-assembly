using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000945 RID: 2373
[Token(Token = "0x2000637")]
public class NonFocusButton : MonoBehaviour
{
	// Token: 0x170008D7 RID: 2263
	// (get) Token: 0x06003EE4 RID: 16100 RVA: 0x000156C0 File Offset: 0x000138C0
	// (set) Token: 0x06003EE5 RID: 16101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000714")]
	public bool EnableButton
	{
		[Token(Token = "0x6003451")]
		[Address(RVA = "0x1E24580", Offset = "0x1E24681", VA = "0x1E24580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6E80", Offset = "0x1A6F81")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003452")]
		[Address(RVA = "0x1E24590", Offset = "0x1E24691", VA = "0x1E24590")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6E90", Offset = "0x1A6F91")]
		set
		{
		}
	}

	// Token: 0x06003EE6 RID: 16102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003453")]
	[Address(RVA = "0x1E245A0", Offset = "0x1E246A1", VA = "0x1E245A0")]
	private void Awake()
	{
	}

	// Token: 0x06003EE7 RID: 16103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003454")]
	[Address(RVA = "0x1E247E0", Offset = "0x1E248E1", VA = "0x1E247E0")]
	public void SetFirstEvent(UnityAction _action)
	{
	}

	// Token: 0x06003EE8 RID: 16104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003455")]
	[Address(RVA = "0x1E24870", Offset = "0x1E24971", VA = "0x1E24870")]
	public void SetEvent(UnityAction _action)
	{
	}

	// Token: 0x06003EE9 RID: 16105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003456")]
	[Address(RVA = "0x1E24900", Offset = "0x1E24A01", VA = "0x1E24900")]
	public void DoButton()
	{
	}

	// Token: 0x06003EEA RID: 16106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003457")]
	[Address(RVA = "0x1E249D0", Offset = "0x1E24AD1", VA = "0x1E249D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A6EA0", Offset = "0x1A6FA1")]
	private IEnumerator SwitchSprite()
	{
		return null;
	}

	// Token: 0x06003EEB RID: 16107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003458")]
	[Address(RVA = "0x1E24A80", Offset = "0x1E24B81", VA = "0x1E24A80")]
	public NonFocusButton()
	{
	}

	// Token: 0x06003EEC RID: 16108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003459")]
	[Address(RVA = "0x1E24B20", Offset = "0x1E24C21", VA = "0x1E24B20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6F10", Offset = "0x1A7011")]
	private void <Awake>b__14_0(BaseEventData _data)
	{
	}

	// Token: 0x04008074 RID: 32884
	[Token(Token = "0x40073BB")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F5C0", Offset = "0x16F6C1")]
	private bool <EnableButton>k__BackingField;

	// Token: 0x04008075 RID: 32885
	[Token(Token = "0x40073BC")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float animTime;

	// Token: 0x04008076 RID: 32886
	[Token(Token = "0x40073BD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float goalRate;

	// Token: 0x04008077 RID: 32887
	[Token(Token = "0x40073BE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image buttonImage;

	// Token: 0x04008078 RID: 32888
	[Token(Token = "0x40073BF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite buttonSprite;

	// Token: 0x04008079 RID: 32889
	[Token(Token = "0x40073C0")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite clickedSprite;

	// Token: 0x0400807A RID: 32890
	[Token(Token = "0x40073C1")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UnityEvent firstAction;

	// Token: 0x0400807B RID: 32891
	[Token(Token = "0x40073C2")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UnityEvent action;

	// Token: 0x0400807C RID: 32892
	[Token(Token = "0x40073C3")]
	[FieldOffset(Offset = "0x50")]
	private EventTrigger eventTrigger;

	// Token: 0x0400807D RID: 32893
	[Token(Token = "0x40073C4")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 startScale;

	// Token: 0x0400807E RID: 32894
	[Token(Token = "0x40073C5")]
	[FieldOffset(Offset = "0x60")]
	private Vector2 goalScale;

	// Token: 0x02000946 RID: 2374
	[Token(Token = "0x2001290")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158E70", Offset = "0x158F71")]
	private sealed class <SwitchSprite>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003EED RID: 16109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007577")]
		[Address(RVA = "0x1E24A50", Offset = "0x1E24B51", VA = "0x1E24A50")]
		[DebuggerHidden]
		public <SwitchSprite>d__18(int <>1__state)
		{
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007578")]
		[Address(RVA = "0x1E24B30", Offset = "0x1E24C31", VA = "0x1E24B30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x000156D8 File Offset: 0x000138D8
		[Token(Token = "0x6007579")]
		[Address(RVA = "0x1E24B40", Offset = "0x1E24C41", VA = "0x1E24B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06003EF0 RID: 16112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D80")]
		private object Current
		{
			[Token(Token = "0x600757A")]
			[Address(RVA = "0x1E24E90", Offset = "0x1E24F91", VA = "0x1E24E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600757B")]
		[Address(RVA = "0x1E24EA0", Offset = "0x1E24FA1", VA = "0x1E24EA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06003EF2 RID: 16114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D81")]
		private object Current
		{
			[Token(Token = "0x600757C")]
			[Address(RVA = "0x1E24F00", Offset = "0x1E25001", VA = "0x1E24F00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400807F RID: 32895
		[Token(Token = "0x401991C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04008080 RID: 32896
		[Token(Token = "0x401991D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04008081 RID: 32897
		[Token(Token = "0x401991E")]
		[FieldOffset(Offset = "0x20")]
		public NonFocusButton <>4__this;

		// Token: 0x04008082 RID: 32898
		[Token(Token = "0x401991F")]
		[FieldOffset(Offset = "0x28")]
		private float <timeCount>5__2;
	}
}
