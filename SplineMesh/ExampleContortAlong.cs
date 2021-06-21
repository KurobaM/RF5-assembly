using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E41 RID: 3649
	[Token(Token = "0x2000956")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x149170", Offset = "0x149271")]
	[Attribute(Name = "RequireComponent", RVA = "0x149170", Offset = "0x149271")]
	public class ExampleContortAlong : MonoBehaviour
	{
		// Token: 0x0600600B RID: 24587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F7C")]
		[Address(RVA = "0x2265F20", Offset = "0x2266021", VA = "0x2265F20")]
		private void OnEnable()
		{
		}

		// Token: 0x0600600C RID: 24588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F7D")]
		[Address(RVA = "0x2266380", Offset = "0x2266481", VA = "0x2266380")]
		private void OnDisable()
		{
		}

		// Token: 0x0600600D RID: 24589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F7E")]
		[Address(RVA = "0x2266390", Offset = "0x2266491", VA = "0x2266390")]
		private void OnValidate()
		{
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F7F")]
		[Address(RVA = "0x22663A0", Offset = "0x22664A1", VA = "0x22663A0")]
		private void EditorUpdate()
		{
		}

		// Token: 0x0600600F RID: 24591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F80")]
		[Address(RVA = "0x2266400", Offset = "0x2266501", VA = "0x2266400")]
		private void Contort()
		{
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F81")]
		[Address(RVA = "0x2265F30", Offset = "0x2266031", VA = "0x2265F30")]
		private void Init()
		{
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F82")]
		[Address(RVA = "0x22664C0", Offset = "0x22665C1", VA = "0x22664C0")]
		public ExampleContortAlong()
		{
		}

		// Token: 0x0400BF02 RID: 48898
		[Token(Token = "0x4008EDD")]
		[FieldOffset(Offset = "0x18")]
		private Spline spline;

		// Token: 0x0400BF03 RID: 48899
		[Token(Token = "0x4008EDE")]
		[FieldOffset(Offset = "0x20")]
		private float rate;

		// Token: 0x0400BF04 RID: 48900
		[Token(Token = "0x4008EDF")]
		[FieldOffset(Offset = "0x28")]
		private MeshBender meshBender;

		// Token: 0x0400BF05 RID: 48901
		[Token(Token = "0x4008EE0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HideInInspector", RVA = "0x17E7B0", Offset = "0x17E8B1")]
		public GameObject generated;

		// Token: 0x0400BF06 RID: 48902
		[Token(Token = "0x4008EE1")]
		[FieldOffset(Offset = "0x38")]
		public Mesh mesh;

		// Token: 0x0400BF07 RID: 48903
		[Token(Token = "0x4008EE2")]
		[FieldOffset(Offset = "0x40")]
		public Material material;

		// Token: 0x0400BF08 RID: 48904
		[Token(Token = "0x4008EE3")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		// Token: 0x0400BF09 RID: 48905
		[Token(Token = "0x4008EE4")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 scale;

		// Token: 0x0400BF0A RID: 48906
		[Token(Token = "0x4008EE5")]
		[FieldOffset(Offset = "0x60")]
		public float DurationInSecond;
	}
}
