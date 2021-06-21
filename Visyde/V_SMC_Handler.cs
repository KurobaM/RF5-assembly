using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Visyde
{
	// Token: 0x02000C8A RID: 3210
	[Token(Token = "0x2000835")]
	public class V_SMC_Handler : MonoBehaviour
	{
		// Token: 0x060052B0 RID: 21168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D1")]
		[Address(RVA = "0x1E47AA0", Offset = "0x1E47BA1", VA = "0x1E47AA0")]
		private void Update()
		{
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D2")]
		[Address(RVA = "0x1E479F0", Offset = "0x1E47AF1", VA = "0x1E479F0")]
		public void ChangeColor(Color color)
		{
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D3")]
		[Address(RVA = "0x1E47B60", Offset = "0x1E47C61", VA = "0x1E47B60")]
		public V_SMC_Handler()
		{
		}

		// Token: 0x0400B18A RID: 45450
		[Token(Token = "0x4008525")]
		[FieldOffset(Offset = "0x18")]
		public Sprite[] crossHairs;

		// Token: 0x0400B18B RID: 45451
		[Token(Token = "0x4008526")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HideInInspector", RVA = "0x177300", Offset = "0x177401")]
		public int curCrossHair;
	}
}
