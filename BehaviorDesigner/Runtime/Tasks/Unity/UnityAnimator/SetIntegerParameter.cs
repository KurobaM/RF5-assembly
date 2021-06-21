using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014B6 RID: 5302
	[Token(Token = "0x2000E7A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155ED0", Offset = "0x155FD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155ED0", Offset = "0x155FD1")]
	public class SetIntegerParameter : Action
	{
		// Token: 0x06007928 RID: 31016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D0")]
		[Address(RVA = "0x28D7CB0", Offset = "0x28D7DB1", VA = "0x28D7CB0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007929 RID: 31017 RVA: 0x0002A330 File Offset: 0x00028530
		[Token(Token = "0x60065D1")]
		[Address(RVA = "0x28D7DB0", Offset = "0x28D7EB1", VA = "0x28D7DB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600792A RID: 31018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D2")]
		[Address(RVA = "0x28D7F70", Offset = "0x28D8071", VA = "0x28D7F70")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AF560", Offset = "0x1AF661")]
		public IEnumerator ResetValue(int origVale)
		{
			return null;
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D3")]
		[Address(RVA = "0x28D8030", Offset = "0x28D8131", VA = "0x28D8030", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600792C RID: 31020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D4")]
		[Address(RVA = "0x28D80C0", Offset = "0x28D81C1", VA = "0x28D80C0")]
		public SetIntegerParameter()
		{
		}

		// Token: 0x0401BBED RID: 113645
		[Token(Token = "0x40185E3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193510", Offset = "0x193611")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBEE RID: 113646
		[Token(Token = "0x40185E4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193550", Offset = "0x193651")]
		public SharedString paramaterName;

		// Token: 0x0401BBEF RID: 113647
		[Token(Token = "0x40185E5")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193590", Offset = "0x193691")]
		public SharedInt intValue;

		// Token: 0x0401BBF0 RID: 113648
		[Token(Token = "0x40185E6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1935D0", Offset = "0x1936D1")]
		public bool setOnce;

		// Token: 0x0401BBF1 RID: 113649
		[Token(Token = "0x40185E7")]
		[FieldOffset(Offset = "0x6C")]
		private int hashID;

		// Token: 0x0401BBF2 RID: 113650
		[Token(Token = "0x40185E8")]
		[FieldOffset(Offset = "0x70")]
		private Animator animator;

		// Token: 0x0401BBF3 RID: 113651
		[Token(Token = "0x40185E9")]
		[FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;

		// Token: 0x020014B7 RID: 5303
		[Token(Token = "0x20015A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A320", Offset = "0x15A421")]
		private sealed class <ResetValue>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600792D RID: 31021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E07")]
			[Address(RVA = "0x28D8000", Offset = "0x28D8101", VA = "0x28D8000")]
			[DebuggerHidden]
			public <ResetValue>d__9(int <>1__state)
			{
			}

			// Token: 0x0600792E RID: 31022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E08")]
			[Address(RVA = "0x28D80D0", Offset = "0x28D81D1", VA = "0x28D80D0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600792F RID: 31023 RVA: 0x0002A348 File Offset: 0x00028548
			[Token(Token = "0x6007E09")]
			[Address(RVA = "0x28D80E0", Offset = "0x28D81E1", VA = "0x28D80E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E5C RID: 3676
			// (get) Token: 0x06007930 RID: 31024 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EE3")]
			private object Current
			{
				[Token(Token = "0x6007E0A")]
				[Address(RVA = "0x28D8170", Offset = "0x28D8271", VA = "0x28D8170", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007931 RID: 31025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E0B")]
			[Address(RVA = "0x28D8180", Offset = "0x28D8281", VA = "0x28D8180", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E5D RID: 3677
			// (get) Token: 0x06007932 RID: 31026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EE4")]
			private object Current
			{
				[Token(Token = "0x6007E0C")]
				[Address(RVA = "0x28D81E0", Offset = "0x28D82E1", VA = "0x28D81E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401BBF4 RID: 113652
			[Token(Token = "0x401C216")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401BBF5 RID: 113653
			[Token(Token = "0x401C217")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401BBF6 RID: 113654
			[Token(Token = "0x401C218")]
			[FieldOffset(Offset = "0x20")]
			public SetIntegerParameter <>4__this;

			// Token: 0x0401BBF7 RID: 113655
			[Token(Token = "0x401C219")]
			[FieldOffset(Offset = "0x28")]
			public int origVale;
		}
	}
}
