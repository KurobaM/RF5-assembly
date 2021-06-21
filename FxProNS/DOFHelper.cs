using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FxProNS
{
	// Token: 0x020015F5 RID: 5621
	[Token(Token = "0x2000F78")]
	public class DOFHelper : Singleton<DOFHelper>, IDisposable
	{
		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x0600801D RID: 32797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB8")]
		public static Material Mat
		{
			[Token(Token = "0x6006A5B")]
			[Address(RVA = "0x23F5790", Offset = "0x23F5891", VA = "0x23F5790")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600801E RID: 32798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5C")]
		[Address(RVA = "0x23F7780", Offset = "0x23F7881", VA = "0x23F7780")]
		public void SetParams(DOFHelperParams p)
		{
		}

		// Token: 0x0600801F RID: 32799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5D")]
		[Address(RVA = "0x23F2670", Offset = "0x23F2771", VA = "0x23F2670")]
		public void Init(bool searchForNonDepthmapAlphaObjects)
		{
		}

		// Token: 0x06008020 RID: 32800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5E")]
		[Address(RVA = "0x23F2940", Offset = "0x23F2A41", VA = "0x23F2940")]
		public void SetBlurRadius(int radius)
		{
		}

		// Token: 0x06008021 RID: 32801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5F")]
		[Address(RVA = "0x23F7790", Offset = "0x23F7891", VA = "0x23F7790")]
		private void CalculateAndUpdateFocalDist()
		{
		}

		// Token: 0x06008022 RID: 32802 RVA: 0x0002E068 File Offset: 0x0002C268
		[Token(Token = "0x6006A60")]
		[Address(RVA = "0x23F79E0", Offset = "0x23F7AE1", VA = "0x23F79E0")]
		private float CalculateAutoFocusDist()
		{
			return 0f;
		}

		// Token: 0x06008023 RID: 32803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A61")]
		[Address(RVA = "0x23F5270", Offset = "0x23F5371", VA = "0x23F5270")]
		public void RenderCOCTexture(RenderTexture src, RenderTexture dest, float blurScale)
		{
		}

		// Token: 0x06008024 RID: 32804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A62")]
		[Address(RVA = "0x23F5960", Offset = "0x23F5A61", VA = "0x23F5960")]
		public void RenderDOFBlur(RenderTexture src, RenderTexture dest, RenderTexture cocTexture)
		{
		}

		// Token: 0x06008025 RID: 32805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A63")]
		[Address(RVA = "0x23F7B70", Offset = "0x23F7C71", VA = "0x23F7B70")]
		public void RenderEffect(RenderTexture src, RenderTexture dest)
		{
		}

		// Token: 0x06008026 RID: 32806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A64")]
		[Address(RVA = "0x23F7B80", Offset = "0x23F7C81", VA = "0x23F7B80")]
		public void RenderEffect(RenderTexture src, RenderTexture dest, bool visualizeCOC)
		{
		}

		// Token: 0x06008027 RID: 32807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A65")]
		[Address(RVA = "0x23F7E50", Offset = "0x23F7F51", VA = "0x23F7E50")]
		public static GameObject[] GetNonDepthmapAlphaObjects()
		{
			return null;
		}

		// Token: 0x06008028 RID: 32808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A66")]
		[Address(RVA = "0x23F8250", Offset = "0x23F8351", VA = "0x23F8250")]
		public static string GetFullPath(GameObject obj)
		{
			return null;
		}

		// Token: 0x06008029 RID: 32809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A67")]
		[Address(RVA = "0x23F3330", Offset = "0x23F3431", VA = "0x23F3330", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600802A RID: 32810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A68")]
		[Address(RVA = "0x23F83A0", Offset = "0x23F84A1", VA = "0x23F83A0")]
		public DOFHelper()
		{
		}

		// Token: 0x0401C19C RID: 115100
		[Token(Token = "0x40189CD")]
		[FieldOffset(Offset = "0x0")]
		private static Material _mat;

		// Token: 0x0401C19D RID: 115101
		[Token(Token = "0x40189CE")]
		[FieldOffset(Offset = "0x10")]
		private DOFHelperParams _p;

		// Token: 0x0401C19E RID: 115102
		[Token(Token = "0x40189CF")]
		[FieldOffset(Offset = "0x18")]
		private float _curAutoFocusDist;
	}
}
