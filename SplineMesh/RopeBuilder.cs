using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E4A RID: 3658
	[Token(Token = "0x200095E")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x1493A0", Offset = "0x1494A1")]
	[Attribute(Name = "RequireComponent", RVA = "0x1493A0", Offset = "0x1494A1")]
	public class RopeBuilder : MonoBehaviour
	{
		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06006034 RID: 24628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D7")]
		private GameObject Generated
		{
			[Token(Token = "0x6004FA2")]
			[Address(RVA = "0x237DC60", Offset = "0x237DD61", VA = "0x237DC60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA3")]
		[Address(RVA = "0x237DFC0", Offset = "0x237E0C1", VA = "0x237DFC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA4")]
		[Address(RVA = "0x237E030", Offset = "0x237E131", VA = "0x237E030")]
		private void OnValidate()
		{
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA5")]
		[Address(RVA = "0x237E040", Offset = "0x237E141", VA = "0x237E040")]
		private void Update()
		{
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA6")]
		[Address(RVA = "0x237E5E0", Offset = "0x237E6E1", VA = "0x237E5E0")]
		private void UpdateNodes()
		{
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA7")]
		[Address(RVA = "0x237E340", Offset = "0x237E441", VA = "0x237E340")]
		private void UpdateSpline()
		{
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA8")]
		[Address(RVA = "0x237E150", Offset = "0x237E251", VA = "0x237E150")]
		private void Generate()
		{
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA9")]
		[Address(RVA = "0x237F6D0", Offset = "0x237F7D1", VA = "0x237F6D0")]
		public RopeBuilder()
		{
		}

		// Token: 0x0400BF39 RID: 48953
		[Token(Token = "0x4008F12")]
		[FieldOffset(Offset = "0x18")]
		private bool toUpdate;

		// Token: 0x0400BF3A RID: 48954
		[Token(Token = "0x4008F13")]
		[FieldOffset(Offset = "0x20")]
		private GameObject generated;

		// Token: 0x0400BF3B RID: 48955
		[Token(Token = "0x4008F14")]
		[FieldOffset(Offset = "0x28")]
		private Spline spline;

		// Token: 0x0400BF3C RID: 48956
		[Token(Token = "0x4008F15")]
		[FieldOffset(Offset = "0x30")]
		private GameObject firstSegment;

		// Token: 0x0400BF3D RID: 48957
		[Token(Token = "0x4008F16")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public List<GameObject> wayPoints;

		// Token: 0x0400BF3E RID: 48958
		[Token(Token = "0x4008F17")]
		[FieldOffset(Offset = "0x40")]
		public GameObject segmentPrefab;

		// Token: 0x0400BF3F RID: 48959
		[Token(Token = "0x4008F18")]
		[FieldOffset(Offset = "0x48")]
		public int segmentCount;

		// Token: 0x0400BF40 RID: 48960
		[Token(Token = "0x4008F19")]
		[FieldOffset(Offset = "0x4C")]
		public float segmentSpacing;
	}
}
