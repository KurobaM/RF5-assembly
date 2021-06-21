using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001107 RID: 4359
	[Token(Token = "0x2000AFA")]
	public class ObjectLoadManager : SingletonMonoBehaviour<ObjectLoadManager>
	{
		// Token: 0x06006E42 RID: 28226 RVA: 0x00025EC0 File Offset: 0x000240C0
		[Token(Token = "0x6005B81")]
		[Address(RVA = "0x202E410", Offset = "0x202E511", VA = "0x202E410")]
		public int GetObjectLoadListCount()
		{
			return 0;
		}

		// Token: 0x06006E43 RID: 28227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B82")]
		[Address(RVA = "0x202E460", Offset = "0x202E561", VA = "0x202E460")]
		public void AddObjectLoadList(ObjectLoader objectLoad)
		{
		}

		// Token: 0x06006E44 RID: 28228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B83")]
		[Address(RVA = "0x202E4D0", Offset = "0x202E5D1", VA = "0x202E4D0")]
		public void RemoveObjectLoadList(ObjectLoader objectLoad)
		{
		}

		// Token: 0x06006E45 RID: 28229 RVA: 0x00025ED8 File Offset: 0x000240D8
		[Token(Token = "0x6005B84")]
		[Address(RVA = "0x202E540", Offset = "0x202E641", VA = "0x202E540")]
		public bool IsLoadCompleted()
		{
			return default(bool);
		}

		// Token: 0x06006E46 RID: 28230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B85")]
		[Address(RVA = "0x202E680", Offset = "0x202E781", VA = "0x202E680")]
		public void LoadRequest(ObjectLoader objectLoad)
		{
		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B86")]
		[Address(RVA = "0x202E6F0", Offset = "0x202E7F1", VA = "0x202E6F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B87")]
		[Address(RVA = "0x202E700", Offset = "0x202E801", VA = "0x202E700")]
		private void Start()
		{
		}

		// Token: 0x06006E49 RID: 28233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B88")]
		[Address(RVA = "0x202E710", Offset = "0x202E811", VA = "0x202E710")]
		private void Update()
		{
		}

		// Token: 0x06006E4A RID: 28234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B89")]
		[Address(RVA = "0x202E7E0", Offset = "0x202E8E1", VA = "0x202E7E0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AEB20", Offset = "0x1AEC21")]
		public IEnumerator LoadObject()
		{
			return null;
		}

		// Token: 0x06006E4B RID: 28235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8A")]
		[Address(RVA = "0x202E890", Offset = "0x202E991", VA = "0x202E890")]
		public ObjectLoadManager()
		{
		}

		// Token: 0x040180EC RID: 98540
		[Token(Token = "0x4014BC6")]
		[FieldOffset(Offset = "0x18")]
		private List<ObjectLoader> ObjectLoadList;

		// Token: 0x040180ED RID: 98541
		[Token(Token = "0x4014BC7")]
		[FieldOffset(Offset = "0x20")]
		private List<ObjectLoader> LoadRequestList;

		// Token: 0x02001108 RID: 4360
		[Token(Token = "0x2001579")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A120", Offset = "0x15A221")]
		private sealed class <LoadObject>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006E4C RID: 28236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D70")]
			[Address(RVA = "0x202E860", Offset = "0x202E961", VA = "0x202E860")]
			[DebuggerHidden]
			public <LoadObject>d__10(int <>1__state)
			{
			}

			// Token: 0x06006E4D RID: 28237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D71")]
			[Address(RVA = "0x202E940", Offset = "0x202EA41", VA = "0x202E940", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006E4E RID: 28238 RVA: 0x00025EF0 File Offset: 0x000240F0
			[Token(Token = "0x6007D72")]
			[Address(RVA = "0x202EA10", Offset = "0x202EB11", VA = "0x202EA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06006E4F RID: 28239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D73")]
			[Address(RVA = "0x202E9B0", Offset = "0x202EAB1", VA = "0x202E9B0")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000DFF RID: 3583
			// (get) Token: 0x06006E50 RID: 28240 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC3")]
			private object Current
			{
				[Token(Token = "0x6007D74")]
				[Address(RVA = "0x202EC90", Offset = "0x202ED91", VA = "0x202EC90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006E51 RID: 28241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D75")]
			[Address(RVA = "0x202ECA0", Offset = "0x202EDA1", VA = "0x202ECA0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E00 RID: 3584
			// (get) Token: 0x06006E52 RID: 28242 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC4")]
			private object Current
			{
				[Token(Token = "0x6007D76")]
				[Address(RVA = "0x202ED00", Offset = "0x202EE01", VA = "0x202ED00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040180EE RID: 98542
			[Token(Token = "0x401C132")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040180EF RID: 98543
			[Token(Token = "0x401C133")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040180F0 RID: 98544
			[Token(Token = "0x401C134")]
			[FieldOffset(Offset = "0x20")]
			public ObjectLoadManager <>4__this;

			// Token: 0x040180F1 RID: 98545
			[Token(Token = "0x401C135")]
			[FieldOffset(Offset = "0x28")]
			private List<ObjectLoader>.Enumerator <>7__wrap1;
		}
	}
}
