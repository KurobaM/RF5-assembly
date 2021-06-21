using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C7F RID: 3199
	[Token(Token = "0x200082D")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x1477A0", Offset = "0x1478A1")]
	public struct FixedBitArray3 : IEnumerable<bool>, IEnumerable
	{
		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060051E9 RID: 20969 RVA: 0x0001A940 File Offset: 0x00018B40
		// (set) Token: 0x060051EA RID: 20970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000872")]
		public bool Item
		{
			[Token(Token = "0x6004412")]
			[Address(RVA = "0x35DA20", Offset = "0x35DB21", VA = "0x35DA20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004413")]
			[Address(RVA = "0x35DAD0", Offset = "0x35DBD1", VA = "0x35DAD0")]
			set
			{
			}
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x0001A958 File Offset: 0x00018B58
		[Token(Token = "0x6004414")]
		[Address(RVA = "0x35DBA0", Offset = "0x35DCA1", VA = "0x35DBA0")]
		public bool Contains(bool value)
		{
			return default(bool);
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x0001A970 File Offset: 0x00018B70
		[Token(Token = "0x6004415")]
		[Address(RVA = "0x35DC30", Offset = "0x35DD31", VA = "0x35DC30")]
		public int IndexOf(bool value)
		{
			return 0;
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004416")]
		[Address(RVA = "0x35DCF0", Offset = "0x35DDF1", VA = "0x35DCF0")]
		public void Clear()
		{
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004417")]
		[Address(RVA = "0x35DD00", Offset = "0x35DE01", VA = "0x35DD00")]
		public void Clear(bool value)
		{
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004418")]
		[Address(RVA = "0x35DD10", Offset = "0x35DE11", VA = "0x35DD10")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A9590", Offset = "0x1A9691")]
		private IEnumerable<bool> Enumerate()
		{
			return null;
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004419")]
		[Address(RVA = "0x35DDA0", Offset = "0x35DEA1", VA = "0x35DDA0", Slot = "4")]
		public IEnumerator<bool> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600441A")]
		[Address(RVA = "0x35DDB0", Offset = "0x35DEB1", VA = "0x35DDB0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400B14D RID: 45389
		[Token(Token = "0x40084FD")]
		[FieldOffset(Offset = "0x0")]
		public bool _0;

		// Token: 0x0400B14E RID: 45390
		[Token(Token = "0x40084FE")]
		[FieldOffset(Offset = "0x1")]
		public bool _1;

		// Token: 0x0400B14F RID: 45391
		[Token(Token = "0x40084FF")]
		[FieldOffset(Offset = "0x2")]
		public bool _2;

		// Token: 0x02000C80 RID: 3200
		[Token(Token = "0x20013CB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159710", Offset = "0x159811")]
		private sealed class <Enumerate>d__10 : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			// Token: 0x060051F2 RID: 20978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078A1")]
			[Address(RVA = "0x27EF6C0", Offset = "0x27EF7C1", VA = "0x27EF6C0")]
			[DebuggerHidden]
			public <Enumerate>d__10(int <>1__state)
			{
			}

			// Token: 0x060051F3 RID: 20979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078A2")]
			[Address(RVA = "0x27EF820", Offset = "0x27EF921", VA = "0x27EF820", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060051F4 RID: 20980 RVA: 0x0001A988 File Offset: 0x00018B88
			[Token(Token = "0x60078A3")]
			[Address(RVA = "0x27EF830", Offset = "0x27EF931", VA = "0x27EF830", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000AA7 RID: 2727
			// (get) Token: 0x060051F5 RID: 20981 RVA: 0x0001A9A0 File Offset: 0x00018BA0
			[Token(Token = "0x17000DF1")]
			private bool Current
			{
				[Token(Token = "0x60078A4")]
				[Address(RVA = "0x27EF940", Offset = "0x27EFA41", VA = "0x27EF940", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060051F6 RID: 20982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078A5")]
			[Address(RVA = "0x27EF950", Offset = "0x27EFA51", VA = "0x27EF950", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000AA8 RID: 2728
			// (get) Token: 0x060051F7 RID: 20983 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DF2")]
			private object Current
			{
				[Token(Token = "0x60078A6")]
				[Address(RVA = "0x27EF9B0", Offset = "0x27EFAB1", VA = "0x27EF9B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060051F8 RID: 20984 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60078A7")]
			[Address(RVA = "0x27EFA20", Offset = "0x27EFB21", VA = "0x27EFA20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060051F9 RID: 20985 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60078A8")]
			[Address(RVA = "0x27EFAE0", Offset = "0x27EFBE1", VA = "0x27EFAE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400B150 RID: 45392
			[Token(Token = "0x401B894")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B151 RID: 45393
			[Token(Token = "0x401B895")]
			[FieldOffset(Offset = "0x14")]
			private bool <>2__current;

			// Token: 0x0400B152 RID: 45394
			[Token(Token = "0x401B896")]
			[FieldOffset(Offset = "0x18")]
			private int <>l__initialThreadId;

			// Token: 0x0400B153 RID: 45395
			[Token(Token = "0x401B897")]
			[FieldOffset(Offset = "0x1C")]
			public FixedBitArray3 <>4__this;

			// Token: 0x0400B154 RID: 45396
			[Token(Token = "0x401B898")]
			[FieldOffset(Offset = "0x1F")]
			public FixedBitArray3 <>3__<>4__this;

			// Token: 0x0400B155 RID: 45397
			[Token(Token = "0x401B899")]
			[FieldOffset(Offset = "0x24")]
			private int <i>5__2;
		}
	}
}
