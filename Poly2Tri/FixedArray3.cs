using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C7D RID: 3197
	[Token(Token = "0x200082C")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x147760", Offset = "0x147861")]
	public struct FixedArray3<T> : IEnumerable<T>, IEnumerable where T : class
	{
		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060051D8 RID: 20952 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060051D9 RID: 20953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000871")]
		public T Item
		{
			[Token(Token = "0x6004409")]
			get
			{
				return null;
			}
			[Token(Token = "0x600440A")]
			set
			{
			}
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		[Token(Token = "0x600440B")]
		public bool Contains(T value)
		{
			return default(bool);
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x0001A910 File Offset: 0x00018B10
		[Token(Token = "0x600440C")]
		public int IndexOf(T value)
		{
			return 0;
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440D")]
		public void Clear()
		{
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440E")]
		public void Clear(T value)
		{
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440F")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A9520", Offset = "0x1A9621")]
		private IEnumerable<T> Enumerate()
		{
			return null;
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004410")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004411")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400B144 RID: 45380
		[Token(Token = "0x40084FA")]
		[FieldOffset(Offset = "0x0")]
		public T _0;

		// Token: 0x0400B145 RID: 45381
		[Token(Token = "0x40084FB")]
		[FieldOffset(Offset = "0x0")]
		public T _1;

		// Token: 0x0400B146 RID: 45382
		[Token(Token = "0x40084FC")]
		[FieldOffset(Offset = "0x0")]
		public T _2;

		// Token: 0x02000C7E RID: 3198
		[Token(Token = "0x20013CA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159700", Offset = "0x159801")]
		private sealed class <Enumerate>d__10 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x060051E1 RID: 20961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007899")]
			[DebuggerHidden]
			public <Enumerate>d__10(int <>1__state)
			{
			}

			// Token: 0x060051E2 RID: 20962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600789A")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060051E3 RID: 20963 RVA: 0x0001A928 File Offset: 0x00018B28
			[Token(Token = "0x600789B")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000AA4 RID: 2724
			// (get) Token: 0x060051E4 RID: 20964 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DEF")]
			private T Current
			{
				[Token(Token = "0x600789C")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060051E5 RID: 20965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600789D")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000AA5 RID: 2725
			// (get) Token: 0x060051E6 RID: 20966 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DF0")]
			private object Current
			{
				[Token(Token = "0x600789E")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060051E7 RID: 20967 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600789F")]
			[DebuggerHidden]
			private IEnumerator<T> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060051E8 RID: 20968 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60078A0")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400B147 RID: 45383
			[Token(Token = "0x401B88E")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x0400B148 RID: 45384
			[Token(Token = "0x401B88F")]
			[FieldOffset(Offset = "0x0")]
			private T <>2__current;

			// Token: 0x0400B149 RID: 45385
			[Token(Token = "0x401B890")]
			[FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			// Token: 0x0400B14A RID: 45386
			[Token(Token = "0x401B891")]
			[FieldOffset(Offset = "0x0")]
			public FixedArray3<T> <>4__this;

			// Token: 0x0400B14B RID: 45387
			[Token(Token = "0x401B892")]
			[FieldOffset(Offset = "0x0")]
			public FixedArray3<T> <>3__<>4__this;

			// Token: 0x0400B14C RID: 45388
			[Token(Token = "0x401B893")]
			[FieldOffset(Offset = "0x0")]
			private int <i>5__2;
		}
	}
}
