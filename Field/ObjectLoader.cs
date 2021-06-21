using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

namespace Field
{
	// Token: 0x0200110A RID: 4362
	[Token(Token = "0x2000AFC")]
	public class ObjectLoader : MonoBehaviour
	{
		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06006E54 RID: 28244 RVA: 0x00025F08 File Offset: 0x00024108
		// (set) Token: 0x06006E55 RID: 28245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF7")]
		public int LoadingCount
		{
			[Token(Token = "0x6005B8C")]
			[Address(RVA = "0x202ED20", Offset = "0x202EE21", VA = "0x202ED20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEB90", Offset = "0x1AEC91")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B8D")]
			[Address(RVA = "0x202ED30", Offset = "0x202EE31", VA = "0x202ED30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEBA0", Offset = "0x1AECA1")]
			protected set
			{
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06006E56 RID: 28246 RVA: 0x00025F20 File Offset: 0x00024120
		// (set) Token: 0x06006E57 RID: 28247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF8")]
		public bool IsUpdate
		{
			[Token(Token = "0x6005B8E")]
			[Address(RVA = "0x202ED40", Offset = "0x202EE41", VA = "0x202ED40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEBB0", Offset = "0x1AECB1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B8F")]
			[Address(RVA = "0x202ED50", Offset = "0x202EE51", VA = "0x202ED50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEBC0", Offset = "0x1AECC1")]
			protected set
			{
			}
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x00025F38 File Offset: 0x00024138
		[Token(Token = "0x6005B90")]
		[Address(RVA = "0x202EC80", Offset = "0x202ED81", VA = "0x202EC80")]
		public bool NeedsLoad()
		{
			return default(bool);
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x00025F50 File Offset: 0x00024150
		[Token(Token = "0x6005B91")]
		[Address(RVA = "0x202E660", Offset = "0x202E761", VA = "0x202E660")]
		public bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B92")]
		[Address(RVA = "0x202ED60", Offset = "0x202EE61", VA = "0x202ED60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006E5B RID: 28251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B93")]
		[Address(RVA = "0x202EE80", Offset = "0x202EF81", VA = "0x202EE80")]
		private void Awake()
		{
		}

		// Token: 0x06006E5C RID: 28252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B94")]
		[Address(RVA = "0x202EF20", Offset = "0x202F021", VA = "0x202EF20")]
		private void OnEnable()
		{
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B95")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AEBD0", Offset = "0x1AECD1")]
		public IEnumerator LoadObjectAsync<T>(int id, Action<T> action) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06006E5E RID: 28254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B96")]
		[Address(RVA = "0x202EF30", Offset = "0x202F031", VA = "0x202EF30", Slot = "4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AEC40", Offset = "0x1AED41")]
		public virtual IEnumerator Load()
		{
			return null;
		}

		// Token: 0x06006E5F RID: 28255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B97")]
		[Address(RVA = "0x202EFE0", Offset = "0x202F0E1", VA = "0x202EFE0")]
		public ObjectLoader()
		{
		}

		// Token: 0x040180F5 RID: 98549
		[Token(Token = "0x4014BCB")]
		[FieldOffset(Offset = "0x18")]
		protected ObjectLoadParam loadParam;

		// Token: 0x040180F6 RID: 98550
		[Token(Token = "0x4014BCC")]
		[FieldOffset(Offset = "0x20")]
		private int loaderId;

		// Token: 0x040180F7 RID: 98551
		[Token(Token = "0x4014BCD")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181380", Offset = "0x181481")]
		private int <LoadingCount>k__BackingField;

		// Token: 0x040180F8 RID: 98552
		[Token(Token = "0x4014BCE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181390", Offset = "0x181491")]
		private bool <IsUpdate>k__BackingField;

		// Token: 0x0200110B RID: 4363
		[Token(Token = "0x200157A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A130", Offset = "0x15A231")]
		private sealed class <>c__DisplayClass15_0<T> where T : UnityEngine.Object
		{
			// Token: 0x06006E60 RID: 28256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D77")]
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x06006E61 RID: 28257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D78")]
			internal void <LoadObjectAsync>b__0(AssetHandle<T> handle)
			{
			}

			// Token: 0x040180F9 RID: 98553
			[Token(Token = "0x401C136")]
			[FieldOffset(Offset = "0x0")]
			public bool isLoaded;

			// Token: 0x040180FA RID: 98554
			[Token(Token = "0x401C137")]
			[FieldOffset(Offset = "0x0")]
			public ObjectLoader <>4__this;

			// Token: 0x040180FB RID: 98555
			[Token(Token = "0x401C138")]
			[FieldOffset(Offset = "0x0")]
			public int id;

			// Token: 0x040180FC RID: 98556
			[Token(Token = "0x401C139")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> action;
		}

		// Token: 0x0200110C RID: 4364
		[Token(Token = "0x200157B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A140", Offset = "0x15A241")]
		private sealed class <LoadObjectAsync>d__15<T> : IEnumerator<object>, IEnumerator, IDisposable where T : UnityEngine.Object
		{
			// Token: 0x06006E62 RID: 28258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D79")]
			[DebuggerHidden]
			public <LoadObjectAsync>d__15(int <>1__state)
			{
			}

			// Token: 0x06006E63 RID: 28259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D7A")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006E64 RID: 28260 RVA: 0x00025F68 File Offset: 0x00024168
			[Token(Token = "0x6007D7B")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E03 RID: 3587
			// (get) Token: 0x06006E65 RID: 28261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC5")]
			private object Current
			{
				[Token(Token = "0x6007D7C")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006E66 RID: 28262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D7D")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E04 RID: 3588
			// (get) Token: 0x06006E67 RID: 28263 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC6")]
			private object Current
			{
				[Token(Token = "0x6007D7E")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040180FD RID: 98557
			[Token(Token = "0x401C13A")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x040180FE RID: 98558
			[Token(Token = "0x401C13B")]
			[FieldOffset(Offset = "0x0")]
			private object <>2__current;

			// Token: 0x040180FF RID: 98559
			[Token(Token = "0x401C13C")]
			[FieldOffset(Offset = "0x0")]
			public ObjectLoader <>4__this;

			// Token: 0x04018100 RID: 98560
			[Token(Token = "0x401C13D")]
			[FieldOffset(Offset = "0x0")]
			public int id;

			// Token: 0x04018101 RID: 98561
			[Token(Token = "0x401C13E")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> action;

			// Token: 0x04018102 RID: 98562
			[Token(Token = "0x401C13F")]
			[FieldOffset(Offset = "0x0")]
			private ObjectLoader.<>c__DisplayClass15_0<T> <>8__1;
		}

		// Token: 0x0200110D RID: 4365
		[Token(Token = "0x200157C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A150", Offset = "0x15A251")]
		private sealed class <Load>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006E68 RID: 28264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D7F")]
			[Address(RVA = "0x202EFB0", Offset = "0x202F0B1", VA = "0x202EFB0")]
			[DebuggerHidden]
			public <Load>d__16(int <>1__state)
			{
			}

			// Token: 0x06006E69 RID: 28265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D80")]
			[Address(RVA = "0x202EFF0", Offset = "0x202F0F1", VA = "0x202EFF0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006E6A RID: 28266 RVA: 0x00025F80 File Offset: 0x00024180
			[Token(Token = "0x6007D81")]
			[Address(RVA = "0x202F000", Offset = "0x202F101", VA = "0x202F000", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E05 RID: 3589
			// (get) Token: 0x06006E6B RID: 28267 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC7")]
			private object Current
			{
				[Token(Token = "0x6007D82")]
				[Address(RVA = "0x202F0B0", Offset = "0x202F1B1", VA = "0x202F0B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006E6C RID: 28268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D83")]
			[Address(RVA = "0x202F0C0", Offset = "0x202F1C1", VA = "0x202F0C0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E06 RID: 3590
			// (get) Token: 0x06006E6D RID: 28269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC8")]
			private object Current
			{
				[Token(Token = "0x6007D84")]
				[Address(RVA = "0x202F120", Offset = "0x202F221", VA = "0x202F120", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04018103 RID: 98563
			[Token(Token = "0x401C140")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04018104 RID: 98564
			[Token(Token = "0x401C141")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04018105 RID: 98565
			[Token(Token = "0x401C142")]
			[FieldOffset(Offset = "0x20")]
			public ObjectLoader <>4__this;
		}
	}
}
