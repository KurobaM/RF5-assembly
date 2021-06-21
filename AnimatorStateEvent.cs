using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020000FE RID: 254
[Token(Token = "0x20000C9")]
[Serializable]
public abstract class AnimatorStateEvent<T> : StateMachineBehaviour where T : struct
{
	// Token: 0x06000582 RID: 1410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A7")]
	public void AddEvent(float normalizeTime, UnityAction action)
	{
	}

	// Token: 0x06000583 RID: 1411
	[Token(Token = "0x60004A8")]
	protected abstract bool IsNone(T value);

	// Token: 0x06000584 RID: 1412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A9")]
	private void EachNormalizeTimeEvent(Action<AnimatorStateEvent<T>.NormalizeTimeEvent> action)
	{
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AA")]
	private void CreateHash()
	{
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AB")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AC")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AD")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AE")]
	protected AnimatorStateEvent()
	{
	}

	// Token: 0x040002D1 RID: 721
	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public T AnimatorStateType;

	// Token: 0x040002D2 RID: 722
	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x0")]
	private List<AnimatorStateEvent<T>.NormalizeTimeEvent> NormalizeTimeEventList;

	// Token: 0x020000FF RID: 255
	[Token(Token = "0x2000FBF")]
	public class NormalizeTimeEvent
	{
		// Token: 0x0600058A RID: 1418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC6")]
		public NormalizeTimeEvent()
		{
		}

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x4018D17")]
		[FieldOffset(Offset = "0x0")]
		public bool isInvoke;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x4018D18")]
		[FieldOffset(Offset = "0x0")]
		public float NormalizeTime;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x4018D19")]
		[FieldOffset(Offset = "0x0")]
		public UnityEvent UnityEvent;
	}

	// Token: 0x02000100 RID: 256
	[Token(Token = "0x2000FC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1570E0", Offset = "0x1571E1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC8")]
		public <>c()
		{
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC9")]
		internal void <OnStateEnter>b__7_0(AnimatorStateEvent<T>.NormalizeTimeEvent normalizeTimeEvent)
		{
		}

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x4018D1A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AnimatorStateEvent<T>.<>c <>9;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x4018D1B")]
		[FieldOffset(Offset = "0x0")]
		public static Action<AnimatorStateEvent<T>.NormalizeTimeEvent> <>9__7_0;
	}

	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000FC1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1570F0", Offset = "0x1571F1")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x0600058E RID: 1422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BCA")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BCB")]
		internal void <OnStateUpdate>b__0(AnimatorStateEvent<T>.NormalizeTimeEvent normalizeTimeEvent)
		{
		}

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x4018D1C")]
		[FieldOffset(Offset = "0x0")]
		public AnimatorStateInfo stateInfo;
	}
}
