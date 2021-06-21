using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Farm
{
	// Token: 0x0200108E RID: 4238
	[Token(Token = "0x2000AB6")]
	public class FarmDragonManager : MonoBehaviour
	{
		// Token: 0x06006B38 RID: 27448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005929")]
		[Address(RVA = "0x2151350", Offset = "0x2151451", VA = "0x2151350")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADF70", Offset = "0x1AE071")]
		public IEnumerator UpdateMonsterHutDisplay()
		{
			return null;
		}

		// Token: 0x06006B39 RID: 27449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592A")]
		[Address(RVA = "0x2151400", Offset = "0x2151501", VA = "0x2151400")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADFE0", Offset = "0x1AE0E1")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x06006B3A RID: 27450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600592B")]
		[Address(RVA = "0x21514B0", Offset = "0x21515B1", VA = "0x21514B0")]
		private void Update()
		{
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600592C")]
		[Address(RVA = "0x21514C0", Offset = "0x21515C1", VA = "0x21514C0")]
		public FarmDragonManager()
		{
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600592D")]
		[Address(RVA = "0x21514D0", Offset = "0x21515D1", VA = "0x21514D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE050", Offset = "0x1AE151")]
		private void <UpdateMonsterHutDisplay>b__3_0(bool[] flag)
		{
		}

		// Token: 0x040172EB RID: 94955
		[Token(Token = "0x4013EC2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject Farm;

		// Token: 0x040172EC RID: 94956
		[Token(Token = "0x4013EC3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> MonsterHouses;

		// Token: 0x040172ED RID: 94957
		[Token(Token = "0x4013EC4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> fences;

		// Token: 0x0200108F RID: 4239
		[Token(Token = "0x2001544")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159DF0", Offset = "0x159EF1")]
		private sealed class <UpdateMonsterHutDisplay>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006B3D RID: 27453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CBE")]
			[Address(RVA = "0x21513D0", Offset = "0x21514D1", VA = "0x21513D0")]
			[DebuggerHidden]
			public <UpdateMonsterHutDisplay>d__3(int <>1__state)
			{
			}

			// Token: 0x06006B3E RID: 27454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CBF")]
			[Address(RVA = "0x2151810", Offset = "0x2151911", VA = "0x2151810", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006B3F RID: 27455 RVA: 0x00024A80 File Offset: 0x00022C80
			[Token(Token = "0x6007CC0")]
			[Address(RVA = "0x2151820", Offset = "0x2151921", VA = "0x2151820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DAC RID: 3500
			// (get) Token: 0x06006B40 RID: 27456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EA5")]
			private object Current
			{
				[Token(Token = "0x6007CC1")]
				[Address(RVA = "0x2151A80", Offset = "0x2151B81", VA = "0x2151A80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006B41 RID: 27457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CC2")]
			[Address(RVA = "0x2151A90", Offset = "0x2151B91", VA = "0x2151A90", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DAD RID: 3501
			// (get) Token: 0x06006B42 RID: 27458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EA6")]
			private object Current
			{
				[Token(Token = "0x6007CC3")]
				[Address(RVA = "0x2151AF0", Offset = "0x2151BF1", VA = "0x2151AF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040172EE RID: 94958
			[Token(Token = "0x401C035")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040172EF RID: 94959
			[Token(Token = "0x401C036")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040172F0 RID: 94960
			[Token(Token = "0x401C037")]
			[FieldOffset(Offset = "0x20")]
			public FarmDragonManager <>4__this;
		}

		// Token: 0x02001090 RID: 4240
		[Token(Token = "0x2001545")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159E00", Offset = "0x159F01")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006B43 RID: 27459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CC4")]
			[Address(RVA = "0x2151480", Offset = "0x2151581", VA = "0x2151480")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			// Token: 0x06006B44 RID: 27460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CC5")]
			[Address(RVA = "0x2151600", Offset = "0x2151701", VA = "0x2151600", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006B45 RID: 27461 RVA: 0x00024A98 File Offset: 0x00022C98
			[Token(Token = "0x6007CC6")]
			[Address(RVA = "0x2151610", Offset = "0x2151711", VA = "0x2151610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DAE RID: 3502
			// (get) Token: 0x06006B46 RID: 27462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EA7")]
			private object Current
			{
				[Token(Token = "0x6007CC7")]
				[Address(RVA = "0x2151790", Offset = "0x2151891", VA = "0x2151790", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006B47 RID: 27463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CC8")]
			[Address(RVA = "0x21517A0", Offset = "0x21518A1", VA = "0x21517A0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DAF RID: 3503
			// (get) Token: 0x06006B48 RID: 27464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EA8")]
			private object Current
			{
				[Token(Token = "0x6007CC9")]
				[Address(RVA = "0x2151800", Offset = "0x2151901", VA = "0x2151800", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040172F1 RID: 94961
			[Token(Token = "0x401C038")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040172F2 RID: 94962
			[Token(Token = "0x401C039")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040172F3 RID: 94963
			[Token(Token = "0x401C03A")]
			[FieldOffset(Offset = "0x20")]
			public FarmDragonManager <>4__this;
		}
	}
}
