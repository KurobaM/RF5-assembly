using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D96 RID: 3478
	[Token(Token = "0x20008E3")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06005A1B RID: 23067 RVA: 0x0001DA78 File Offset: 0x0001BC78
		[Token(Token = "0x170008F5")]
		protected float deltaTime
		{
			[Token(Token = "0x6004A75")]
			[Address(RVA = "0x27C6230", Offset = "0x27C6331", VA = "0x27C6230")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06005A1C RID: 23068
		[Token(Token = "0x6004A76")]
		protected abstract void OnModifyOffset();

		// Token: 0x06005A1D RID: 23069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A77")]
		[Address(RVA = "0x27C6260", Offset = "0x27C6361", VA = "0x27C6260", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A78")]
		[Address(RVA = "0x27C62F0", Offset = "0x27C63F1", VA = "0x27C62F0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AB9D0", Offset = "0x1ABAD1")]
		private IEnumerator Initiate()
		{
			return null;
		}

		// Token: 0x06005A1F RID: 23071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A79")]
		[Address(RVA = "0x27C63A0", Offset = "0x27C64A1", VA = "0x27C63A0")]
		private void ModifyOffset()
		{
		}

		// Token: 0x06005A20 RID: 23072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A7A")]
		[Address(RVA = "0x27C64B0", Offset = "0x27C65B1", VA = "0x27C64B0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06005A21 RID: 23073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A7B")]
		[Address(RVA = "0x27C65D0", Offset = "0x27C66D1", VA = "0x27C65D0")]
		protected OffsetModifierVRIK()
		{
		}

		// Token: 0x0400B95B RID: 47451
		[Token(Token = "0x4008A8C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C6B0", Offset = "0x17C7B1")]
		public float weight;

		// Token: 0x0400B95C RID: 47452
		[Token(Token = "0x4008A8D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C6F0", Offset = "0x17C7F1")]
		public VRIK ik;

		// Token: 0x0400B95D RID: 47453
		[Token(Token = "0x4008A8E")]
		[FieldOffset(Offset = "0x28")]
		private float lastTime;

		// Token: 0x02000D97 RID: 3479
		[Token(Token = "0x2001423")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1597B0", Offset = "0x1598B1")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005A22 RID: 23074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A61")]
			[Address(RVA = "0x27C6370", Offset = "0x27C6471", VA = "0x27C6370")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			// Token: 0x06005A23 RID: 23075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A62")]
			[Address(RVA = "0x27C65E0", Offset = "0x27C66E1", VA = "0x27C65E0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005A24 RID: 23076 RVA: 0x0001DA90 File Offset: 0x0001BC90
			[Token(Token = "0x6007A63")]
			[Address(RVA = "0x27C65F0", Offset = "0x27C66F1", VA = "0x27C65F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B84 RID: 2948
			// (get) Token: 0x06005A25 RID: 23077 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E4B")]
			private object Current
			{
				[Token(Token = "0x6007A64")]
				[Address(RVA = "0x27C6750", Offset = "0x27C6851", VA = "0x27C6750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A26 RID: 23078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A65")]
			[Address(RVA = "0x27C6760", Offset = "0x27C6861", VA = "0x27C6760", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B85 RID: 2949
			// (get) Token: 0x06005A27 RID: 23079 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E4C")]
			private object Current
			{
				[Token(Token = "0x6007A66")]
				[Address(RVA = "0x27C67C0", Offset = "0x27C68C1", VA = "0x27C67C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B95E RID: 47454
			[Token(Token = "0x401BAED")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B95F RID: 47455
			[Token(Token = "0x401BAEE")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B960 RID: 47456
			[Token(Token = "0x401BAEF")]
			[FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;
		}
	}
}
