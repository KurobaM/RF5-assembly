using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E3F RID: 3647
	[Token(Token = "0x2000954")]
	[Serializable]
	public class SplineNode
	{
		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06005FF5 RID: 24565 RVA: 0x00020268 File Offset: 0x0001E468
		// (set) Token: 0x06005FF6 RID: 24566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D1")]
		public Vector3 Position
		{
			[Token(Token = "0x6004F66")]
			[Address(RVA = "0x2384BB0", Offset = "0x2384CB1", VA = "0x2384BB0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004F67")]
			[Address(RVA = "0x237EAB0", Offset = "0x237EBB1", VA = "0x237EAB0")]
			set
			{
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06005FF7 RID: 24567 RVA: 0x00020280 File Offset: 0x0001E480
		// (set) Token: 0x06005FF8 RID: 24568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D2")]
		public Vector3 Direction
		{
			[Token(Token = "0x6004F68")]
			[Address(RVA = "0x2384BC0", Offset = "0x2384CC1", VA = "0x2384BC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004F69")]
			[Address(RVA = "0x2381E50", Offset = "0x2381F51", VA = "0x2381E50")]
			set
			{
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06005FF9 RID: 24569 RVA: 0x00020298 File Offset: 0x0001E498
		// (set) Token: 0x06005FFA RID: 24570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D3")]
		public Vector3 Up
		{
			[Token(Token = "0x6004F6A")]
			[Address(RVA = "0x2384BD0", Offset = "0x2384CD1", VA = "0x2384BD0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004F6B")]
			[Address(RVA = "0x237EB90", Offset = "0x237EC91", VA = "0x237EB90")]
			set
			{
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06005FFB RID: 24571 RVA: 0x000202B0 File Offset: 0x0001E4B0
		// (set) Token: 0x06005FFC RID: 24572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D4")]
		public Vector2 Scale
		{
			[Token(Token = "0x6004F6C")]
			[Address(RVA = "0x2384BE0", Offset = "0x2384CE1", VA = "0x2384BE0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004F6D")]
			[Address(RVA = "0x2381FF0", Offset = "0x23820F1", VA = "0x2381FF0")]
			set
			{
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06005FFD RID: 24573 RVA: 0x000202C8 File Offset: 0x0001E4C8
		// (set) Token: 0x06005FFE RID: 24574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D5")]
		public float Roll
		{
			[Token(Token = "0x6004F6E")]
			[Address(RVA = "0x2384BF0", Offset = "0x2384CF1", VA = "0x2384BF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004F6F")]
			[Address(RVA = "0x2381F30", Offset = "0x2382031", VA = "0x2381F30")]
			set
			{
			}
		}

		// Token: 0x06005FFF RID: 24575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F70")]
		[Address(RVA = "0x237EC70", Offset = "0x237ED71", VA = "0x237EC70")]
		public SplineNode(Vector3 position, Vector3 direction)
		{
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06006000 RID: 24576 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06006001 RID: 24577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000009")]
		[Attribute(Name = "HideInInspector", RVA = "0x1B8550", Offset = "0x1B8651")]
		public event EventHandler Changed
		{
			[Token(Token = "0x6004F71")]
			[Address(RVA = "0x23818F0", Offset = "0x23819F1", VA = "0x23818F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC680", Offset = "0x1AC781")]
			add
			{
			}
			[Token(Token = "0x6004F72")]
			[Address(RVA = "0x2381840", Offset = "0x2381941", VA = "0x2381840")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC690", Offset = "0x1AC791")]
			remove
			{
			}
		}

		// Token: 0x0400BEFA RID: 48890
		[Token(Token = "0x4008ED5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 position;

		// Token: 0x0400BEFB RID: 48891
		[Token(Token = "0x4008ED6")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 direction;

		// Token: 0x0400BEFC RID: 48892
		[Token(Token = "0x4008ED7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 up;

		// Token: 0x0400BEFD RID: 48893
		[Token(Token = "0x4008ED8")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector2 scale;

		// Token: 0x0400BEFE RID: 48894
		[Token(Token = "0x4008ED9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float roll;
	}
}
