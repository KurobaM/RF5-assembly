using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Farm;
using Il2CppDummyDll;
using UnityEngine;

namespace MonsterHut
{
	// Token: 0x02000EF8 RID: 3832
	[Token(Token = "0x20009D0")]
	public class MonsterHutAccessor : MonoBehaviour
	{
		// Token: 0x0600648E RID: 25742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539A")]
		[Address(RVA = "0x1E61160", Offset = "0x1E61261", VA = "0x1E61160")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ACB60", Offset = "0x1ACC61")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539B")]
		[Address(RVA = "0x1E611F0", Offset = "0x1E612F1", VA = "0x1E611F0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539C")]
		[Address(RVA = "0x1E61260", Offset = "0x1E61361", VA = "0x1E61260")]
		public MonsterHutAccessor()
		{
		}

		// Token: 0x0400C459 RID: 50265
		[Token(Token = "0x40092EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FarmManager.FARM_ID AccessFarmId;

		// Token: 0x0400C45A RID: 50266
		[Token(Token = "0x40092EF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int PlaceId;

		// Token: 0x02000EF9 RID: 3833
		[Token(Token = "0x2001494")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159AF0", Offset = "0x159BF1")]
		private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006491 RID: 25745 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BA3")]
			[Address(RVA = "0x1E611C0", Offset = "0x1E612C1", VA = "0x1E611C0")]
			[DebuggerHidden]
			public <Start>d__2(int <>1__state)
			{
			}

			// Token: 0x06006492 RID: 25746 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BA4")]
			[Address(RVA = "0x1E61270", Offset = "0x1E61371", VA = "0x1E61270", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006493 RID: 25747 RVA: 0x00021AC8 File Offset: 0x0001FCC8
			[Token(Token = "0x6007BA5")]
			[Address(RVA = "0x1E61280", Offset = "0x1E61381", VA = "0x1E61280", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D0A RID: 3338
			// (get) Token: 0x06006494 RID: 25748 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E79")]
			private object Current
			{
				[Token(Token = "0x6007BA6")]
				[Address(RVA = "0x1E61350", Offset = "0x1E61451", VA = "0x1E61350", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006495 RID: 25749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BA7")]
			[Address(RVA = "0x1E61360", Offset = "0x1E61461", VA = "0x1E61360", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D0B RID: 3339
			// (get) Token: 0x06006496 RID: 25750 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E7A")]
			private object Current
			{
				[Token(Token = "0x6007BA8")]
				[Address(RVA = "0x1E613C0", Offset = "0x1E614C1", VA = "0x1E613C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400C45B RID: 50267
			[Token(Token = "0x401BD77")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400C45C RID: 50268
			[Token(Token = "0x401BD78")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;
		}
	}
}
