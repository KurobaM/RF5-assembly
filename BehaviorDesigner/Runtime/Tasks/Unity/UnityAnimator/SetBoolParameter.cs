using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014B2 RID: 5298
	[Token(Token = "0x2000E78")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155E10", Offset = "0x155F11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155E10", Offset = "0x155F11")]
	public class SetBoolParameter : Action
	{
		// Token: 0x06007912 RID: 30994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C6")]
		[Address(RVA = "0x28D7240", Offset = "0x28D7341", VA = "0x28D7240", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007913 RID: 30995 RVA: 0x0002A2D0 File Offset: 0x000284D0
		[Token(Token = "0x60065C7")]
		[Address(RVA = "0x28D7340", Offset = "0x28D7441", VA = "0x28D7340", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007914 RID: 30996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C8")]
		[Address(RVA = "0x28D7500", Offset = "0x28D7601", VA = "0x28D7500")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AF480", Offset = "0x1AF581")]
		public IEnumerator ResetValue(bool origVale)
		{
			return null;
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C9")]
		[Address(RVA = "0x28D75C0", Offset = "0x28D76C1", VA = "0x28D75C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CA")]
		[Address(RVA = "0x28D7650", Offset = "0x28D7751", VA = "0x28D7650")]
		public SetBoolParameter()
		{
		}

		// Token: 0x0401BBD7 RID: 113623
		[Token(Token = "0x40185D5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193310", Offset = "0x193411")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBD8 RID: 113624
		[Token(Token = "0x40185D6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193350", Offset = "0x193451")]
		public SharedString paramaterName;

		// Token: 0x0401BBD9 RID: 113625
		[Token(Token = "0x40185D7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193390", Offset = "0x193491")]
		public SharedBool boolValue;

		// Token: 0x0401BBDA RID: 113626
		[Token(Token = "0x40185D8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1933D0", Offset = "0x1934D1")]
		public bool setOnce;

		// Token: 0x0401BBDB RID: 113627
		[Token(Token = "0x40185D9")]
		[FieldOffset(Offset = "0x6C")]
		private int hashID;

		// Token: 0x0401BBDC RID: 113628
		[Token(Token = "0x40185DA")]
		[FieldOffset(Offset = "0x70")]
		private Animator animator;

		// Token: 0x0401BBDD RID: 113629
		[Token(Token = "0x40185DB")]
		[FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;

		// Token: 0x020014B3 RID: 5299
		[Token(Token = "0x20015A6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A300", Offset = "0x15A401")]
		private sealed class <ResetValue>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007917 RID: 30999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DFB")]
			[Address(RVA = "0x28D7590", Offset = "0x28D7691", VA = "0x28D7590")]
			[DebuggerHidden]
			public <ResetValue>d__9(int <>1__state)
			{
			}

			// Token: 0x06007918 RID: 31000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DFC")]
			[Address(RVA = "0x28D7660", Offset = "0x28D7761", VA = "0x28D7660", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007919 RID: 31001 RVA: 0x0002A2E8 File Offset: 0x000284E8
			[Token(Token = "0x6007DFD")]
			[Address(RVA = "0x28D7670", Offset = "0x28D7771", VA = "0x28D7670", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E58 RID: 3672
			// (get) Token: 0x0600791A RID: 31002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EDF")]
			private object Current
			{
				[Token(Token = "0x6007DFE")]
				[Address(RVA = "0x28D7700", Offset = "0x28D7801", VA = "0x28D7700", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600791B RID: 31003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DFF")]
			[Address(RVA = "0x28D7710", Offset = "0x28D7811", VA = "0x28D7710", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E59 RID: 3673
			// (get) Token: 0x0600791C RID: 31004 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EE0")]
			private object Current
			{
				[Token(Token = "0x6007E00")]
				[Address(RVA = "0x28D7770", Offset = "0x28D7871", VA = "0x28D7770", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401BBDE RID: 113630
			[Token(Token = "0x401C20E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401BBDF RID: 113631
			[Token(Token = "0x401C20F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401BBE0 RID: 113632
			[Token(Token = "0x401C210")]
			[FieldOffset(Offset = "0x20")]
			public SetBoolParameter <>4__this;

			// Token: 0x0401BBE1 RID: 113633
			[Token(Token = "0x401C211")]
			[FieldOffset(Offset = "0x28")]
			public bool origVale;
		}
	}
}
