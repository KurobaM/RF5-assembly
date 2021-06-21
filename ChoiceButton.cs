using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200093D RID: 2365
[Token(Token = "0x2000631")]
public class ChoiceButton : MonoBehaviour
{
	// Token: 0x170008CA RID: 2250
	// (get) Token: 0x06003E84 RID: 16004 RVA: 0x00015540 File Offset: 0x00013740
	// (set) Token: 0x06003E85 RID: 16005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000709")]
	public bool IsButtonActive
	{
		[Token(Token = "0x60033F7")]
		[Address(RVA = "0x1EA0950", Offset = "0x1EA0A51", VA = "0x1EA0950")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6D20", Offset = "0x1A6E21")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60033F8")]
		[Address(RVA = "0x1EA0960", Offset = "0x1EA0A61", VA = "0x1EA0960")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6D30", Offset = "0x1A6E31")]
		set
		{
		}
	}

	// Token: 0x170008CB RID: 2251
	// (get) Token: 0x06003E86 RID: 16006 RVA: 0x00015558 File Offset: 0x00013758
	// (set) Token: 0x06003E87 RID: 16007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700070A")]
	private protected bool isClicked
	{
		[Token(Token = "0x60033F9")]
		[Address(RVA = "0x1EA0970", Offset = "0x1EA0A71", VA = "0x1EA0970")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6D40", Offset = "0x1A6E41")]
		protected get
		{
			return default(bool);
		}
		[Token(Token = "0x60033FA")]
		[Address(RVA = "0x1EA0980", Offset = "0x1EA0A81", VA = "0x1EA0980")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6D50", Offset = "0x1A6E51")]
		private set
		{
		}
	}

	// Token: 0x06003E88 RID: 16008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033FB")]
	[Address(RVA = "0x1EA0990", Offset = "0x1EA0A91", VA = "0x1EA0990")]
	private void Awake()
	{
	}

	// Token: 0x06003E89 RID: 16009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033FC")]
	[Address(RVA = "0x1EA0B20", Offset = "0x1EA0C21", VA = "0x1EA0B20")]
	private void Update()
	{
	}

	// Token: 0x06003E8A RID: 16010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033FD")]
	[Address(RVA = "0x1EA0EE0", Offset = "0x1EA0FE1", VA = "0x1EA0EE0")]
	public void SetEvent(UnityAction _action)
	{
	}

	// Token: 0x06003E8B RID: 16011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033FE")]
	[Address(RVA = "0x1EA0F70", Offset = "0x1EA1071", VA = "0x1EA0F70")]
	public void SetFirstEvent(UnityAction _action)
	{
	}

	// Token: 0x06003E8C RID: 16012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033FF")]
	[Address(RVA = "0x1EA0F80", Offset = "0x1EA1081", VA = "0x1EA0F80", Slot = "4")]
	public virtual void DoButton()
	{
	}

	// Token: 0x06003E8D RID: 16013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003400")]
	[Address(RVA = "0x1EA1020", Offset = "0x1EA1121", VA = "0x1EA1020")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A6D60", Offset = "0x1A6E61")]
	protected IEnumerator PlayButtonAnim()
	{
		return null;
	}

	// Token: 0x06003E8E RID: 16014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003401")]
	[Address(RVA = "0x1EA10D0", Offset = "0x1EA11D1", VA = "0x1EA10D0")]
	public ChoiceButton()
	{
	}

	// Token: 0x06003E8F RID: 16015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003402")]
	[Address(RVA = "0x1EA10F0", Offset = "0x1EA11F1", VA = "0x1EA10F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6DD0", Offset = "0x1A6ED1")]
	private void <Awake>b__20_0(BaseEventData _data)
	{
	}

	// Token: 0x0400803A RID: 32826
	[Token(Token = "0x400738E")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F440", Offset = "0x16F541")]
	private bool <IsButtonActive>k__BackingField;

	// Token: 0x0400803B RID: 32827
	[Token(Token = "0x400738F")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float animTime;

	// Token: 0x0400803C RID: 32828
	[Token(Token = "0x4007390")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationCurve scaleCurve;

	// Token: 0x0400803D RID: 32829
	[Token(Token = "0x4007391")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationCurve fadeCurve;

	// Token: 0x0400803E RID: 32830
	[Token(Token = "0x4007392")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image focusedImage;

	// Token: 0x0400803F RID: 32831
	[Token(Token = "0x4007393")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UnityEvent action;

	// Token: 0x04008040 RID: 32832
	[Token(Token = "0x4007394")]
	[FieldOffset(Offset = "0x40")]
	private UnityAction firstAction;

	// Token: 0x04008041 RID: 32833
	[Token(Token = "0x4007395")]
	[FieldOffset(Offset = "0x48")]
	private EventTrigger eventTrigger;

	// Token: 0x04008042 RID: 32834
	[Token(Token = "0x4007396")]
	[FieldOffset(Offset = "0x50")]
	private float curveRate;

	// Token: 0x04008043 RID: 32835
	[Token(Token = "0x4007397")]
	[FieldOffset(Offset = "0x54")]
	private float curveSpeed;

	// Token: 0x04008044 RID: 32836
	[Token(Token = "0x4007398")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F4A0", Offset = "0x16F5A1")]
	private bool <isClicked>k__BackingField;

	// Token: 0x04008045 RID: 32837
	[Token(Token = "0x4007399")]
	[FieldOffset(Offset = "0x59")]
	private bool isFocusing;

	// Token: 0x04008046 RID: 32838
	[Token(Token = "0x400739A")]
	[FieldOffset(Offset = "0x5C")]
	private float timeCount;

	// Token: 0x04008047 RID: 32839
	[Token(Token = "0x400739B")]
	[FieldOffset(Offset = "0x60")]
	private int loopRate;

	// Token: 0x0200093E RID: 2366
	[Token(Token = "0x200128E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158E60", Offset = "0x158F61")]
	private sealed class <PlayButtonAnim>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003E90 RID: 16016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007571")]
		[Address(RVA = "0x1EA10A0", Offset = "0x1EA11A1", VA = "0x1EA10A0")]
		[DebuggerHidden]
		public <PlayButtonAnim>d__25(int <>1__state)
		{
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007572")]
		[Address(RVA = "0x1EA1100", Offset = "0x1EA1201", VA = "0x1EA1100", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x00015570 File Offset: 0x00013770
		[Token(Token = "0x6007573")]
		[Address(RVA = "0x1EA1110", Offset = "0x1EA1211", VA = "0x1EA1110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06003E93 RID: 16019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7E")]
		private object Current
		{
			[Token(Token = "0x6007574")]
			[Address(RVA = "0x1EA1440", Offset = "0x1EA1541", VA = "0x1EA1440", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007575")]
		[Address(RVA = "0x1EA1450", Offset = "0x1EA1551", VA = "0x1EA1450", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06003E95 RID: 16021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7F")]
		private object Current
		{
			[Token(Token = "0x6007576")]
			[Address(RVA = "0x1EA14B0", Offset = "0x1EA15B1", VA = "0x1EA14B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04008048 RID: 32840
		[Token(Token = "0x401990F")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04008049 RID: 32841
		[Token(Token = "0x4019910")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400804A RID: 32842
		[Token(Token = "0x4019911")]
		[FieldOffset(Offset = "0x20")]
		public ChoiceButton <>4__this;

		// Token: 0x0400804B RID: 32843
		[Token(Token = "0x4019912")]
		[FieldOffset(Offset = "0x28")]
		private GameObject <obj>5__2;

		// Token: 0x0400804C RID: 32844
		[Token(Token = "0x4019913")]
		[FieldOffset(Offset = "0x30")]
		private Image <image>5__3;

		// Token: 0x0400804D RID: 32845
		[Token(Token = "0x4019914")]
		[FieldOffset(Offset = "0x38")]
		private float <timeCount>5__4;

		// Token: 0x0400804E RID: 32846
		[Token(Token = "0x4019915")]
		[FieldOffset(Offset = "0x3C")]
		private Color <color>5__5;
	}
}
