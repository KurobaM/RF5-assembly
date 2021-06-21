using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200110F RID: 4367
	[Token(Token = "0x2000AFE")]
	public class TextureChangeByFlag : ObjectLoader
	{
		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06006E76 RID: 28278 RVA: 0x00025F98 File Offset: 0x00024198
		[Token(Token = "0x17000AFB")]
		public bool IsInit
		{
			[Token(Token = "0x6005BA0")]
			[Address(RVA = "0x2030A10", Offset = "0x2030B11", VA = "0x2030A10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006E77 RID: 28279 RVA: 0x00025FB0 File Offset: 0x000241B0
		[Token(Token = "0x6005BA1")]
		[Address(RVA = "0x2030A20", Offset = "0x2030B21", VA = "0x2030A20")]
		public new bool NeedsLoad()
		{
			return default(bool);
		}

		// Token: 0x06006E78 RID: 28280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA2")]
		[Address(RVA = "0x2030A30", Offset = "0x2030B31", VA = "0x2030A30", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06006E79 RID: 28281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA3")]
		[Address(RVA = "0x2030B90", Offset = "0x2030C91", VA = "0x2030B90", Slot = "6")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA4")]
		[Address(RVA = "0x2030D00", Offset = "0x2030E01", VA = "0x2030D00", Slot = "7")]
		public virtual void UpdateObjectVisible()
		{
		}

		// Token: 0x06006E7B RID: 28283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0x2030D10", Offset = "0x2030E11", VA = "0x2030D10")]
		protected void SetTargetActive(bool setValue)
		{
		}

		// Token: 0x06006E7C RID: 28284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA6")]
		[Address(RVA = "0x2030D20", Offset = "0x2030E21", VA = "0x2030D20", Slot = "8")]
		protected virtual void SetTexture(Renderer[] renderers, Material material, Texture texture, int propertyId)
		{
		}

		// Token: 0x06006E7D RID: 28285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0x2030F30", Offset = "0x2031031", VA = "0x2030F30", Slot = "4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AECB0", Offset = "0x1AEDB1")]
		public override IEnumerator Load()
		{
			return null;
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA8")]
		[Address(RVA = "0x2030FC0", Offset = "0x20310C1", VA = "0x2030FC0")]
		public TextureChangeByFlag()
		{
		}

		// Token: 0x0401810A RID: 98570
		[Token(Token = "0x4014BD3")]
		[FieldOffset(Offset = "0x2C")]
		protected int MainTexPropertyId;

		// Token: 0x0401810B RID: 98571
		[Token(Token = "0x4014BD4")]
		[FieldOffset(Offset = "0x30")]
		protected bool _IsInit;

		// Token: 0x02001110 RID: 4368
		[Token(Token = "0x200157D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A160", Offset = "0x15A261")]
		private sealed class <Load>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006E7F RID: 28287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D85")]
			[Address(RVA = "0x2030F90", Offset = "0x2031091", VA = "0x2030F90")]
			[DebuggerHidden]
			public <Load>d__10(int <>1__state)
			{
			}

			// Token: 0x06006E80 RID: 28288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D86")]
			[Address(RVA = "0x2030FD0", Offset = "0x20310D1", VA = "0x2030FD0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006E81 RID: 28289 RVA: 0x00025FC8 File Offset: 0x000241C8
			[Token(Token = "0x6007D87")]
			[Address(RVA = "0x2030FE0", Offset = "0x20310E1", VA = "0x2030FE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E0A RID: 3594
			// (get) Token: 0x06006E82 RID: 28290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC9")]
			private object Current
			{
				[Token(Token = "0x6007D88")]
				[Address(RVA = "0x2031040", Offset = "0x2031141", VA = "0x2031040", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006E83 RID: 28291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D89")]
			[Address(RVA = "0x2031050", Offset = "0x2031151", VA = "0x2031050", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E0B RID: 3595
			// (get) Token: 0x06006E84 RID: 28292 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ECA")]
			private object Current
			{
				[Token(Token = "0x6007D8A")]
				[Address(RVA = "0x20310B0", Offset = "0x20311B1", VA = "0x20310B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401810C RID: 98572
			[Token(Token = "0x401C143")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401810D RID: 98573
			[Token(Token = "0x401C144")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;
		}
	}
}
