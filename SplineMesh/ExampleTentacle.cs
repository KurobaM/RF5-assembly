using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E45 RID: 3653
	[Token(Token = "0x200095A")]
	[Attribute(Name = "DisallowMultipleComponent", RVA = "0x149340", Offset = "0x149441")]
	public class ExampleTentacle : MonoBehaviour
	{
		// Token: 0x06006026 RID: 24614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F97")]
		[Address(RVA = "0x2267C60", Offset = "0x2267D61", VA = "0x2267C60")]
		private void OnEnable()
		{
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F98")]
		[Address(RVA = "0x2267CC0", Offset = "0x2267DC1", VA = "0x2267CC0")]
		private void OnValidate()
		{
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F99")]
		[Address(RVA = "0x22680D0", Offset = "0x22681D1", VA = "0x22680D0")]
		public ExampleTentacle()
		{
		}

		// Token: 0x0400BF26 RID: 48934
		[Token(Token = "0x4008F01")]
		[FieldOffset(Offset = "0x18")]
		private Spline spline;

		// Token: 0x0400BF27 RID: 48935
		[Token(Token = "0x4008F02")]
		[FieldOffset(Offset = "0x20")]
		public float startScale;

		// Token: 0x0400BF28 RID: 48936
		[Token(Token = "0x4008F03")]
		[FieldOffset(Offset = "0x24")]
		public float endScale;

		// Token: 0x0400BF29 RID: 48937
		[Token(Token = "0x4008F04")]
		[FieldOffset(Offset = "0x28")]
		public float startRoll;

		// Token: 0x0400BF2A RID: 48938
		[Token(Token = "0x4008F05")]
		[FieldOffset(Offset = "0x2C")]
		public float endRoll;
	}
}
