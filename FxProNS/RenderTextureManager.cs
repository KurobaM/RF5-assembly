using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FxProNS
{
	// Token: 0x020015F8 RID: 5624
	[Token(Token = "0x2000F7B")]
	public class RenderTextureManager : IDisposable
	{
		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x0600802F RID: 32815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BBA")]
		public static RenderTextureManager Instance
		{
			[Token(Token = "0x6006A6D")]
			[Address(RVA = "0x23F3160", Offset = "0x23F3261", VA = "0x23F3160")]
			get
			{
				return null;
			}
		}

		// Token: 0x06008030 RID: 32816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A6E")]
		[Address(RVA = "0x23F3800", Offset = "0x23F3901", VA = "0x23F3800")]
		public RenderTexture RequestRenderTexture(int _width, int _height, int _depth, RenderTextureFormat _format)
		{
			return null;
		}

		// Token: 0x06008031 RID: 32817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A6F")]
		[Address(RVA = "0x23F5890", Offset = "0x23F5991", VA = "0x23F5890")]
		public RenderTexture ReleaseRenderTexture(RenderTexture _tex)
		{
			return null;
		}

		// Token: 0x06008032 RID: 32818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A70")]
		[Address(RVA = "0x23F51C0", Offset = "0x23F52C1", VA = "0x23F51C0")]
		public void SafeAssign(ref RenderTexture a, RenderTexture b)
		{
		}

		// Token: 0x06008033 RID: 32819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A71")]
		[Address(RVA = "0x23F8420", Offset = "0x23F8521", VA = "0x23F8420")]
		public void MakeRenderTextureNonAvailable(RenderTexture _tex)
		{
		}

		// Token: 0x06008034 RID: 32820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A72")]
		[Address(RVA = "0x23F84C0", Offset = "0x23F85C1", VA = "0x23F84C0")]
		private RenderTexture CreateNewTexture(int _width, int _height, int _depth, RenderTextureFormat _format)
		{
			return null;
		}

		// Token: 0x06008035 RID: 32821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A73")]
		[Address(RVA = "0x23F85A0", Offset = "0x23F86A1", VA = "0x23F85A0")]
		public void PrintRenderTextureStats()
		{
		}

		// Token: 0x06008036 RID: 32822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A74")]
		[Address(RVA = "0x23F8890", Offset = "0x23F8991", VA = "0x23F8890")]
		private string RenderTexToString(RenderTexture _rt)
		{
			return null;
		}

		// Token: 0x06008037 RID: 32823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A75")]
		[Address(RVA = "0x23F8BC0", Offset = "0x23F8CC1", VA = "0x23F8BC0")]
		private void PrintRenderTexturesCount(string _prefix = "")
		{
		}

		// Token: 0x06008038 RID: 32824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A76")]
		[Address(RVA = "0x23F62D0", Offset = "0x23F63D1", VA = "0x23F62D0")]
		public void ReleaseAllRenderTextures()
		{
		}

		// Token: 0x06008039 RID: 32825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A77")]
		[Address(RVA = "0x23F8E20", Offset = "0x23F8F21", VA = "0x23F8E20")]
		public void PrintBalance()
		{
		}

		// Token: 0x0600803A RID: 32826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A78")]
		[Address(RVA = "0x23F31F0", Offset = "0x23F32F1", VA = "0x23F31F0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600803B RID: 32827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A79")]
		[Address(RVA = "0x23F8410", Offset = "0x23F8511", VA = "0x23F8410")]
		public RenderTextureManager()
		{
		}

		// Token: 0x0401C1A5 RID: 115109
		[Token(Token = "0x40189D6")]
		[FieldOffset(Offset = "0x0")]
		private static RenderTextureManager instance;

		// Token: 0x0401C1A6 RID: 115110
		[Token(Token = "0x40189D7")]
		[FieldOffset(Offset = "0x10")]
		private List<RenderTexture> allRenderTextures;

		// Token: 0x0401C1A7 RID: 115111
		[Token(Token = "0x40189D8")]
		[FieldOffset(Offset = "0x18")]
		private List<RenderTexture> availableRenderTextures;
	}
}
