using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200031B RID: 795
[Token(Token = "0x2000257")]
public class StateMachine<T> : IStateMachine where T : struct
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06001517 RID: 5399 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06001518 RID: 5400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000001")]
	public event Action<T> Changed
	{
		[Token(Token = "0x60012DB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D0E0", Offset = "0x19D1E1")]
		add
		{
		}
		[Token(Token = "0x60012DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D0F0", Offset = "0x19D1F1")]
		remove
		{
		}
	}

	// Token: 0x170003B8 RID: 952
	// (get) Token: 0x06001519 RID: 5401 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600151A RID: 5402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700036A")]
	public StateElement CurrentState
	{
		[Token(Token = "0x60012DD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D100", Offset = "0x19D201")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012DE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D110", Offset = "0x19D211")]
		private set
		{
		}
	}

	// Token: 0x170003B9 RID: 953
	// (get) Token: 0x0600151B RID: 5403 RVA: 0x00009420 File Offset: 0x00007620
	// (set) Token: 0x0600151C RID: 5404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700036B")]
	public bool IsInTransition
	{
		[Token(Token = "0x60012DF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D120", Offset = "0x19D221")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D130", Offset = "0x19D231")]
		private set
		{
		}
	}

	// Token: 0x170003BA RID: 954
	// (get) Token: 0x0600151D RID: 5405 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600151E RID: 5406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700036C")]
	public StateMachineWorker Worker
	{
		[Token(Token = "0x60012E1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D140", Offset = "0x19D241")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012E2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D150", Offset = "0x19D251")]
		private set
		{
		}
	}

	// Token: 0x170003BB RID: 955
	// (get) Token: 0x0600151F RID: 5407 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001520 RID: 5408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700036D")]
	public MonoBehaviour Component
	{
		[Token(Token = "0x60012E3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D160", Offset = "0x19D261")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D170", Offset = "0x19D271")]
		private set
		{
		}
	}

	// Token: 0x170003BC RID: 956
	// (get) Token: 0x06001522 RID: 5410 RVA: 0x00009438 File Offset: 0x00007638
	// (set) Token: 0x06001521 RID: 5409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700036E")]
	public bool IsPause
	{
		[Token(Token = "0x60012E6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012E5")]
		set
		{
		}
	}

	// Token: 0x06001523 RID: 5411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E7")]
	public StateMachine(StateMachineWorker worker, MonoBehaviour component, T StartState, TransitionTables[] TransitionsMapping)
	{
	}

	// Token: 0x06001524 RID: 5412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E8")]
	private V CreateDelegate<V>(MethodInfo method, object target) where V : class
	{
		return null;
	}

	// Token: 0x06001525 RID: 5413 RVA: 0x00009450 File Offset: 0x00007650
	[Token(Token = "0x60012E9")]
	public bool ChangeState(Enum Command)
	{
		return default(bool);
	}

	// Token: 0x06001526 RID: 5414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EA")]
	private void ChangeState(StateElement nextState)
	{
	}

	// Token: 0x06001527 RID: 5415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EB")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19D180", Offset = "0x19D281")]
	private IEnumerator ChangeToNewStateRoutine(StateElement newState)
	{
		return null;
	}

	// Token: 0x170003BD RID: 957
	// (get) Token: 0x06001528 RID: 5416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700036F")]
	public T PrevState
	{
		[Token(Token = "0x60012EC")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003BE RID: 958
	// (get) Token: 0x06001529 RID: 5417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000370")]
	public Enum TransitionCommand
	{
		[Token(Token = "0x60012ED")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003BF RID: 959
	// (get) Token: 0x0600152A RID: 5418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000371")]
	public T State
	{
		[Token(Token = "0x60012EE")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EF")]
	public static StateMachine<T> Initialize(MonoBehaviour component, T startState, TransitionTables[] transitionTables)
	{
		return null;
	}

	// Token: 0x04000C2A RID: 3114
	[Token(Token = "0x4000943")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F7E0", Offset = "0x15F8E1")]
	private StateElement <CurrentState>k__BackingField;

	// Token: 0x04000C2B RID: 3115
	[Token(Token = "0x4000944")]
	[FieldOffset(Offset = "0x0")]
	private StateElement prevState;

	// Token: 0x04000C2C RID: 3116
	[Token(Token = "0x4000945")]
	[FieldOffset(Offset = "0x0")]
	private Enum transitionCommand;

	// Token: 0x04000C2D RID: 3117
	[Token(Token = "0x4000946")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<object, StateElement> ElementMappings;

	// Token: 0x04000C2E RID: 3118
	[Token(Token = "0x4000947")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F7F0", Offset = "0x15F8F1")]
	private bool <IsInTransition>k__BackingField;

	// Token: 0x04000C2F RID: 3119
	[Token(Token = "0x4000948")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F800", Offset = "0x15F901")]
	private StateMachineWorker <Worker>k__BackingField;

	// Token: 0x04000C30 RID: 3120
	[Token(Token = "0x4000949")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F810", Offset = "0x15F911")]
	private MonoBehaviour <Component>k__BackingField;

	// Token: 0x04000C31 RID: 3121
	[Token(Token = "0x400094A")]
	[FieldOffset(Offset = "0x0")]
	private IEnumerator currentTransition;

	// Token: 0x04000C32 RID: 3122
	[Token(Token = "0x400094B")]
	[FieldOffset(Offset = "0x0")]
	private IEnumerator exitRoutine;

	// Token: 0x04000C33 RID: 3123
	[Token(Token = "0x400094C")]
	[FieldOffset(Offset = "0x0")]
	private IEnumerator enterRoutine;

	// Token: 0x04000C34 RID: 3124
	[Token(Token = "0x400094D")]
	[FieldOffset(Offset = "0x0")]
	private IEnumerator queuedChange;

	// Token: 0x04000C35 RID: 3125
	[Token(Token = "0x400094E")]
	[FieldOffset(Offset = "0x0")]
	private Action Pause_Enter;

	// Token: 0x04000C36 RID: 3126
	[Token(Token = "0x400094F")]
	[FieldOffset(Offset = "0x0")]
	private Action Pause_Exit;

	// Token: 0x04000C37 RID: 3127
	[Token(Token = "0x4000950")]
	[FieldOffset(Offset = "0x0")]
	private bool _IsPause;

	// Token: 0x0200031C RID: 796
	[Token(Token = "0x200104D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157530", Offset = "0x157631")]
	private sealed class <ChangeToNewStateRoutine>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600152C RID: 5420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D27")]
		[DebuggerHidden]
		public <ChangeToNewStateRoutine>d__36(int <>1__state)
		{
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D28")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x6006D29")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0B")]
		private object Current
		{
			[Token(Token = "0x6006D2A")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D2B")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0C")]
		private object Current
		{
			[Token(Token = "0x6006D2C")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4018F5A")]
		[FieldOffset(Offset = "0x0")]
		private int <>1__state;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4018F5B")]
		[FieldOffset(Offset = "0x0")]
		private object <>2__current;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4018F5C")]
		[FieldOffset(Offset = "0x0")]
		public StateMachine<T> <>4__this;

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4018F5D")]
		[FieldOffset(Offset = "0x0")]
		public StateElement newState;
	}
}
