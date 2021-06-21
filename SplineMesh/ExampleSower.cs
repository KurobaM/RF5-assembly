using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E44 RID: 3652
	[Token(Token = "0x2000959")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x1492F0", Offset = "0x1493F1")]
	[Attribute(Name = "SelectionBaseAttribute", RVA = "0x1492F0", Offset = "0x1493F1")]
	[Attribute(Name = "DisallowMultipleComponent", RVA = "0x1492F0", Offset = "0x1493F1")]
	public class ExampleSower : MonoBehaviour
	{
		// Token: 0x0600601E RID: 24606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8F")]
		[Address(RVA = "0x2267000", Offset = "0x2267101", VA = "0x2267000")]
		private void OnEnable()
		{
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F90")]
		[Address(RVA = "0x2267470", Offset = "0x2267571", VA = "0x2267470")]
		private void OnValidate()
		{
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F91")]
		[Address(RVA = "0x2267480", Offset = "0x2267581", VA = "0x2267480")]
		private void Update()
		{
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F92")]
		[Address(RVA = "0x22674B0", Offset = "0x22675B1", VA = "0x22674B0")]
		public void Sow()
		{
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F93")]
		[Address(RVA = "0x2267980", Offset = "0x2267A81", VA = "0x2267980")]
		public ExampleSower()
		{
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F94")]
		[Address(RVA = "0x22679A0", Offset = "0x2267AA1", VA = "0x22679A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC6A0", Offset = "0x1AC7A1")]
		private void <OnEnable>b__12_0(object s, ListChangedEventArgs<SplineNode> e)
		{
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F95")]
		[Address(RVA = "0x2267C40", Offset = "0x2267D41", VA = "0x2267C40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC6B0", Offset = "0x1AC7B1")]
		private void <OnEnable>b__12_1()
		{
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F96")]
		[Address(RVA = "0x2267C50", Offset = "0x2267D51", VA = "0x2267C50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC6C0", Offset = "0x1AC7C1")]
		private void <OnEnable>b__12_2()
		{
		}

		// Token: 0x0400BF1A RID: 48922
		[Token(Token = "0x4008EF5")]
		[FieldOffset(Offset = "0x18")]
		private GameObject generated;

		// Token: 0x0400BF1B RID: 48923
		[Token(Token = "0x4008EF6")]
		[FieldOffset(Offset = "0x20")]
		private Spline spline;

		// Token: 0x0400BF1C RID: 48924
		[Token(Token = "0x4008EF7")]
		[FieldOffset(Offset = "0x28")]
		private bool toUpdate;

		// Token: 0x0400BF1D RID: 48925
		[Token(Token = "0x4008EF8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject prefab;

		// Token: 0x0400BF1E RID: 48926
		[Token(Token = "0x4008EF9")]
		[FieldOffset(Offset = "0x38")]
		public float scale;

		// Token: 0x0400BF1F RID: 48927
		[Token(Token = "0x4008EFA")]
		[FieldOffset(Offset = "0x3C")]
		public float scaleRange;

		// Token: 0x0400BF20 RID: 48928
		[Token(Token = "0x4008EFB")]
		[FieldOffset(Offset = "0x40")]
		public float spacing;

		// Token: 0x0400BF21 RID: 48929
		[Token(Token = "0x4008EFC")]
		[FieldOffset(Offset = "0x44")]
		public float spacingRange;

		// Token: 0x0400BF22 RID: 48930
		[Token(Token = "0x4008EFD")]
		[FieldOffset(Offset = "0x48")]
		public float offset;

		// Token: 0x0400BF23 RID: 48931
		[Token(Token = "0x4008EFE")]
		[FieldOffset(Offset = "0x4C")]
		public float offsetRange;

		// Token: 0x0400BF24 RID: 48932
		[Token(Token = "0x4008EFF")]
		[FieldOffset(Offset = "0x50")]
		public bool isRandomYaw;

		// Token: 0x0400BF25 RID: 48933
		[Token(Token = "0x4008F00")]
		[FieldOffset(Offset = "0x54")]
		public int randomSeed;
	}
}
