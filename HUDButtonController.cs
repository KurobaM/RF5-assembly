using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000998 RID: 2456
[Token(Token = "0x2000673")]
public class HUDButtonController : MonoBehaviour
{
	// Token: 0x0600403E RID: 16446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600358F")]
	[Address(RVA = "0x20427D0", Offset = "0x20428D1", VA = "0x20427D0")]
	private void Awake()
	{
	}

	// Token: 0x0600403F RID: 16447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003590")]
	[Address(RVA = "0x20428E0", Offset = "0x20429E1", VA = "0x20428E0")]
	public void AddEvent(EventTriggerType _type, UnityAction _action)
	{
	}

	// Token: 0x06004040 RID: 16448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003591")]
	[Address(RVA = "0x2042A30", Offset = "0x2042B31", VA = "0x2042A30")]
	private void OnClick(UnityAction _action)
	{
	}

	// Token: 0x06004041 RID: 16449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003592")]
	[Address(RVA = "0x2042AD0", Offset = "0x2042BD1", VA = "0x2042AD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A7290", Offset = "0x1A7391")]
	private IEnumerator InvokeAction(UnityAction _action)
	{
		return null;
	}

	// Token: 0x06004042 RID: 16450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003593")]
	[Address(RVA = "0x2042BA0", Offset = "0x2042CA1", VA = "0x2042BA0")]
	public HUDButtonController()
	{
	}

	// Token: 0x04009EA5 RID: 40613
	[Token(Token = "0x40077A3")]
	[FieldOffset(Offset = "0x18")]
	private Image buttonImage;

	// Token: 0x04009EA6 RID: 40614
	[Token(Token = "0x40077A4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite buttonSprite;

	// Token: 0x04009EA7 RID: 40615
	[Token(Token = "0x40077A5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite clickedSprite;

	// Token: 0x04009EA8 RID: 40616
	[Token(Token = "0x40077A6")]
	[FieldOffset(Offset = "0x30")]
	private EventTrigger eventTrigger;

	// Token: 0x02000999 RID: 2457
	[Token(Token = "0x20012A7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158EB0", Offset = "0x158FB1")]
	private sealed class <>c__DisplayClass5_0
	{
		// Token: 0x06004043 RID: 16451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007593")]
		[Address(RVA = "0x2042A20", Offset = "0x2042B21", VA = "0x2042A20")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007594")]
		[Address(RVA = "0x2042BB0", Offset = "0x2042CB1", VA = "0x2042BB0")]
		internal void <AddEvent>b__0(BaseEventData _data)
		{
		}

		// Token: 0x04009EA9 RID: 40617
		[Token(Token = "0x401B365")]
		[FieldOffset(Offset = "0x10")]
		public HUDButtonController <>4__this;

		// Token: 0x04009EAA RID: 40618
		[Token(Token = "0x401B366")]
		[FieldOffset(Offset = "0x18")]
		public UnityAction _action;
	}

	// Token: 0x0200099A RID: 2458
	[Token(Token = "0x20012A8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158EC0", Offset = "0x158FC1")]
	private sealed class <InvokeAction>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004045 RID: 16453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007595")]
		[Address(RVA = "0x2042B70", Offset = "0x2042C71", VA = "0x2042B70")]
		[DebuggerHidden]
		public <InvokeAction>d__7(int <>1__state)
		{
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007596")]
		[Address(RVA = "0x2042BD0", Offset = "0x2042CD1", VA = "0x2042BD0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x00015C00 File Offset: 0x00013E00
		[Token(Token = "0x6007597")]
		[Address(RVA = "0x2042BE0", Offset = "0x2042CE1", VA = "0x2042BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06004048 RID: 16456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D87")]
		private object Current
		{
			[Token(Token = "0x6007598")]
			[Address(RVA = "0x2042D10", Offset = "0x2042E11", VA = "0x2042D10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007599")]
		[Address(RVA = "0x2042D20", Offset = "0x2042E21", VA = "0x2042D20", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D88")]
		private object Current
		{
			[Token(Token = "0x600759A")]
			[Address(RVA = "0x2042D80", Offset = "0x2042E81", VA = "0x2042D80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04009EAB RID: 40619
		[Token(Token = "0x401B367")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04009EAC RID: 40620
		[Token(Token = "0x401B368")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04009EAD RID: 40621
		[Token(Token = "0x401B369")]
		[FieldOffset(Offset = "0x20")]
		public HUDButtonController <>4__this;

		// Token: 0x04009EAE RID: 40622
		[Token(Token = "0x401B36A")]
		[FieldOffset(Offset = "0x28")]
		public UnityAction _action;
	}
}
