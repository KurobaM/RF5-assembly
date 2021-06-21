using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E1A RID: 3610
	[Token(Token = "0x200093F")]
	[Attribute(Name = "RequireComponent", RVA = "0x148F50", Offset = "0x149051")]
	public class WeatherDepthCamera : MonoBehaviour
	{
		// Token: 0x06005DE7 RID: 24039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DFE")]
		[Address(RVA = "0x23EFF70", Offset = "0x23F0071", VA = "0x23EFF70")]
		private void Start()
		{
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DFF")]
		[Address(RVA = "0x23EFFF0", Offset = "0x23F00F1", VA = "0x23EFFF0")]
		private void Update()
		{
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E00")]
		[Address(RVA = "0x23F0060", Offset = "0x23F0161", VA = "0x23F0060")]
		private void RenderOverheadCamera()
		{
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E01")]
		[Address(RVA = "0x23F0260", Offset = "0x23F0361", VA = "0x23F0260")]
		private void PrepareRenderTexture()
		{
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E02")]
		[Address(RVA = "0x23F0450", Offset = "0x23F0551", VA = "0x23F0450")]
		public WeatherDepthCamera()
		{
		}

		// Token: 0x0400BDE9 RID: 48617
		[Token(Token = "0x4008E4D")]
		[FieldOffset(Offset = "0x18")]
		private Camera m_DepthCamera;

		// Token: 0x0400BDEA RID: 48618
		[Token(Token = "0x4008E4E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E550", Offset = "0x17E651")]
		public Shader depthShader;

		// Token: 0x0400BDEB RID: 48619
		[Token(Token = "0x4008E4F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HideInInspector", RVA = "0x17E590", Offset = "0x17E691")]
		public RenderTexture overheadDepthTexture;

		// Token: 0x0400BDEC RID: 48620
		[Token(Token = "0x4008E50")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E5A0", Offset = "0x17E6A1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17E5A0", Offset = "0x17E6A1")]
		public int renderFrameInterval;

		// Token: 0x0400BDED RID: 48621
		[Token(Token = "0x4008E51")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E600", Offset = "0x17E701")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17E600", Offset = "0x17E701")]
		public int textureResolution;
	}
}
