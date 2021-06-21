using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AE9 RID: 2793
[Token(Token = "0x200074C")]
public class TitleChoiceButton : ChoiceButton
{
	// Token: 0x06004881 RID: 18561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CB8")]
	[Address(RVA = "0x2071560", Offset = "0x2071661", VA = "0x2071560", Slot = "4")]
	public override void DoButton()
	{
	}

	// Token: 0x06004882 RID: 18562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003CB9")]
	[Address(RVA = "0x2071630", Offset = "0x2071731", VA = "0x2071630")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A83F0", Offset = "0x1A84F1")]
	private IEnumerator Scaling()
	{
		return null;
	}

	// Token: 0x06004883 RID: 18563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CBA")]
	[Address(RVA = "0x20716E0", Offset = "0x20717E1", VA = "0x20716E0")]
	public TitleChoiceButton()
	{
	}

	// Token: 0x0400A864 RID: 43108
	[Token(Token = "0x4007EFF")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Image buttonImage;

	// Token: 0x0400A865 RID: 43109
	[Token(Token = "0x4007F00")]
	[FieldOffset(Offset = "0x70")]
	private readonly float ANIM_TIME;

	// Token: 0x0400A866 RID: 43110
	[Token(Token = "0x4007F01")]
	[FieldOffset(Offset = "0x74")]
	private readonly Vector2 START_SCALE;

	// Token: 0x0400A867 RID: 43111
	[Token(Token = "0x4007F02")]
	[FieldOffset(Offset = "0x7C")]
	private readonly Vector2 GOAL_SCALE;

	// Token: 0x0400A868 RID: 43112
	[Token(Token = "0x4007F03")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private TitleCanvasControl titleControl;

	// Token: 0x02000AEA RID: 2794
	[Token(Token = "0x200131F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1592F0", Offset = "0x1593F1")]
	private sealed class <Scaling>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004884 RID: 18564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AD")]
		[Address(RVA = "0x20716B0", Offset = "0x20717B1", VA = "0x20716B0")]
		[DebuggerHidden]
		public <Scaling>d__6(int <>1__state)
		{
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AE")]
		[Address(RVA = "0x2071760", Offset = "0x2071861", VA = "0x2071760", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x000178E0 File Offset: 0x00015AE0
		[Token(Token = "0x60076AF")]
		[Address(RVA = "0x2071770", Offset = "0x2071871", VA = "0x2071770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06004887 RID: 18567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA7")]
		private object Current
		{
			[Token(Token = "0x60076B0")]
			[Address(RVA = "0x20719F0", Offset = "0x2071AF1", VA = "0x20719F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076B1")]
		[Address(RVA = "0x2071A00", Offset = "0x2071B01", VA = "0x2071A00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06004889 RID: 18569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA8")]
		private object Current
		{
			[Token(Token = "0x60076B2")]
			[Address(RVA = "0x2071A60", Offset = "0x2071B61", VA = "0x2071A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A869 RID: 43113
		[Token(Token = "0x401B5C8")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A86A RID: 43114
		[Token(Token = "0x401B5C9")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A86B RID: 43115
		[Token(Token = "0x401B5CA")]
		[FieldOffset(Offset = "0x20")]
		public TitleChoiceButton <>4__this;

		// Token: 0x0400A86C RID: 43116
		[Token(Token = "0x401B5CB")]
		[FieldOffset(Offset = "0x28")]
		private float <timeCount>5__2;
	}
}
