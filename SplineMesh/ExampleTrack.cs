using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E46 RID: 3654
	[Token(Token = "0x200095B")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x149350", Offset = "0x149451")]
	[Attribute(Name = "SelectionBaseAttribute", RVA = "0x149350", Offset = "0x149451")]
	[Attribute(Name = "DisallowMultipleComponent", RVA = "0x149350", Offset = "0x149451")]
	public class ExampleTrack : MonoBehaviour
	{
		// Token: 0x06006029 RID: 24617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9A")]
		[Address(RVA = "0x22680E0", Offset = "0x22681E1", VA = "0x22680E0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9B")]
		[Address(RVA = "0x22683C0", Offset = "0x22684C1", VA = "0x22683C0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9C")]
		[Address(RVA = "0x2268440", Offset = "0x2268541", VA = "0x2268440")]
		private void Update()
		{
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9D")]
		[Address(RVA = "0x2268490", Offset = "0x2268591", VA = "0x2268490")]
		public void CreateMeshes()
		{
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9E")]
		[Address(RVA = "0x22695F0", Offset = "0x22696F1", VA = "0x22695F0")]
		public ExampleTrack()
		{
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9F")]
		[Address(RVA = "0x2269670", Offset = "0x2269771", VA = "0x2269670")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC6D0", Offset = "0x1AC7D1")]
		private void <OnEnable>b__5_0(object s, ListChangedEventArgs<SplineNode> e)
		{
		}

		// Token: 0x0400BF2B RID: 48939
		[Token(Token = "0x4008F06")]
		[FieldOffset(Offset = "0x18")]
		private GameObject generated;

		// Token: 0x0400BF2C RID: 48940
		[Token(Token = "0x4008F07")]
		[FieldOffset(Offset = "0x20")]
		private Spline spline;

		// Token: 0x0400BF2D RID: 48941
		[Token(Token = "0x4008F08")]
		[FieldOffset(Offset = "0x28")]
		private bool toUpdate;

		// Token: 0x0400BF2E RID: 48942
		[Token(Token = "0x4008F09")]
		[FieldOffset(Offset = "0x30")]
		public List<TrackSegment> segments;

		// Token: 0x0400BF2F RID: 48943
		[Token(Token = "0x4008F0A")]
		[FieldOffset(Offset = "0x38")]
		public bool updateInPlayMode;

		// Token: 0x02000E47 RID: 3655
		[Token(Token = "0x2001457")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159900", Offset = "0x159A01")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006030 RID: 24624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B3F")]
			[Address(RVA = "0x2269800", Offset = "0x2269901", VA = "0x2269800")]
			public <>c()
			{
			}

			// Token: 0x06006031 RID: 24625 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B40")]
			[Address(RVA = "0x2269810", Offset = "0x2269911", VA = "0x2269810")]
			internal GameObject <CreateMeshes>b__8_0(Transform child)
			{
				return null;
			}

			// Token: 0x0400BF30 RID: 48944
			[Token(Token = "0x401BC31")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ExampleTrack.<>c <>9;

			// Token: 0x0400BF31 RID: 48945
			[Token(Token = "0x401BC32")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Transform, GameObject> <>9__8_0;
		}
	}
}
