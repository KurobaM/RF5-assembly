using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DB6 RID: 3510
	[Token(Token = "0x20008F2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148AE0", Offset = "0x148BE1")]
	public class MouseCursor : MonoBehaviour
	{
		// Token: 0x06005ADA RID: 23258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B00")]
		[Address(RVA = "0x2488B80", Offset = "0x2488C81", VA = "0x2488B80")]
		private void Start()
		{
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B01")]
		[Address(RVA = "0x2488B90", Offset = "0x2488C91", VA = "0x2488B90")]
		public void SetTexture(Texture2D texture)
		{
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B02")]
		[Address(RVA = "0x2488C60", Offset = "0x2488D61", VA = "0x2488C60")]
		private void OnGUI()
		{
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B03")]
		[Address(RVA = "0x2488D90", Offset = "0x2488E91", VA = "0x2488D90")]
		public MouseCursor()
		{
		}

		// Token: 0x0400BA26 RID: 47654
		[Token(Token = "0x4008AFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture2D _texture;

		// Token: 0x0400BA27 RID: 47655
		[Token(Token = "0x4008B00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _hotspotOffset;

		// Token: 0x0400BA28 RID: 47656
		[Token(Token = "0x4008B01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x17CC90", Offset = "0x17CD91")]
		private int _sizeScale;

		// Token: 0x0400BA29 RID: 47657
		[Token(Token = "0x4008B02")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _depth;

		// Token: 0x0400BA2A RID: 47658
		[Token(Token = "0x4008B03")]
		[FieldOffset(Offset = "0x30")]
		private GUIContent _content;
	}
}
