using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FxProNS
{
	// Token: 0x020015F3 RID: 5619
	[Token(Token = "0x2000F76")]
	public class BloomHelper : Singleton<BloomHelper>, IDisposable
	{
		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06008013 RID: 32787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB7")]
		public static Material Mat
		{
			[Token(Token = "0x6006A51")]
			[Address(RVA = "0x23F6E60", Offset = "0x23F6F61", VA = "0x23F6E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06008014 RID: 32788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A52")]
		[Address(RVA = "0x23F6F60", Offset = "0x23F7061", VA = "0x23F6F60")]
		public void SetParams(BloomHelperParams _p)
		{
		}

		// Token: 0x06008015 RID: 32789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A53")]
		[Address(RVA = "0x23F2A70", Offset = "0x23F2B71", VA = "0x23F2A70")]
		public void Init()
		{
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A54")]
		[Address(RVA = "0x23F5D40", Offset = "0x23F5E41", VA = "0x23F5D40")]
		public void RenderBloomTexture(RenderTexture source, RenderTexture dest)
		{
		}

		// Token: 0x06008017 RID: 32791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A55")]
		[Address(RVA = "0x23F7080", Offset = "0x23F7181", VA = "0x23F7080")]
		public RenderTexture BlurTex(RenderTexture _input, float _spread)
		{
			return null;
		}

		// Token: 0x06008018 RID: 32792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A56")]
		[Address(RVA = "0x23F6F70", Offset = "0x23F7071", VA = "0x23F6F70")]
		private float[] CalculateBloomTexFactors(float softness)
		{
			return null;
		}

		// Token: 0x06008019 RID: 32793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A57")]
		[Address(RVA = "0x23F7410", Offset = "0x23F7511", VA = "0x23F7410")]
		private float[] MakeSumOne(IList<float> _in)
		{
			return null;
		}

		// Token: 0x0600801A RID: 32794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A58")]
		[Address(RVA = "0x23F3440", Offset = "0x23F3541", VA = "0x23F3440", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A59")]
		[Address(RVA = "0x23F7700", Offset = "0x23F7801", VA = "0x23F7700")]
		public BloomHelper()
		{
		}

		// Token: 0x0401C189 RID: 115081
		[Token(Token = "0x40189BA")]
		[FieldOffset(Offset = "0x0")]
		private static Material _mat;

		// Token: 0x0401C18A RID: 115082
		[Token(Token = "0x40189BB")]
		[FieldOffset(Offset = "0x10")]
		private BloomHelperParams p;

		// Token: 0x0401C18B RID: 115083
		[Token(Token = "0x40189BC")]
		[FieldOffset(Offset = "0x18")]
		private int bloomSamples;

		// Token: 0x0401C18C RID: 115084
		[Token(Token = "0x40189BD")]
		[FieldOffset(Offset = "0x1C")]
		private float bloomBlurRadius;
	}
}
