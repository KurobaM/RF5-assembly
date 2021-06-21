using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Funly.SkyStudio
{
	// Token: 0x02000E08 RID: 3592
	[Token(Token = "0x200092F")]
	[Attribute(Name = "RequireComponent", RVA = "0x148D80", Offset = "0x148E81")]
	public class LoadOverheadDepthTexture : MonoBehaviour
	{
		// Token: 0x06005D60 RID: 23904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D77")]
		[Address(RVA = "0x23D8880", Offset = "0x23D8981", VA = "0x23D8880")]
		private void Start()
		{
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D78")]
		[Address(RVA = "0x23D8920", Offset = "0x23D8A21", VA = "0x23D8920")]
		private void Update()
		{
		}

		// Token: 0x06005D62 RID: 23906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D79")]
		[Address(RVA = "0x23D8950", Offset = "0x23D8A51", VA = "0x23D8950")]
		public LoadOverheadDepthTexture()
		{
		}

		// Token: 0x0400BD8A RID: 48522
		[Token(Token = "0x4008DF7")]
		[FieldOffset(Offset = "0x18")]
		private WeatherDepthCamera m_RainCamera;

		// Token: 0x0400BD8B RID: 48523
		[Token(Token = "0x4008DF8")]
		[FieldOffset(Offset = "0x20")]
		private RawImage m_Image;
	}
}
