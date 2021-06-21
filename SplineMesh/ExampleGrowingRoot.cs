using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E43 RID: 3651
	[Token(Token = "0x2000958")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x149270", Offset = "0x149371")]
	[Attribute(Name = "RequireComponent", RVA = "0x149270", Offset = "0x149371")]
	public class ExampleGrowingRoot : MonoBehaviour
	{
		// Token: 0x06006017 RID: 24599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F88")]
		[Address(RVA = "0x2266850", Offset = "0x2266951", VA = "0x2266850")]
		private void OnEnable()
		{
		}

		// Token: 0x06006018 RID: 24600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F89")]
		[Address(RVA = "0x2266CB0", Offset = "0x2266DB1", VA = "0x2266CB0")]
		private void OnDisable()
		{
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8A")]
		[Address(RVA = "0x2266CC0", Offset = "0x2266DC1", VA = "0x2266CC0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8B")]
		[Address(RVA = "0x2266CD0", Offset = "0x2266DD1", VA = "0x2266CD0")]
		private void EditorUpdate()
		{
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8C")]
		[Address(RVA = "0x2266D30", Offset = "0x2266E31", VA = "0x2266D30")]
		private void Contort()
		{
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8D")]
		[Address(RVA = "0x2266860", Offset = "0x2266961", VA = "0x2266860")]
		private void Init()
		{
		}

		// Token: 0x0600601D RID: 24605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8E")]
		[Address(RVA = "0x2266FF0", Offset = "0x22670F1", VA = "0x2266FF0")]
		public ExampleGrowingRoot()
		{
		}

		// Token: 0x0400BF10 RID: 48912
		[Token(Token = "0x4008EEB")]
		[FieldOffset(Offset = "0x18")]
		private GameObject generated;

		// Token: 0x0400BF11 RID: 48913
		[Token(Token = "0x4008EEC")]
		[FieldOffset(Offset = "0x20")]
		private Spline spline;

		// Token: 0x0400BF12 RID: 48914
		[Token(Token = "0x4008EED")]
		[FieldOffset(Offset = "0x28")]
		private float rate;

		// Token: 0x0400BF13 RID: 48915
		[Token(Token = "0x4008EEE")]
		[FieldOffset(Offset = "0x30")]
		private MeshBender meshBender;

		// Token: 0x0400BF14 RID: 48916
		[Token(Token = "0x4008EEF")]
		[FieldOffset(Offset = "0x38")]
		public Mesh mesh;

		// Token: 0x0400BF15 RID: 48917
		[Token(Token = "0x4008EF0")]
		[FieldOffset(Offset = "0x40")]
		public Material material;

		// Token: 0x0400BF16 RID: 48918
		[Token(Token = "0x4008EF1")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		// Token: 0x0400BF17 RID: 48919
		[Token(Token = "0x4008EF2")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 scale;

		// Token: 0x0400BF18 RID: 48920
		[Token(Token = "0x4008EF3")]
		[FieldOffset(Offset = "0x60")]
		public float startScale;

		// Token: 0x0400BF19 RID: 48921
		[Token(Token = "0x4008EF4")]
		[FieldOffset(Offset = "0x64")]
		public float DurationInSecond;
	}
}
