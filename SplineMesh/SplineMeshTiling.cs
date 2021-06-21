using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E54 RID: 3668
	[Token(Token = "0x2000964")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x1495E0", Offset = "0x1496E1")]
	[Attribute(Name = "SelectionBaseAttribute", RVA = "0x1495E0", Offset = "0x1496E1")]
	[Attribute(Name = "DisallowMultipleComponent", RVA = "0x1495E0", Offset = "0x1496E1")]
	public class SplineMeshTiling : MonoBehaviour
	{
		// Token: 0x06006088 RID: 24712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE7")]
		[Address(RVA = "0x2383760", Offset = "0x2383861", VA = "0x2383760")]
		private void OnEnable()
		{
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE8")]
		[Address(RVA = "0x2383A00", Offset = "0x2383B01", VA = "0x2383A00")]
		private void OnValidate()
		{
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE9")]
		[Address(RVA = "0x2383A80", Offset = "0x2383B81", VA = "0x2383A80")]
		private void Update()
		{
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FEA")]
		[Address(RVA = "0x2383AD0", Offset = "0x2383BD1", VA = "0x2383AD0")]
		public void CreateMeshes()
		{
		}

		// Token: 0x0600608C RID: 24716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FEB")]
		[Address(RVA = "0x23842E0", Offset = "0x23843E1", VA = "0x23842E0")]
		private GameObject FindOrCreate(string name)
		{
			return null;
		}

		// Token: 0x0600608D RID: 24717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FEC")]
		[Address(RVA = "0x2384A70", Offset = "0x2384B71", VA = "0x2384A70")]
		public SplineMeshTiling()
		{
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FED")]
		[Address(RVA = "0x2384B00", Offset = "0x2384C01", VA = "0x2384B00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC700", Offset = "0x1AC801")]
		private void <OnEnable>b__13_0(object s, ListChangedEventArgs<SplineNode> e)
		{
		}

		// Token: 0x0400BF7B RID: 49019
		[Token(Token = "0x4008F42")]
		[FieldOffset(Offset = "0x18")]
		private GameObject generated;

		// Token: 0x0400BF7C RID: 49020
		[Token(Token = "0x4008F43")]
		[FieldOffset(Offset = "0x20")]
		private Spline spline;

		// Token: 0x0400BF7D RID: 49021
		[Token(Token = "0x4008F44")]
		[FieldOffset(Offset = "0x28")]
		private bool toUpdate;

		// Token: 0x0400BF7E RID: 49022
		[Token(Token = "0x4008F45")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E7E0", Offset = "0x17E8E1")]
		public Mesh mesh;

		// Token: 0x0400BF7F RID: 49023
		[Token(Token = "0x4008F46")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E820", Offset = "0x17E921")]
		public Material material;

		// Token: 0x0400BF80 RID: 49024
		[Token(Token = "0x4008F47")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E860", Offset = "0x17E961")]
		public PhysicMaterial physicMaterial;

		// Token: 0x0400BF81 RID: 49025
		[Token(Token = "0x4008F48")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E8A0", Offset = "0x17E9A1")]
		public Vector3 translation;

		// Token: 0x0400BF82 RID: 49026
		[Token(Token = "0x4008F49")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E8E0", Offset = "0x17E9E1")]
		public Vector3 rotation;

		// Token: 0x0400BF83 RID: 49027
		[Token(Token = "0x4008F4A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E920", Offset = "0x17EA21")]
		public Vector3 scale;

		// Token: 0x0400BF84 RID: 49028
		[Token(Token = "0x4008F4B")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E960", Offset = "0x17EA61")]
		public bool generateCollider;

		// Token: 0x0400BF85 RID: 49029
		[Token(Token = "0x4008F4C")]
		[FieldOffset(Offset = "0x6D")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E9A0", Offset = "0x17EAA1")]
		public bool updateInPlayMode;

		// Token: 0x0400BF86 RID: 49030
		[Token(Token = "0x4008F4D")]
		[FieldOffset(Offset = "0x6E")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E9E0", Offset = "0x17EAE1")]
		public bool curveSpace;

		// Token: 0x0400BF87 RID: 49031
		[Token(Token = "0x4008F4E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17EA20", Offset = "0x17EB21")]
		public MeshBender.FillingMode mode;

		// Token: 0x02000E55 RID: 3669
		[Token(Token = "0x200145C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159930", Offset = "0x159A31")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006090 RID: 24720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B51")]
			[Address(RVA = "0x2384B80", Offset = "0x2384C81", VA = "0x2384B80")]
			public <>c()
			{
			}

			// Token: 0x06006091 RID: 24721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B52")]
			[Address(RVA = "0x2384B90", Offset = "0x2384C91", VA = "0x2384B90")]
			internal GameObject <CreateMeshes>b__16_0(Transform child)
			{
				return null;
			}

			// Token: 0x0400BF88 RID: 49032
			[Token(Token = "0x401BC45")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SplineMeshTiling.<>c <>9;

			// Token: 0x0400BF89 RID: 49033
			[Token(Token = "0x401BC46")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Transform, GameObject> <>9__16_0;
		}
	}
}
