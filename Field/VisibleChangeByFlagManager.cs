using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001118 RID: 4376
	[Token(Token = "0x2000B02")]
	public class VisibleChangeByFlagManager : SingletonMonoBehaviour<VisibleChangeByFlagManager>
	{
		// Token: 0x06006EA4 RID: 28324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB9")]
		[Address(RVA = "0x2032B20", Offset = "0x2032C21", VA = "0x2032B20")]
		private void Start()
		{
		}

		// Token: 0x06006EA5 RID: 28325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBA")]
		[Address(RVA = "0x2032C20", Offset = "0x2032D21", VA = "0x2032C20")]
		public void UpdateObjectVisible()
		{
		}

		// Token: 0x06006EA6 RID: 28326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBB")]
		[Address(RVA = "0x20320D0", Offset = "0x20321D1", VA = "0x20320D0")]
		public void Add(VisibleChangeByFlag visibleChangeByFlag)
		{
		}

		// Token: 0x06006EA7 RID: 28327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBC")]
		[Address(RVA = "0x2031EC0", Offset = "0x2031FC1", VA = "0x2031EC0")]
		public void Remove(VisibleChangeByFlag visibleChangeByFlag)
		{
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBD")]
		[Address(RVA = "0x2030C90", Offset = "0x2030D91", VA = "0x2030C90")]
		public void Add(TextureChangeByFlag textureChangeByFlag)
		{
		}

		// Token: 0x06006EA9 RID: 28329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBE")]
		[Address(RVA = "0x2030B20", Offset = "0x2030C21", VA = "0x2030B20")]
		public void Remove(TextureChangeByFlag textureChangeByFlag)
		{
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBF")]
		[Address(RVA = "0x2032EA0", Offset = "0x2032FA1", VA = "0x2032EA0")]
		private void OnSceneChangeObjectVisible()
		{
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BC0")]
		[Address(RVA = "0x2032EB0", Offset = "0x2032FB1", VA = "0x2032EB0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AED90", Offset = "0x1AEE91")]
		private IEnumerator OnSceneChangeLoad()
		{
			return null;
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC1")]
		[Address(RVA = "0x2032F60", Offset = "0x2033061", VA = "0x2032F60")]
		public void AfterLoadGameData()
		{
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC2")]
		[Address(RVA = "0x2033130", Offset = "0x2033231", VA = "0x2033130")]
		public VisibleChangeByFlagManager()
		{
		}

		// Token: 0x04018137 RID: 98615
		[Token(Token = "0x4014BF4")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<VisibleChangeByFlag> VisibleChangeByFlagHashSet;

		// Token: 0x04018138 RID: 98616
		[Token(Token = "0x4014BF5")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<TextureChangeByFlag> TextureChangeByFlagHashSet;

		// Token: 0x02001119 RID: 4377
		[Token(Token = "0x2001582")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A1B0", Offset = "0x15A2B1")]
		private sealed class <OnSceneChangeLoad>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006EAE RID: 28334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D9A")]
			[Address(RVA = "0x2032F30", Offset = "0x2033031", VA = "0x2032F30")]
			[DebuggerHidden]
			public <OnSceneChangeLoad>d__9(int <>1__state)
			{
			}

			// Token: 0x06006EAF RID: 28335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D9B")]
			[Address(RVA = "0x20331F0", Offset = "0x20332F1", VA = "0x20331F0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006EB0 RID: 28336 RVA: 0x00026058 File Offset: 0x00024258
			[Token(Token = "0x6007D9C")]
			[Address(RVA = "0x20332C0", Offset = "0x20333C1", VA = "0x20332C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06006EB1 RID: 28337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D9D")]
			[Address(RVA = "0x2033260", Offset = "0x2033361", VA = "0x2033260")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000E0F RID: 3599
			// (get) Token: 0x06006EB2 RID: 28338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ECD")]
			private object Current
			{
				[Token(Token = "0x6007D9E")]
				[Address(RVA = "0x2033540", Offset = "0x2033641", VA = "0x2033540", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006EB3 RID: 28339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D9F")]
			[Address(RVA = "0x2033550", Offset = "0x2033651", VA = "0x2033550", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E10 RID: 3600
			// (get) Token: 0x06006EB4 RID: 28340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ECE")]
			private object Current
			{
				[Token(Token = "0x6007DA0")]
				[Address(RVA = "0x20335B0", Offset = "0x20336B1", VA = "0x20335B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04018139 RID: 98617
			[Token(Token = "0x401C14F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401813A RID: 98618
			[Token(Token = "0x401C150")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401813B RID: 98619
			[Token(Token = "0x401C151")]
			[FieldOffset(Offset = "0x20")]
			public VisibleChangeByFlagManager <>4__this;

			// Token: 0x0401813C RID: 98620
			[Token(Token = "0x401C152")]
			[FieldOffset(Offset = "0x28")]
			private HashSet<TextureChangeByFlag>.Enumerator <>7__wrap1;
		}
	}
}
