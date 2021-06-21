using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DD0 RID: 3536
	[Token(Token = "0x20008FE")]
	public class NearbyStarRenderer : BaseStarDataRenderer
	{
		// Token: 0x06005B87 RID: 23431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA8")]
		[Address(RVA = "0x23D8960", Offset = "0x23D8A61", VA = "0x23D8960")]
		private RenderTexture CreateRenderTexture(string name, int renderTextureSize, RenderTextureFormat format)
		{
			return null;
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA9")]
		[Address(RVA = "0x23D89D0", Offset = "0x23D8AD1", VA = "0x23D89D0")]
		private Material GetNearbyStarMaterial(Vector4 randomSeed, int starCount)
		{
			return null;
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BAA")]
		[Address(RVA = "0x23D8B30", Offset = "0x23D8C31", VA = "0x23D8B30")]
		private void WriteDebugTexture(RenderTexture rt, string path)
		{
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAB")]
		[Address(RVA = "0x23D8CE0", Offset = "0x23D8DE1", VA = "0x23D8CE0")]
		private Texture2D GetStarListTexture(string starTexKey, out int validStarPixelCount)
		{
			return null;
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAC")]
		[Address(RVA = "0x23D8FB0", Offset = "0x23D90B1", VA = "0x23D8FB0", Slot = "4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ABCB0", Offset = "0x1ABDB1")]
		public override IEnumerator ComputeStarData()
		{
			return null;
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAD")]
		[Address(RVA = "0x23D8B70", Offset = "0x23D8C71", VA = "0x23D8B70")]
		private Texture2D ConvertToTexture2D(RenderTexture rt)
		{
			return null;
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BAE")]
		[Address(RVA = "0x23D9060", Offset = "0x23D9161", VA = "0x23D9060")]
		public NearbyStarRenderer()
		{
		}

		// Token: 0x0400BB07 RID: 47879
		[Token(Token = "0x4008B8C")]
		private const int kMaxStars = 2000;

		// Token: 0x0400BB08 RID: 47880
		[Token(Token = "0x4008B8D")]
		private const int kStarPointTextureWidth = 2048;

		// Token: 0x0400BB09 RID: 47881
		[Token(Token = "0x4008B8E")]
		private const float kStarPaddingRadiusMultipler = 2.1f;

		// Token: 0x02000DD1 RID: 3537
		[Token(Token = "0x200143F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159820", Offset = "0x159921")]
		private sealed class <ComputeStarData>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005B8E RID: 23438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A96")]
			[Address(RVA = "0x23D9030", Offset = "0x23D9131", VA = "0x23D9030")]
			[DebuggerHidden]
			public <ComputeStarData>d__7(int <>1__state)
			{
			}

			// Token: 0x06005B8F RID: 23439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A97")]
			[Address(RVA = "0x23D9070", Offset = "0x23D9171", VA = "0x23D9070", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005B90 RID: 23440 RVA: 0x0001E180 File Offset: 0x0001C380
			[Token(Token = "0x6007A98")]
			[Address(RVA = "0x23D9080", Offset = "0x23D9181", VA = "0x23D9080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000BB4 RID: 2996
			// (get) Token: 0x06005B91 RID: 23441 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E57")]
			private object Current
			{
				[Token(Token = "0x6007A99")]
				[Address(RVA = "0x23D9380", Offset = "0x23D9481", VA = "0x23D9380", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B92 RID: 23442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A9A")]
			[Address(RVA = "0x23D9390", Offset = "0x23D9491", VA = "0x23D9390", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000BB5 RID: 2997
			// (get) Token: 0x06005B93 RID: 23443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E58")]
			private object Current
			{
				[Token(Token = "0x6007A9B")]
				[Address(RVA = "0x23D93F0", Offset = "0x23D94F1", VA = "0x23D93F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400BB0A RID: 47882
			[Token(Token = "0x401BB92")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BB0B RID: 47883
			[Token(Token = "0x401BB93")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400BB0C RID: 47884
			[Token(Token = "0x401BB94")]
			[FieldOffset(Offset = "0x20")]
			public NearbyStarRenderer <>4__this;
		}
	}
}
