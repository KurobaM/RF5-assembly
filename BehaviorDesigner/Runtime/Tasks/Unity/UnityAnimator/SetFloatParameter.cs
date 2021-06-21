using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014B4 RID: 5300
	[Token(Token = "0x2000E79")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155E70", Offset = "0x155F71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155E70", Offset = "0x155F71")]
	public class SetFloatParameter : Action
	{
		// Token: 0x0600791D RID: 31005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CB")]
		[Address(RVA = "0x28D7780", Offset = "0x28D7881", VA = "0x28D7780", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x0002A300 File Offset: 0x00028500
		[Token(Token = "0x60065CC")]
		[Address(RVA = "0x28D7880", Offset = "0x28D7981", VA = "0x28D7880", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CD")]
		[Address(RVA = "0x28D7A30", Offset = "0x28D7B31", VA = "0x28D7A30")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AF4F0", Offset = "0x1AF5F1")]
		public IEnumerator ResetValue(float origVale)
		{
			return null;
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CE")]
		[Address(RVA = "0x28D7AF0", Offset = "0x28D7BF1", VA = "0x28D7AF0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CF")]
		[Address(RVA = "0x28D7B80", Offset = "0x28D7C81", VA = "0x28D7B80")]
		public SetFloatParameter()
		{
		}

		// Token: 0x0401BBE2 RID: 113634
		[Token(Token = "0x40185DC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193410", Offset = "0x193511")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBE3 RID: 113635
		[Token(Token = "0x40185DD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193450", Offset = "0x193551")]
		public SharedString paramaterName;

		// Token: 0x0401BBE4 RID: 113636
		[Token(Token = "0x40185DE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193490", Offset = "0x193591")]
		public SharedFloat floatValue;

		// Token: 0x0401BBE5 RID: 113637
		[Token(Token = "0x40185DF")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1934D0", Offset = "0x1935D1")]
		public bool setOnce;

		// Token: 0x0401BBE6 RID: 113638
		[Token(Token = "0x40185E0")]
		[FieldOffset(Offset = "0x6C")]
		private int hashID;

		// Token: 0x0401BBE7 RID: 113639
		[Token(Token = "0x40185E1")]
		[FieldOffset(Offset = "0x70")]
		private Animator animator;

		// Token: 0x0401BBE8 RID: 113640
		[Token(Token = "0x40185E2")]
		[FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;

		// Token: 0x020014B5 RID: 5301
		[Token(Token = "0x20015A7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A310", Offset = "0x15A411")]
		private sealed class <ResetValue>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007922 RID: 31010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E01")]
			[Address(RVA = "0x28D7AC0", Offset = "0x28D7BC1", VA = "0x28D7AC0")]
			[DebuggerHidden]
			public <ResetValue>d__9(int <>1__state)
			{
			}

			// Token: 0x06007923 RID: 31011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E02")]
			[Address(RVA = "0x28D7B90", Offset = "0x28D7C91", VA = "0x28D7B90", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007924 RID: 31012 RVA: 0x0002A318 File Offset: 0x00028518
			[Token(Token = "0x6007E03")]
			[Address(RVA = "0x28D7BA0", Offset = "0x28D7CA1", VA = "0x28D7BA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E5A RID: 3674
			// (get) Token: 0x06007925 RID: 31013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EE1")]
			private object Current
			{
				[Token(Token = "0x6007E04")]
				[Address(RVA = "0x28D7C30", Offset = "0x28D7D31", VA = "0x28D7C30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007926 RID: 31014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E05")]
			[Address(RVA = "0x28D7C40", Offset = "0x28D7D41", VA = "0x28D7C40", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E5B RID: 3675
			// (get) Token: 0x06007927 RID: 31015 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EE2")]
			private object Current
			{
				[Token(Token = "0x6007E06")]
				[Address(RVA = "0x28D7CA0", Offset = "0x28D7DA1", VA = "0x28D7CA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401BBE9 RID: 113641
			[Token(Token = "0x401C212")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401BBEA RID: 113642
			[Token(Token = "0x401C213")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401BBEB RID: 113643
			[Token(Token = "0x401C214")]
			[FieldOffset(Offset = "0x20")]
			public SetFloatParameter <>4__this;

			// Token: 0x0401BBEC RID: 113644
			[Token(Token = "0x401C215")]
			[FieldOffset(Offset = "0x28")]
			public float origVale;
		}
	}
}
